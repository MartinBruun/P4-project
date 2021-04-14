using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public abstract class MovementCommandNode : CommandNode
    {
        public PointReferenceNode From { get; set; }
        public List<PointReferenceNode> To { get; set; }

        public MovementCommandNode(PointReferenceNode from, List<PointReferenceNode> toNodes)
        {
            From = from;
            To = toNodes;
        }
    }
}