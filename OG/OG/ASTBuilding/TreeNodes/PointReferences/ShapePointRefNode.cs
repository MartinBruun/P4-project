﻿using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class ShapePointRefNode : AstNode
    {
        public  IdNode ShapeNameId{ get; set; }

        public enum PointTypes
        {
            StartPoint,
            Endpoint
        }

        public PointTypes PointType
        {
            get;
            set;
        }
        
        public ShapePointRefNode(IdNode id, PointTypes p)
        {
            ShapeNameId = id;
            PointType = p;
        }
        public ShapePointRefNode(ShapePointRefNode node) : base(node)
        {
            ShapeNameId = node.ShapeNameId;
            PointType = node.PointType;
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}