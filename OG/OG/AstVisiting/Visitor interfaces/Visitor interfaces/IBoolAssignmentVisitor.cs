using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IBoolAssignmentVisitor : IBoolNodeVisitor, IBoolFuncCallVisitor
    {
        public void Visit(BoolAssignmentNode node);
    }
}