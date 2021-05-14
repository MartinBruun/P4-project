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
using Z.Expressions;

namespace OG.CodeGeneration
{
    
    public class CurveEmitter : CodeEmitterErrorInheritor, IGCodeStringEmitter
    {

        private double _angle;
        private string curveCommandWord = "";
        private int ToCommandsLeft = 1;
        private double _radius = 0;
        public GCodeCommandText ResultCommand { get;  private set; } =  new GCodeCommandText("");
        private GCodeCommandText ToChainPointCommand { get; set; } = new GCodeCommandText("");
        private GCodeCommandText StartPointCommand { get; set; } = new GCodeCommandText("");

        public CurveEmitter( List<SemanticError> errs) : base(errs)
        {

        }

        public void ClearResult()
        {
            ResultCommand        = null;
            ToChainPointCommand       = null;
            StartPointCommand = null;
        }
        
        public string Emit()
        {
            return ResultCommand.CreateGCodeTextCommand().Replace(',', '.');
        }
        
        
        

        public void SetupGCodeResult(CurveCommandNode node)
        {
            
            
            //CHECK VALID


            NumberNode fromX = (NumberNode) ((TuplePointNode) node.From).XValue;
            NumberNode fromY = (NumberNode) ((TuplePointNode) node.From).YValue;
            StartPointCommand = new GCodeCommandText($"G01 X{fromX} Y{fromY}\n");
            NumberNode currentToX = null;
            NumberNode currentToY = null;
            
            if (_angle == 0)
            {
                LineEmitter lineEmitter = new LineEmitter(SemanticErrors);
                LineCommandNode l = new LineCommandNode(node.From, node.To);
                lineEmitter.SetupGCodeResult(l);
                ResultCommand = lineEmitter.ResultCommand;
                SemanticErrors.Add(new SemanticError(node,
                    "WARNING: Curve command with angle 0. Use line command instead!"));
                return;
            }
            else if (_angle <= 90 && _angle >= -90)
            {
                if (_angle < 0)
                {
                    curveCommandWord = "G02";
                }
                else if (_angle > 0)
                {
                    curveCommandWord = "G03";
                }



                CreateFinalCurveCommand(node);
                  
                
                
                
                
                
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node.Line, node.Column,
                    "Angle is more than 90 degrees or less than -90 degrees.") {IsFatal = true});
                return;
            }
           
            
            
            TuplePointNode currentFromTuple = null;
            TuplePointNode currentToTuple = null;
            
            bool validNode = CheckNodeValidity(node);
            if (validNode)
            {
                currentFromTuple = (TuplePointNode)  node.From;
                currentToTuple   = (TuplePointNode) node.To.First();
            }
            else
            {
                return;
            }
            
            
            
            
            
            
            
            Tuple<double, double> to = CreateTuple(currentToTuple);
            Tuple<double, double> from = CreateTuple(currentFromTuple);
            double angle = ((NumberNode) node.Angle).NumberValue;


            //Check for valid angle
            if (angle <= 90 && angle >= -90)
            {
                //If angle is 0 then it is a line.
                if (angle == 0)
                {
                    ResultCommand = new GCodeCommandText($"G01 X{from.Item1} Y{from.Item2}\n G01 X{to.Item1} Y{to.Item2}");
                    SemanticErrors.Add(new SemanticError(node,
                        "WARNING: Curve command with angle 0. Use line command instead!"));
                    return;
                }

                //Find out where to place circle.
                if (angle < 0)
                {
                    curveCommandWord = "G02";
                }
                else if (angle > 0)
                {
                    curveCommandWord = "G03";
                }
            }
            else
            {
 
            }

            //To radians
            angle *= Math.PI / 180;
            double radius = CalculateRadius(to, from, angle);
            
            
            ResultCommand = StartPointCommand + ToChainPointCommand;
        }

        private Tuple<double, double> TuplePointToTuple(TuplePointNode node)
        {
            return new Tuple<double,double>(( (NumberNode) node.XValue ).NumberValue,
                ( (NumberNode) node.YValue ).NumberValue);
        }

        private void CreateFinalCurveCommand(CurveCommandNode node)
        {
            var currentFrom = node.From;
            
            Tuple<double, double> from = TuplePointToTuple((TuplePointNode)node.From);
            StartPointCommand = new GCodeCommandText($"G01 X{from.Item1} Y{from.Item2}\n");
            
            double radius = 0;
            foreach (PointReferenceNode pnode in node.To)
            {
                radius = CalculateRadius((TuplePointNode)pnode, (TuplePointNode)currentFrom, _angle);
                
                
                
                
                ToChainPointCommand = new GCodeCommandText(curveCommandWord +
                                                           $"X{to.Item1} Y{to.Item2} R{radius.ToString().Replace(',', '.')} \n");

                currentFrom = pnode;
            }
            
        }

        private double CalculateRadius(TuplePointNode currentFrom, TuplePointNode toNode, double angle)
        {
            Tuple<double, double> from = TuplePointToTuple(currentFrom);
            Tuple<double, double> to = TuplePointToTuple(toNode);
            return CalculateRadius(to, from, angle);
        }

        private double CalculateRadius(Tuple<double, double> @from, Tuple<double, double> to, double angleInRadians)
        {
            double fromToDist = Math.Sqrt(Math.Pow(from.Item1 - to.Item1, 2) + Math.Pow(@from.Item2 - to.Item2, 2));
            angleInRadians = Math.Cos(0.5 * Math.PI - Math.Abs(angleInRadians));

            var result = (fromToDist / 2) / angleInRadians;
            return result;

        }


        private Tuple<double, double> CreateTuple(TuplePointNode node)
        {
            double xVal= ((NumberNode) node.XValue).NumberValue;
            double yVal = ((NumberNode) node.YValue).NumberValue;
            return new Tuple<double, double>(xVal, yVal);
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