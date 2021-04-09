namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public class LineCommandNode : MovementCommand
    {
        public LineCommandNode(PositionNode fromPosition, PositionNode ToPosition)
        {
            from = fromPosition;
            to = ToPosition;
        }
    }
}