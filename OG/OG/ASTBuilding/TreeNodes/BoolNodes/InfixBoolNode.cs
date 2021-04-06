namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class InfixBoolNode : BoolNode
    {
        public BoolNode RHS { get; set; }
        public BoolNode LHS { get; set; }
    }
}