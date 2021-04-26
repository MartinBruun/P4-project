using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
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

    public interface IMathComparerNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }
    }
}