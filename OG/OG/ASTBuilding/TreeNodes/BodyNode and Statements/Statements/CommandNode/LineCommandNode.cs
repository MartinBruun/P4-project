using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class LineCommandNode : MovementCommandNode
    {
        public LineCommandNode(PointReferenceNode fromPosition, List<PointReferenceNode> toPosition): base(fromPosition, toPosition)
        {
        }
    }
}