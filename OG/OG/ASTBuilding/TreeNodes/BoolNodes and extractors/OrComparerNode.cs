namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class OrComparerNode : BoolComparerNode
    {
        public OrComparerNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value, BoolType.OrNode)
        {
            
        }
    }
}