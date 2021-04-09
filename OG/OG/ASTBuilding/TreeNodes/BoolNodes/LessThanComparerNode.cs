using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class LessThanComparerNode : MathComparerNode
    {
        public LessThanComparerNode(MathNode LHS, MathNode RHS, string value)
            : base(RHS, LHS, value, BoolType.LessThanNode)
        {
            
        }
    }
}