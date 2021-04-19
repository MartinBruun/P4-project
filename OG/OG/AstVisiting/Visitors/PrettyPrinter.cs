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
            Console.WriteLine(node.ToString());
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
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(CommandNode node)
        {
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
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(NumberIterationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(UntilNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(BoolDeclarationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(DeclarationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(NumberDeclarationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        

        public object Visit(AndComparerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(BoolNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
            Console.WriteLine(node.ToString());
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
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(FunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

       

        public object Visit(IFunctionNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(DivisionNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MathIdNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MathNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {
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
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
            
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

        public object Visit(TuplePointNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(FalseNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(IdNode node)
        {
            Console.Write(node.ToString());
            return new object();
        }

        public object Visit(NumberNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
        }

        public object Visit(TrueNode node)
        {
            Console.WriteLine(node.ToString());
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
            Console.WriteLine(node.ToString());
            return new object();
        }

        

       

        public object Visit(CoordinateXyValueNode node)
        {
            Console.WriteLine(node.ToString());
            return new object();
     
        }
    }
}