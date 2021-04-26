using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class TrueNode : BoolTerminalNode, IBoolNodeVisitable
    {
        public TrueNode(string value) : base(value, BoolType.TrueNode)
        {
        }

        public void Accept(IBoolNodeVisitor visitor)
        {
                visitor.Visit(this);
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}