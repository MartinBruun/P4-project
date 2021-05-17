using System;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class BoolExprIdNode: BoolNode, IVisitable
    {
        public IdNode Id;
        public BoolExprIdNode(string value,IdNode id, BoolType type) : base(value, type)
        {
            Id = id;
        }
        public BoolExprIdNode(BoolExprIdNode node) : base(node)
        {
            Id = node.Id;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}