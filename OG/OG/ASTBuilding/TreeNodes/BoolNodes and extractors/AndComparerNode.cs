using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class AndComparerNode : BoolComparerNode, IBoolNodeVisitable
    {
        public AndComparerNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value,BoolType.AndNode)
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