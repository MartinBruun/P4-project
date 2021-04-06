namespace OG.ASTBuilding.Terminals
{
    public abstract class InfixMathNode : MathNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }
    }
}