using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IShapeNodeVisitor : IBodyNodeVisitor
    {
        public void Visit(ShapeNode node);
    }
}