using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class GreaterThanComparerNode : MathComparerNode
    {
        public GreaterThanComparerNode(MathNode LHS, MathNode RHS, string value )
            :base(RHS,LHS,value, BoolType.GreaterThanNode)
        {
            
        }
        public GreaterThanComparerNode(GreaterThanComparerNode node) : base(node)
        {
            
        }
    }
}