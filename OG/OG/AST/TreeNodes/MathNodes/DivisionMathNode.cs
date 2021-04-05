namespace OG.AST.Terminals
{
    public class DivisionMathNode : InfixMathNode
    {
        public AstMathNode RHS { get; set; }
        public AstMathNode LHS { get; set; }
    }
}