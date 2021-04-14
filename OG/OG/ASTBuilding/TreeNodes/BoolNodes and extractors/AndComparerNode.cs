namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class AndComparerNode : BoolComparerNode
    {
        public AndComparerNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value,BoolType.AndNode)
        {
            
        }
    }
}