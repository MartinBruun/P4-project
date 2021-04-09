﻿namespace OG.ASTBuilding.Terminals
{
    public class DivisionNode : InfixMathNode
    {
        public DivisionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.DivisionNode)
        {
        }

    }
}