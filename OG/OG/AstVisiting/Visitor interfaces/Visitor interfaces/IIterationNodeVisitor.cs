using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;

namespace OG.AstVisiting
{
    public interface IIterationNodeVisitor : IUntilNodeVisitor, INumberIterationNodeVisitor
    {
        public void Visit(BodyNode node);
    }
}