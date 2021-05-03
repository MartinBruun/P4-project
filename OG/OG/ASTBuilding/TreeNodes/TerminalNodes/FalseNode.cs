using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class FalseNode : BoolTerminalNode
    {
        public FalseNode(string value) : base(value,BoolType.FalseNode)
        {
        }
        
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }

        public override string ToString()
        {
            return "FALSE";
        }
    }
}