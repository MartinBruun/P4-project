using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class TrueNode : BoolTerminalNode
    {
        public TrueNode(string value) : base(value, BoolType.TrueNode)
        {
        }
        
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}