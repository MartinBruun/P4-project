﻿namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class NegationNode : BoolNode
    {
        public BoolNode BoolExpression;

        public NegationNode(BoolNode boolExpr, string value):base(value, BoolType.NegationNode)
        {
            BoolExpression = boolExpr;
        }
    }
}