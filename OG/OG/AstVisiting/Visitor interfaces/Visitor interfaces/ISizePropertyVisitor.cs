using OG.ASTBuilding.TreeNodes.WorkAreaNodes;

namespace OG.AstVisiting
{
    public interface ISizePropertyVisitor
    {
        public void Visit(SizePropertyNode node);
    }
}