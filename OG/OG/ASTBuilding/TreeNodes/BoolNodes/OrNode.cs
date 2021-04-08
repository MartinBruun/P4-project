namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class OrNode : InfixBoolNode
    {
        public OrNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value)
        {
            
        }
    }
}