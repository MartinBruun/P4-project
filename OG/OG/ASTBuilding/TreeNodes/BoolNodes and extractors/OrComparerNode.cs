using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class OrComparerNode : BoolComparerNode, IBoolNodeVisitable
    {
        public OrComparerNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value, BoolType.OrNode)
        {
            
        }

        public void Accept(IBoolNodeVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}