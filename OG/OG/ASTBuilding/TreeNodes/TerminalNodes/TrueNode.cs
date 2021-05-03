using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class TrueNode : BoolTerminalNode
    {
        public TrueNode(string value) : base(value, BoolType.TrueNode)
        {
        }
        
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}