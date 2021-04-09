using System;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class PointReferenceIdNode : PointReferenceNode
    {
        public IdNode Id { get; set; }

        public PointReferenceIdNode(string pointText, IdNode id) : base(pointText, PointReferenceNodeType.PointIdNode)
        {
            Id = id;
        }
    }
}