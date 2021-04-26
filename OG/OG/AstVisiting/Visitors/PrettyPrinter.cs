using System;
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

namespace OG.AstVisiting.Visitors
{
    public class PrettyPrinter : IVisitor
    {
    
        public object Visit(ProgramNode node)
        {
        Console.WriteLine("\n\nVisiting Machine Settings: \n");
            foreach (var setting in node.MachineSettingNodes)
            {
                setting.Accept(this);
            }
            
            node.drawNode.Accept(this);
            foreach (var funcDcl in node.FunctionDcls)
            {
                funcDcl.Accept(this);
            }

            foreach (var shapeDcl in node.ShapeDcls)
            {
                shapeDcl.Accept(this);
            }
            
            return new object();
        }
        
        public object Visit(DrawNode node)
        {
            Console.WriteLine("draw {");
            foreach (var drawCommand in node.drawCommands)
            {
                drawCommand.Accept(this);
                Console.WriteLine(";");
            }
            Console.WriteLine("}\n");
            
            
            return new object();
            
        }
        
        public object Visit(DrawCommandNode node)
        {
            node.Id.Accept(this);
            if (node.From != null)
            {
                node.From.Accept(this);
            }
            
            return new object();
        }
        
        public object Visit(FunctionNode node)
        {
            Console.Write("function ");
            Console.Write(node.ReturnType);
            node.Id.Accept(this);
            Console.Write("(");
            // foreach (var param in node)
            // {
            //    
            // }
            Console.Write(") {\n");
            node.Body.Accept(this);
            Console.WriteLine("}");
            
            return new object();
        }
        
        public object Visit(StatementNode node)
        {
            node.Accept(this);
            return new object();
        }

        public object Visit(BodyNode node)
        {
            foreach (var statement in node.StatementNodes)
            {
                statement.Accept(this);
            }
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
            Console.Write("shape ");
            node.Id.Accept(this);
            Console.Write(" {\n");
            node.Body.Accept(this);
            Console.WriteLine("} ");
            return new object();
        }
        
        public object Visit(AssignmentNode node)
        {
            Console.WriteLine("Assignment Node: " + node.ToString());
            return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedValue.Accept(this);
            Console.Write(";\n");
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            Console.Write("FUNCTION CALL ASSIGN NODE HERE");
            node.Id.Accept(this);
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
            Console.Write("ID ASSIGN NODE: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedValue.Accept(this);
            Console.Write(";\n");
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            Console.Write("PointAssignmentNode: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            Console.Write("PropertyAssignmentNode: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(CommandNode node)
        {
            Console.Write("Command Node: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

       

        public object Visit(IterationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
            Console.Write("line.from");
            node.From.Accept((this));
            foreach (var toCommand in node.To)
            {
                Console.Write(".to");
                toCommand.Accept(this);
            }
            Console.Write(";\n");
            return new object();
        }
        
        public object Visit(PointReferenceNode node)
        {
            node.Accept(this);
            return new object();
        }
        
        public object Visit(TuplePointNode node)
        {
            Console.Write("(");
            node.XValue.Accept(this);
            Console.Write(", ");
            node.YValue.Accept(this);
            Console.Write(")");
            
            return new object();
        }

        
        public object Visit(CoordinateXyValueNode node)
        {
            Console.Write(node.Value);
            return new object();
     
        }

        public object Visit(MovementCommandNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(NumberIterationNode node)
        {
            Console.Write("repeat(");
            node.Iterations.Accept(this);
            Console.Write(")\n");
            node.Body.Accept(this);
            Console.Write("\nrepeat.end\n");
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(UntilNode node)
        {
            Console.Write("repeat.until(");
            node.Predicate.Accept(this);
            Console.Write(")\n");
            node.Body.Accept(this);
            Console.Write("repeat.end\n");
            
            return new object();
        }

        public object Visit(BoolDeclarationNode node)
        {
            Console.Write("bool ");
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedExpression.Accept(this);
            Console.Write(";\n");
            return new object();
        }

        public object Visit(DeclarationNode node)
        {
            Console.Write("DeclarationNode: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(NumberDeclarationNode node)
        {
            Console.Write("number ");
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedExpression.Accept(this);
            Console.Write(";\n");
            
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Console.Write("point ");
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedExpression.Accept(this);
            Console.Write(";\n");
            return new object();
        }

        

        public object Visit(AndComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
            Console.WriteLine("BoolComparer: " + node.ToString());
            return new object();
        }

        public object Visit(BoolNode node)
        {
            Console.Write(node.Value);
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
            Console.WriteLine("Terminal node: " + node.ToString());
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MathComparerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(NegationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            Console.Write("BoolFunctionCallNode: ");
            node.FunctionName.Accept(this);
            Console.Write("(");
            if (node.Parameters.Count != 0)
            {
                foreach (var param in node.Parameters)
                {
                    param.Accept(this);
                }
            }
            Console.Write(")");
            return new object();
        }

        public object Visit(FunctionCallNode node)
        {
            node.FunctionName.Accept(this);
            Console.Write("(");
            if (node.Parameters.Count != 0)
            {
                foreach (var param in node.Parameters)
                {
                    param.Accept(this);
                }
            }
            Console.Write(");");
            return new object();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            Console.Write("FUNCTION CALL NODE WITH PARAMS HER!!!!!!");
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            Console.Write("FUNCTION CALL NODE LINE 313!!!!!!!");
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
            
            node.FunctionName.Accept(this);
            Console.Write("(");
            foreach (var param in node.Parameters)
            {
                param.Accept(this);
            }
            Console.Write(")");
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            node.Expression.Accept(this);
            return new object();
        }

       

        public object Visit(IFunctionNode node)
        {
            Console.Write("FUNCTION CALL NODE LINE 334!!!!!!!");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            node.LHS.Accept(this);
            Console.Write(" + ");
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(DivisionNode node)
        {
            node.LHS.Accept(this);
            Console.Write(" / ");
            node.RHS.Accept(this);
            
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
            Console.Write(node.ToString());
            return new object();
        }

        public object Visit(MathIdNode node)
        {
            node.AssignedValueId.Accept(this);
            return new object();
        }

        public object Visit(MathNode node)
        {
            Console.Write(node.ToString());
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {
            Console.Write("MultiplicationNode: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PowerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(SubtractionNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
            Console.Write("PointFunctionCallNode: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            Console.Write("PointReferenceIdNode: ");
            Console.WriteLine(node.ToString());
            return new object();
        }

        

        public object Visit(ShapeEndPointNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(ShapePointReference node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        
        public object Visit(FalseNode node)
        {
            Console.Write(node.Value);
            return new object();
        }

        public object Visit(IdNode node)
        {
            Console.Write(node.Value);
            return new object();
        }

        public object Visit(NumberNode node)
        {
            Console.Write(node.ToString());
            return new object();
        }

        public object Visit(TrueNode node)
        {
            Console.Write(node.Value);
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(AstNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        

        public object Visit(ExpressionNode node)
        {
            node.Accept(this);
            return new object();
        }

        

       

        
    }
}