namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class AndNode : InfixBoolNode
    {
        public AndNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value)
        {
            
        }
    }
}