﻿using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class BoolNode : ExpressionNode
    {
        public enum BoolType
        {
            GenericBoolNode = 0,
            GenericInfixNode,
            EqualsNode,
            GreaterThanNode,
            LessThanNode,
            AndNode,
            OrNode,
            NegationNode,
            TrueNode,
            FalseNode,
            FunctionCallNode,
            IdValueNode
        }

        private BoolType BoolNodeType { get; set; } = 0;

        public BoolNode(string value, BoolType type):base(value,ExpressionType.BoolExpression)
        {
            BoolNodeType = type;
        }

        public BoolNode(OGParser.BoolExpressionContext boolExprContext, BoolType type) : base(boolExprContext.GetText(),ExpressionType.BoolExpression)
        {
            BoolNodeType = type;
        }
        
        public BoolNode(BoolNode node) : base(node)
        {
            BoolNodeType = node.BoolNodeType;
        }
        
        public override string ToString()
        {
            return "Type: " + BoolNodeType.ToString() + "\t Value: " + Value;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public interface IBoolNode : IExpressionNode
    {

    }
}