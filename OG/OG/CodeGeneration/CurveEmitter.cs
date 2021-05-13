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
        
        
        public GCodeCommandText ResultCommand { get;  private set; }
        private GCodeCommandText ToPointCommand { get; set; }
        private GCodeCommandText FromPointCommand { get; set; }

        public CurveEmitter( List<SemanticError> errs) : base(errs)
        {

        }

        public void ClearResult()
        {
            ResultCommand        = null;
            ToPointCommand       = null;
            FromPointCommand = null;
        }
        
        public string Emit()
        {
            return ResultCommand.CreateGCodeTextCommand().Replace(',', '.');
        }

        public void SetupGCodeResult(CurveCommandNode node)
        {
            TuplePointNode tupleFrom = null;
            TuplePointNode tupleTo = null;
            bool validNode = CheckNodeValidity(node);
            if (validNode)
            {
                tupleFrom = (TuplePointNode)  node.From;
                tupleTo   = (TuplePointNode) node.To.First();
            }
            else
            {
                return;
            }
            
            Tuple<double, double> to = CreateTuple(tupleTo);
            Tuple<double, double> from = CreateTuple(tupleFrom);
            double angle = ((NumberNode) node.Angle).NumberValue;
            string curveCommandWord = "";

            //Check for valid angle
            if (angle < 90 && angle > -90)
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
                    curveCommandWord = "G03";
                }
                else if (angle > 0)
                {
                    curveCommandWord = "G02";
                }
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node.Line, node.Column,
                    "Angle is more than 90 degrees or less than -90 degrees.") {IsFatal = true});
                return;
            }

            //To radians
            angle *= Math.PI / 180;
            double radius = CalculateRadius(to, from, angle);
            
            ToPointCommand = new GCodeCommandText(curveCommandWord + " " +
                                                  $"X{to.Item1} Y{to.Item2} R{radius.ToString().Replace(',', '.')}");
            ResultCommand = FromPointCommand + ToPointCommand;
        }

        private double CalculateRadius(Tuple<double, double> to, Tuple<double, double> @from, double angle)
        {
            return Math.Sqrt(Math.Pow(from.Item1 - to.Item1, 2) + Math.Pow(@from.Item2 - to.Item2, 2)) /
                2 //Pythagoras and distance
                / (Math.Cos(90 * Math.PI / 180) - Math.Abs(angle) * Math.PI / 180);
        }


        private Tuple<double, double> CreateTuple(TuplePointNode node)
        {
            double xVal= ((NumberNode) node.XValue).NumberValue;
            double yVal = ((NumberNode) node.YValue).NumberValue;
            return new Tuple<double, double>(xVal, yVal);
        }

        private bool CheckNodeValidity(CurveCommandNode node)
        {
            if (node?.From == null || node.To == null || node.Angle == null)
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: Node was NULL"){IsFatal = true});
            }
            
            if (node?.From is TuplePointNode tupleTo)
            {
                FromPointCommand = CreateLineGCodeCommand(tupleTo);
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A point reference was not reduced to Tuple!"){IsFatal = true});
                return false;
            }

            if (node?.To?.First() is TuplePointNode tupleFrom)
            {
                FromPointCommand = CreateLineGCodeCommand(tupleFrom);
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A point reference was not reduced to Tuple!"){IsFatal = true});
                return false;
            }

            if (! (AssertNumberTuple(tupleFrom) && AssertNumberTuple(tupleTo)) )
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A mathematical expression inside a point was not reduced to number node!"){IsFatal = true});
                return false;
            }
            
            if (node?.To?.Count > 1)
            {
                SemanticErrors.Add(new SemanticError(node.Line, node.Column,
                    "OG does not support to chaining in Curve commands.") {IsFatal = false});
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