namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class InfixBoolNode : BoolNode
    {
        public BoolNode RHS { get; set; }
        public BoolNode LHS { get; set; }

        public InfixBoolNode(BoolNode RHS, BoolNode LHS, string value ):base(value)
        {
            this.LHS = LHS;
            this.RHS = RHS;
        }
    }
}