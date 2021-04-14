namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class InfixMathNode : MathNode, IInfixMathNode
    {
        public MathNode RHS { get; set; } = null;
        public MathNode LHS { get; set; } = null;

        public InfixMathNode(MathNode rhs, MathNode lhs, MathType MathType):base(rhs.ToString(),MathType.GenericInfixNode)
        {
            LHS = lhs;
            RHS = rhs;
        }

    }

    public interface IInfixMathNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }

    }
}