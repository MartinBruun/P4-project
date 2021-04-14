using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class LessThanComparerNode : MathComparerNode
    {
        public LessThanComparerNode(MathNode LHS, MathNode RHS, string value)
            : base(RHS, LHS, value, BoolType.LessThanNode)
        {
            
        }
    }
}