using System;
using System.Collections.Generic;
using System.Configuration;
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
    public class CurveEmitterVisitor : CodeEmitterErrorInheritor,  IVisitor, IGCodeStringEmitter
    {
        protected SymbolTable _symbolTable;
        public IGCodeCommand ResultCommand { get; protected set; }

        private PointReferenceCoordinateTracker ToPointGCodeCreater { get; set; }
        private PointReferenceCoordinateTracker FromPointContainer { get; set; }
        private SingleMathResultVisitor angleCont;
        
        
        public CurveEmitterVisitor(SymbolTable symbolTable, List<SemanticError> errs):base(errs)
        {
            _symbolTable = symbolTable;
            FromPointContainer = new PointReferenceCoordinateTracker(_symbolTable, errs);
            ToPointGCodeCreater = new PointReferenceCoordinateTracker(_symbolTable, errs);
            angleCont = new SingleMathResultVisitor(_symbolTable, errs);
        }
        
        public object Visit(NumberNode node)
        {
            return node.NumberValue;
        }
        
                
        public string Emit()
        {
            Console.WriteLine(ResultCommand.CreateGCodeTextCommand());
            return ResultCommand.CreateGCodeTextCommand().Replace(',', '.');
        }
        

        private double EvaluateMathString(string expression)
        {
            return Eval.Execute<double>(expression);
        }
        
        
        /// <summary>
        /// Sets up the emission of the GCode command of a curve. 
        /// Creates Gcode arc command using G02 or G03 depending on angle. 
        /// </summary>
        /// <param name="node"></param>
        /// <returns>Empty Object</returns>
        public object Visit(CurveCommandNode node)
        {
            if (node?.To?.Count > 1)
            {
                SemanticErrors.Add(new SemanticError(node.Line, node .Column, "OG does not support to chaining in Curve commands."){IsFatal = false});
            }
            
            node.Angle.Accept(angleCont);
            node.To.First().Accept(ToPointGCodeCreater);
            node.From.Accept(FromPointContainer);

            Tuple<double, double> from = FromPointContainer.LastCalculatedCoordinateVals;
            GCodeCommandText fromCommand = new GCodeCommandText($"G01 X{from.Item1} Y{from.Item2}\n");
            
            Tuple<double, double> to = ToPointGCodeCreater.LastCalculatedCoordinateVals;
            double angle = angleCont.Result * (Math.PI / 180);
            string curveCommandWord = "";

            //Check for valid angle
            if (angle < 90 && angle > -90)
            {
                //If angle is 0 then it is a line.
                if (angle == 0)
                {
                    ResultCommand = new GCodeCommandText(fromCommand.CommandText + $"G01 X{from.Item1} Y{from.Item2}\n G01 X{to.Item1} Y{to.Item2}");
                    return new object();
                }

                //Find out where to place circle.
                if (angle < 0)
                {
                    curveCommandWord = "G03";
                } else if (angle > 0)
                {
                    curveCommandWord = "G02";
                }
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node.Line, node.Column, "Angle is more than 90 degrees or less than -90 degrees."){IsFatal = true});
                return null;
            }

            double radius = (Math.Sqrt(Math.Pow((from.Item1 - to.Item1), 2) + Math.Pow(from.Item2 - to.Item2,2))/2) //Pythagoras and distance
                            / (Math.Cos(90 * Math.PI / 180) - (Math.Abs(angle) * Math.PI / 180));

            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("ANGLE: " + angle);
            Console.WriteLine("From:" + from.Item1   + "    "  + from.Item2);
            ResultCommand = fromCommand + new GCodeCommandText(curveCommandWord + " " + $" X{to.Item1} Y{to.Item2} R{radius}");
            return new object();
        }
        
        #region Unused visit methods
        

        

        public object Visit(AssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IdAssignNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ParameterTypeNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(CommandNode node)
        {
            throw new System.NotImplementedException();
        }



        public object Visit(DrawCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IterationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(LineCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MovementCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NumberIterationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(UntilNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(DeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NumberDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolExprIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(StatementNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BodyNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(AndComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolTerminalNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(EqualsComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(LessThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NegationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(OrComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ParameterNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IFunctionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(AdditionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(DivisionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(InfixMathNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MathIdNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MathNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MultiplicationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PowerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(SubtractionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(TerminalMathNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PointFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointReferenceIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointReferenceNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeEndPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapePointReference node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapePointRefNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeStartPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(TuplePointNode node)
        {
            throw new NotImplementedException();
        }


        public object Visit(FalseNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IdNode node)
        {
            throw new System.NotImplementedException();
        }



        public object Visit(TrueNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MachineSettingNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ModificationPropertyNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(SizePropertyNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(AstNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(DrawNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ExpressionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ProgramNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(CoordinateXyValueNode node)
        {
            throw new System.NotImplementedException();
        }
         #endregion
    }

    internal class SingleMathResultVisitor:IVisitor, ISemanticErrorable
    {

        
        public double Result { get; private set; }
        public List<SemanticError> SemanticErrors { get; set; }
        private SymbolTable _symTable;
        public string TopNode { get; set; }
        public object Visit(NumberNode node)
        {
            Result = node.NumberValue;
            return new object();
        }

        public SingleMathResultVisitor(SymbolTable symbolTable, List<SemanticError> errs)
        {
            SemanticErrors = errs;
            _symTable = symbolTable;
        }

        #region Unused methods

        

        public object Visit(AssignmentNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolAssignmentNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(IdAssignNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MathAssignmentNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PointAssignmentNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ParameterTypeNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(CommandNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(CurveCommandNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(DrawCommandNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(IterationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(LineCommandNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MovementCommandNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(NumberIterationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(UntilNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(DeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(NumberDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PointDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolExprIdNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(StatementNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BodyNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(AndComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolTerminalNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(EqualsComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(LessThanComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MathComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(NegationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(OrComparerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(FunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(IFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MathFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ParameterNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(FunctionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(IFunctionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(AdditionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(DivisionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(InfixMathNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MathIdNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MultiplicationNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PowerNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(SubtractionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(TerminalMathNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PointFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PointReferenceIdNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(PointReferenceNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ShapeEndPointNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ShapePointReference node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ShapePointRefNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ShapeStartPointNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(TuplePointNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(FalseNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(IdNode node)
        {
            throw new NotImplementedException();
        }
        
        public object Visit(TrueNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MachineSettingNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ModificationPropertyNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(SizePropertyNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(AstNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(DrawNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ProgramNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(ShapeNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(CoordinateXyValueNode node)
        {
            throw new NotImplementedException();
        }
        #endregion

     
    }

    internal class PointReferenceCoordinateTracker : PointReferenceGCodeTextEmitter
    {
        
        public Tuple<double, double> LastCalculatedCoordinateVals;
        
        public PointReferenceCoordinateTracker(SymbolTable table, List<SemanticError> errs) : base(table, errs)
        {
        }

        public override void Visit(TuplePointNode node)
        {
            double xVal = EvaluateMathString(node.XValue.Value);
            double yVal = EvaluateMathString(node.YValue.Value);

            string formattedX = xVal.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
            string formattedY = yVal.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
            yVal = double.Parse(formattedY);
            xVal = double.Parse(formattedX);
            LastCalculatedCoordinateVals = new Tuple<double, double>(yVal, xVal);
        }
        
    }

   
}