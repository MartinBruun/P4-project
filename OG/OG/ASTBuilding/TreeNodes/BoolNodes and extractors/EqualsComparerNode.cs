using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class EqualsComparerNode : MathComparerNode, IBoolNodeVisitable
    {
        public EqualsComparerNode(MathNode LHS, MathNode RHS, string value )
            :base(RHS,LHS,value, BoolType.EqualsNode)
        {
            
        }

        public void Accept(IBoolNodeVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}