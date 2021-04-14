using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class EqualsComparerNode : MathComparerNode
    {
        public EqualsComparerNode(MathNode LHS, MathNode RHS, string value )
            :base(RHS,LHS,value, BoolType.EqualsNode)
        {
            
        }
    }
}