using System.Collections.Generic;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
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