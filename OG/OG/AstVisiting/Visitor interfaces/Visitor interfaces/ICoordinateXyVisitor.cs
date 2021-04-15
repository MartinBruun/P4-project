using OG.ASTBuilding.Terminals;

namespace OG.AstVisiting
{
    public interface ICoordinateXyVisitor
    {
        public void Visit(CoordinateXyValueNode node);
        public void Visit(OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode node);
    }
}