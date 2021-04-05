namespace OG.AST.Terminals
{
    public abstract class InfixMathNode : ASTNode
    {
        public AstMathNode RHS { get; set; }
        public AstMathNode LHS { get; set; }
    }

    public class AstMathNode : InfixMathNode
    {
    }
}