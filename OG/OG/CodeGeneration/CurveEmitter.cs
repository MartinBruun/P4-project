using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using OG.AstVisiting.Visitors.ExpressionReduction;
using Z.Expressions;

namespace OG.CodeGeneration
{
    
    public class CurveEmitter : CodeEmitterErrorInheritor, IGCodeStringEmitter
    {

        private double _angleRadians;
        private string curveCommandWord = "";
        public GCodeCommandText ResultCommand { get;  private set; }
        private GCodeCommandText ToChainPointCommand { get; set; }
        private GCodeCommandText StartPointCommand { get; set; }

        public CurveEmitter( List<SemanticError> errs) : base(errs)
        {
            ResultCommand = new GCodeCommandText("");
            ToChainPointCommand = new GCodeCommandText("");
            StartPointCommand = new GCodeCommandText("");
        }

        public void ClearResult()
        {
            ResultCommand = new GCodeCommandText("");
            ToChainPointCommand = new GCodeCommandText("");
            StartPointCommand = new GCodeCommandText("");
        }
        
        public string Emit()
        {
            return ResultCommand.CreateGCodeTextCommand().Replace(',', '.');
        }

        public void SetupGCodeResult(CurveCommandNode node)
        {
            _angleRadians = (((NumberNode) node.Angle).NumberValue) * Math.PI / 180;
            
            if (_angleRadians == 0 && CheckNodeValidity(node))
            {
                LineEmitter lineEmitter = new LineEmitter(SemanticErrors);
                LineCommandNode l = new LineCommandNode(node.From, node.To);
                lineEmitter.SetupGCodeResult(l);
                ResultCommand = lineEmitter.ResultCommand;
                SemanticErrors.Add(new SemanticError(node,
                    "WARNING: Curve command with angle 0. Use line command instead!"));
            }
            else if (_angleRadians <= 90 && _angleRadians >= -90 && CheckNodeValidity(node))
            {
                if (_angleRadians < 0)
                {
                    curveCommandWord = "G02";
                }
                else if (_angleRadians > 0)
                {
                    curveCommandWord = "G03";
                }
                ResultCommand = CreateFinalCurveCommand(node);
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node.Line, node.Column,
                    "Angle is more than 90 degrees or less than -90 degrees.") {IsFatal = true});
                return;
            }
        }

        private Tuple<double, double> TuplePointToTuple(TuplePointNode node)
        {
            return new Tuple<double,double>(( (NumberNode) node.XValue ).NumberValue,
                ( (NumberNode) node.YValue ).NumberValue);
        }

        private GCodeCommandText CreateFinalCurveCommand(CurveCommandNode node)
        {
            TuplePointNode currentFrom = (TuplePointNode) node.From;
            TuplePointNode currentTo;
            double radius;
            
            foreach (PointReferenceNode pnode in node.To)
            {
                currentTo = (TuplePointNode) pnode;
                radius = CalculateRadius(currentFrom, currentTo);
                
                ToChainPointCommand += new GCodeCommandText(
                    curveCommandWord + 
                    $" X{((NumberNode)currentTo.XValue).NumberValue} Y{((NumberNode)currentTo.YValue).NumberValue} R{radius.ToString().Replace(',', '.')} \n");
                currentFrom = currentTo;
            }
            return StartPointCommand + ToChainPointCommand;
        }

        private double CalculateRadius(TuplePointNode currentFrom, TuplePointNode toNode)
        {
            Tuple<double, double> from = TuplePointToTuple(currentFrom);
            Tuple<double, double> to = TuplePointToTuple(toNode);
            return CalculateRadius(to, from);
        }

        private double CalculateRadius(Tuple<double, double> @from, Tuple<double, double> to)
        {
            double fromToDist = Math.Sqrt(Math.Pow(from.Item1 - to.Item1, 2) + Math.Pow(@from.Item2 - to.Item2, 2));
            double angle = Math.Cos(0.5 * Math.PI - Math.Abs(_angleRadians));

            var result = (fromToDist / 2) / angle;
            return result;

        }

        private bool CheckNodeValidity(CurveCommandNode node)
        {
            if (node?.From == null || node.To == null || node.To.Count == 0 || node.Angle == null)
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: Node was NULL"){IsFatal = true});
            }
            
            if (node?.From is TuplePointNode tupleFrom)
            {
                StartPointCommand = CreateLineGCodeCommand(tupleFrom);
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A point reference was not reduced to Tuple!"){IsFatal = true});
                return false;
            }

            TuplePointNode tupleTo = null;
            foreach (PointReferenceNode pointReferenceNode in node.To)
            {
                if (!(pointReferenceNode is TuplePointNode t))
                {
                    SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A point reference was not reduced to Tuple!"){IsFatal = true});
                    return false;
                }

                tupleTo = t;
            }
            
            if (! (AssertNumberTuple(tupleFrom) && AssertNumberTuple(tupleTo)) )
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A mathematical expression inside a point was not reduced to number node!"){IsFatal = true});
                return false;
            }
            
          
            if (!(node.Angle is NumberNode))
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A mathematical expression inside angle of a curve command was not reduced to number node!"){IsFatal = true});
                return false;
            }

            return true;
        }

        private bool AssertNumberTuple(TuplePointNode node)
        {
            if (node.XValue is NumberNode x && node.YValue is NumberNode y)
            {
                return true;
            }
            else 
                return false;
        }

        private GCodeCommandText CreateLineGCodeCommand(TuplePointNode node)
        {
            string formattedX ="";
            string formattedY ="";
            if (node.XValue is NumberNode x && node.YValue is NumberNode y)
            {
                formattedX = x.NumberValue.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
                formattedY = y.NumberValue.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A mathematical expression inside a point was not reduced to number node!"){IsFatal = true});
                return null;
            }
            return new GCodeCommandText($"G01 X{formattedX} Y{formattedY}\n");
        }
    }
}