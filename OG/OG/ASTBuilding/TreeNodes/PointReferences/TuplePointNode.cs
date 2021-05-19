﻿using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class TuplePointNode : PointReferenceNode
    {
        public MathNode XValue { get; set; }
        public MathNode YValue { get; set; }

        public TuplePointNode(string pointText, MathNode xValue, MathNode yValue) : base(pointText, PointReferenceNodeType.NumberTupleNode)
        {
            XValue = xValue;
            YValue = yValue;
        }
        public TuplePointNode(TuplePointNode node) : base(node)
        {
            XValue = node.XValue;
            YValue = node.YValue;
        }

        public override void Accept(IPointReferenceNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}