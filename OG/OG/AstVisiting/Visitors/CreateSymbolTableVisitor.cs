using System;
using System.Collections.Generic;
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
    public class CreateSymbolTableVisitor : IVisitor
    {
        private Dictionary<string, string> symTable = new Dictionary<string, string>();
        Stack<string> stack = new Stack<string>();

        void PrintSymbolTable()
        {
            foreach (var item in symTable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        
        object IVisitor.Visit(ProgramNode node)
        {
            Console.WriteLine("Creating SymbolTable");


            {
                try
                {
                    foreach (var item in node.FunctionDcls)
                    {
                        KeyValuePair<string, string> element =
                            new KeyValuePair<string, string>(item.Id.Value, item.ReturnType);
                        symTable.Add(element.Key, element.Value);
                        item.Accept(this);
                        Console.WriteLine(element);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    foreach (var item in node.ShapeDcls)
                    {
                        KeyValuePair<string, string> element =
                            new KeyValuePair<string, string>(item.Id.Value, "shape");
                        symTable.Add(element.Key, element.Value);
                        Console.WriteLine(element);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            PrintSymbolTable();
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

        public object Visit(DrawCommandNode node)
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
            node.From.Accept(this);
            foreach (var to in node.To)
            {
                Console.Write(".to");
                to.Accept(this);
            }
            Console.WriteLine(); 
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
            Console.Write(node.Id.Value);
            Console.Write(" = ");
            Console.Write(node.AssignedExpression);
            Console.Write(" \n ");

            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(StatementNode node)
        {
            node.Accept(this);
            
            return new object();
        }

        public object Visit(BodyNode node)
        {
            foreach (var item in node.StatementNodes)
            {
                item.Accept(this);
            }

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
            node.FunctionName.Accept(this);
            foreach (var p in node.Parameters)
            {
                p.Accept(this);
            }
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
            Console.Write(node.ParamType);
             node.ParameterId.Accept(this);
             node.Expression.Accept(this);
            Console.Write(","); 
            return new object();
        }

        public object Visit(FunctionNode node)
        {
            node.Id.Accept(this);
            node.Body.Accept(this);
            
            return new object();
        }

        public object Visit(IFunctionNode node)
        {
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(AdditionNode node)
        {
           node.LHS.Accept(this);
           Console.Write("+");
           node.RHS.Accept(this);
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
            Console.Write(node.Value); 
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
            Console.Write("(");
            node.XValue.Accept(this);
            node.YValue.Accept(this);
            Console.WriteLine(")");
            return new object();
        }

        public object Visit(FalseNode node)
        {
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(IdNode node)
        {
            Console.WriteLine(node.ToString()); 
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

        object IVisitor.Visit(DrawNode node)
        {
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ExpressionNode node)
        {
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        

        public object Visit(ShapeNode node)
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