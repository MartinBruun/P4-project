using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class BoolComparerNode : BoolNode
    {
        public BoolNode RHS { get; set; }
        public BoolNode LHS { get; set; }

        public BoolComparerNode(BoolNode RHS, BoolNode LHS, string value, BoolType type ):base(value, type)
        {
            this.LHS = LHS;
            this.RHS = RHS;
        }
    }
    
    public abstract class MathComparerNode : BoolNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }
        protected MathComparerNode(MathNode lhs, MathNode rhs,string value, BoolType type) : base(value, type)
        {
            RHS = rhs;
            LHS = lhs;
        }
    }
}