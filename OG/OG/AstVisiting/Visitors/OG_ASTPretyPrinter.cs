using System;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
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
    public class OG_ASTPretyPrinter:IProgramVisitor
    {
         public void Visit(MathFunctionCallNode node)
         {
             Console.WriteLine("function number");
            Visit(node.FunctionName);
            Console.WriteLine("(");

            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
            Console.WriteLine(")");

        }

        public void Visit(BoolFunctionCallNode node)
        {
            Console.WriteLine("function bool");
            Visit(node.FunctionName);
            Console.WriteLine("(");
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
            Console.WriteLine(")");  
        }

        public void Visit(PointFunctionCallNode node)
        {
            Console.WriteLine("function point");
            Visit(node.FunctionName);
            Console.WriteLine("(");
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
            Console.WriteLine(")");  

        }

        //TODO: HVad er dette????
        public void Visit(FunctionCallAssignNode node)
        {
            Console.WriteLine("function assign???");
            Visit(node.FunctionName);
            Console.WriteLine("(");
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
            Console.WriteLine(")");  

        }

        public void Visit(UntilNode node)
        {
            Console.WriteLine(node.ToString());

        }

        public void Visit(FunctionCallParameterNode node)
        {
            
            Console.WriteLine(node.ParameterId+":"+node.Expression);
        }

        public void Visit(ParameterNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(FunctionCallNode node)
        {
            Console.WriteLine(node.FunctionName);
            Console.WriteLine(node.Parameters);


        }

        public void Visit(BoolDeclarationNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(NumberDeclarationNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(PointDeclarationNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(LineCommandNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(CurveCommandNode node)
        {
            Console.WriteLine(node.ToString());
        }

        void IUntilFunctionCallVisitor.Visit(UntilFunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(NumberIterationNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(IdNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(AdditionNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(SubtractionNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(MultiplicationNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(DivisionNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(NumberNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(MathIdNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(PowerNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(LessThanComparerNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(GreaterThanComparerNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(EqualsComparerNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(NegationNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(OrComparerNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(AndComparerNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(FalseNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(TrueNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(PointReferenceIdNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(IPointReferenceNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ShapeEndPointNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(ShapeStartPointNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(TuplePointNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(DrawCommandNode node)
        {
            
            Console.WriteLine("DID I GET HERE?"+node.ToString());
        }

        public void Visit(DrawNode node)
        {
            Console.WriteLine("draw{");
            foreach (var cmd in node.drawCommands)
            {
                if (cmd != null ){
                    if (cmd.From != null)
                    {
                        cmd.Id.Accept(this);
                        cmd.From.Accept(this);
                        Console.WriteLine(";\n");

                    }
                    else
                    {
                        cmd.Id.Accept(this);
                        Console.WriteLine(";\n");


                    }
                }
            }
            Console.WriteLine("}\n");
        }

        public void Visit(CoordinateXyValueNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(PropertyAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(MathAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(BoolAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(PointAssignmentNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(BodyNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(ShapeNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(IFunctionNode node)
        {
            
            Console.WriteLine(node.ToString());
        }

        public void Visit(FunctionNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(SizePropertyNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(WorkAreaSettingNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(IMachineSettingVisitable node)
        {
            Console.WriteLine("Machine."+node.ToString());
            node.Accept(this);
        }

        public void Visit(ProgramNode node)
        {
            Console.WriteLine("THE PROGRAM:\n\n");
            
            foreach (var setting in node.MachineSettingNodes)
            {
                Console.WriteLine("Found Setting....Needs fixing is recursive");
                // setting.Accept(this);
            }
            
            node.drawNode.Accept(this);
            
            foreach (var item in node.FunctionDcls)
            {
                item.Accept(this);
            }
            
            foreach (var item in node.ShapeDcls)
            {
                item.Accept(this);
            }
            
            
        }

        
    }
}