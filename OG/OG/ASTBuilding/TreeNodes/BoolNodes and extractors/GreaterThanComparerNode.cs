using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class GreaterThanComparerNode : MathComparerNode
    {
        public GreaterThanComparerNode(MathNode LHS, MathNode RHS, string value )
            :base(RHS,LHS,value, BoolType.GreaterThanNode)
        {
            
        }
    }
}