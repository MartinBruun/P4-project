namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class LessThanNode : InfixBoolNode
    {
        public LessThanNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value)
        {
            
        }
    }
}