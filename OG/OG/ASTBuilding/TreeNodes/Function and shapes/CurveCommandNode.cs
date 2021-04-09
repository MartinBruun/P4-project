using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public class CurveCommandNode : MovementCommand
    {
        public MathNode angle;


        public CurveCommandNode(MathNode angleExpression, PositionNode fromPosition, PositionNode ToPosition)
        {
            angle = angleExpression;
            from = fromPosition;
            to = ToPosition;
        }
    }
}