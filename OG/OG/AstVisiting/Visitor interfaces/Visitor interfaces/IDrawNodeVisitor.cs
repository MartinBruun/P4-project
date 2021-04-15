using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IDrawNodeVisitor : IDrawCommandVisitor
    {
        public void Visit(DrawNode node);
    }
}