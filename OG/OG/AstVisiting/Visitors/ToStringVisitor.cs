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
    public class ToStringVisitor : IAllBaseNodeVisitorBundle
    {
        public void Visit(MathFunctionCallNode node)
        {
            Console.WriteLine("MathfuncCall: " + node.ToString());
            Visit(node.FunctionName);
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
        }

        public void Visit(BoolFunctionCallNode node)
        {
            Console.WriteLine("BoolFunc call: " + node.ToString());
            Visit(node.FunctionName);
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
        }

        public void Visit(PointFunctionCallNode node)
        {
            Console.WriteLine("PointFunc call: " + node.ToString());
            Visit(node.FunctionName);
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
        }

        public void Visit(FunctionCallAssignNode node)
        {
            Console.WriteLine("PointFunc call assign: " + node.ToString());
            Visit(node.FunctionName);
            foreach (ParameterNode parameterNode in node.Parameters)
            {
                Visit(parameterNode);
            }
        }

        public void Visit(UntilNode node)
        {
            Console.WriteLine(node.ToString());

        }

        public void Visit(FunctionCallParameterNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(ParameterNode node)
        {
            Console.WriteLine(node.ToString());
        }

        public void Visit(FunctionCallNode node)
        {
            Console.WriteLine(node.ToString());
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
            Console.WriteLine(node.ToString());
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
            Console.WriteLine(node.ToString());
        }

        public void Visit(DrawNode node)
        {
            Console.WriteLine("Found Draw node"+node.ToString());
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

        public void Visit(IMachineSettingVisitable setting)
        {
            throw new NotImplementedException();
        }

        public void Visit(ProgramNode node)
        {
            Console.WriteLine("Found ProgramNode"+node.ToString());
            node.drawNode.Accept(this);
        }


   
    }
}