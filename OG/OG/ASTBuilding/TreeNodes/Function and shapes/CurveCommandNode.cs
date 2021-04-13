using System.Collections.Generic;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public class CurveCommandNode : MovementCommandNode
    {
        public MathNode Angle;

        public CurveCommandNode(PointReferenceNode fromPosition, List<PointReferenceNode> toPosition, MathNode angleExpression)
        {
            Angle = angleExpression;
            From = fromPosition;
            To = toPosition;
        }
    }
}