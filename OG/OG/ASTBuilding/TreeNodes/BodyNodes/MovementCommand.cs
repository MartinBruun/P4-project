using OG.AST.Shapes;

namespace OG.AST.TreeNodes.BodyNodes.CommandNodes
{
    public abstract class MovementCommand : CommandNode
    {
        public PositionNode from;
        public PositionNode to;
    }
}