using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IPointReferenceAssignmentVisitor : IPointReferenceNodeVisitor, IPointFuncCallVisitor
    {
        public void Visit(PointAssignmentNode node);
    }
}