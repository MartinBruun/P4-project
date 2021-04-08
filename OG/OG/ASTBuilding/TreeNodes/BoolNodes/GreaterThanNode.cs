namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class GreaterThanNode : InfixBoolNode
    {
        public GreaterThanNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value)
        {
            
        }
    }
}