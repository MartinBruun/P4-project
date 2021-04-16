using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;

namespace OG.AstVisiting
{
    public interface IBodyNodeVisitorBundle : IStatementVisitorBundle
    {
        public void Visit(BodyNode node);
    }
}