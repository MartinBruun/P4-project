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
    public class ToStringVisitor : IProgramVisitor
    {
        public void Visit(MathFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(BoolFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(PointFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(FunctionCallAssignNode node)
        {
            throw new System.NotImplementedException();
        }

        void IFunctionCallNodeVisitor.Visit(UntilFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(UntilNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ParameterNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(FunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(BoolDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(NumberDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(PointDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(LineCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(CurveCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        void IUntilFunctionCallVisitor.Visit(UntilFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(NumberIterationNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(IdNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(AdditionNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(SubtractionNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(MultiplicationNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(DivisionNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(NumberNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(MathIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(PowerNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(LessThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(GreaterThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(EqualsComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(NegationNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(OrComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(AndComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(FalseNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(TrueNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(PointReferenceIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ShapeEndPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ShapeStartPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(TuplePointNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(DrawCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(DrawNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(CoordinateXyValueNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(PropertyAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(MathAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(BoolAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(PointAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(BodyNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ShapeNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(IFunctionNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(FunctionNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(SizePropertyNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(WorkAreaSettingNode node)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ProgramNode node)
        {
            throw new System.NotImplementedException();
        }
    }
}