namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public interface IBoolComparerNode
    {
        BoolNode RHS { get; set; }
        BoolNode LHS { get; set; }
    }

    public abstract class BoolComparerNode : BoolNode, IBoolComparerNode
    {
        public BoolNode RHS { get; set; }
        public BoolNode LHS { get; set; }

        public BoolComparerNode(BoolNode RHS, BoolNode LHS, string value, BoolType type ):base(value, type)
        {
            this.LHS = LHS;
            this.RHS = RHS;
        }
    }
}