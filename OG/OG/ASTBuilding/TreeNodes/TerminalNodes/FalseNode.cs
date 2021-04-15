using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class FalseNode : BoolTerminalNode, IBoolNodeVisitable
    {
        public FalseNode(string value) : base(value,BoolType.FalseNode)
        {
        }

        public void Accept(IBoolNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}