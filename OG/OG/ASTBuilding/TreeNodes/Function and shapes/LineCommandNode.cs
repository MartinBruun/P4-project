using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public class LineCommandNode : MovementCommandNode
    {
        public LineCommandNode(PointReferenceNode fromPosition, List<PointReferenceNode> toPosition): base(fromPosition, toPosition)
        {
        }
    }
}