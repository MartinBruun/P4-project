using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;

namespace OG.AstVisiting
{
    public interface IIterationNodeVisitorBundleBundle : IUntilNodeVisitorBundleBundle, INumberIterationNodeVisitor
    {
        public void Visit(BodyNode node);
    }
}