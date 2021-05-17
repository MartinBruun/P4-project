﻿using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class NegationNode : BoolNode//, IBoolNodeVisitable
    {
        public BoolNode BoolExpression;

        public NegationNode(BoolNode boolExpr, string value):base(value, BoolType.NegationNode)
        {
            BoolExpression = boolExpr;
        }
        public NegationNode(NegationNode node) : base(node)
        {
            BoolExpression = node.BoolExpression;
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public interface IPreFixBoolNode
    {
        
    }

    public interface INegationNode : IPreFixBoolNode
    {
        public BoolNode BoolExpression { get; set; }
    }
}