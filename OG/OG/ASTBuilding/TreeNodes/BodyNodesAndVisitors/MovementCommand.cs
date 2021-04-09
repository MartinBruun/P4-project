using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public abstract class MovementCommand : CommandNode
    {
        public PositionNode from;
        public PositionNode to;
    }
}