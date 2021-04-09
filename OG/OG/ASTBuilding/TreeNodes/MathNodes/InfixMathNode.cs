namespace OG.ASTBuilding.Terminals
{
    public abstract class InfixMathNode : MathNode
    {
        public MathNode RHS { get; set; } = null;
        public MathNode LHS { get; set; } = null;

        public InfixMathNode(MathNode rhs, MathNode lhs, MathType MathType):base(rhs.ToString(),MathType.GenericInfixNode)
        {
            LHS = lhs;
            RHS = rhs;
        }

    }
}