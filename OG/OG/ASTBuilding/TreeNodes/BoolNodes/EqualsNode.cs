namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class EqualsNode : InfixBoolNode
    {
        public EqualsNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value)
        {
            
        }
    }
}