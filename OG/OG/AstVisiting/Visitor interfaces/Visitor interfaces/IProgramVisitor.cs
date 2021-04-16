using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IProgramVisitor
    {
        public void Visit(ProgramNode node);
    }
}
