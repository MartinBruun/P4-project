﻿using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;
using IMathNodeVisitor = OG.CodeGeneration.IMathNodeVisitor;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class NumberNode: TerminalMathNode, IMathVisitable
    {
        public double NumberValue { get; set; }

        public NumberNode(double value):base(value.ToString(),MathType.NumberNode)
        {
            NumberValue = value;
        }
        public NumberNode(NumberNode node) : base(node)
        {
            NumberValue = node.NumberValue;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override NumberNode Accept(OG.CodeGeneration.IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}