using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class AndComparerNode : BoolComparerNode
    {
        public AndComparerNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value,BoolType.AndNode)
        {
            
        }
        
        public AndComparerNode(AndComparerNode node) : base(node)
        {
            
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}