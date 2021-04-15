using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;

namespace OG.AstVisiting
{
    public interface IBodyNodeVisitor : IStatementVisitor
    {
        public void Visit(BodyNode node);
    }
}