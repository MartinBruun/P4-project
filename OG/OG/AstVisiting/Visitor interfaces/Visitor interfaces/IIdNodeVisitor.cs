using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.AstVisiting
{
    public interface IIdNodeVisitor
    {
        public void Visit(IdNode node);
    }
}