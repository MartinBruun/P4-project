namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class InfixMathNode : MathNode, IInfixMathNode
    {

        public InfixMathNode(MathNode rhs, MathNode lhs, MathType mathType):base(rhs.ToString(),mathType)
        {
            LHS = lhs;
            RHS = rhs;
        }
        
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }
    }

    public interface IInfixMathNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }

    }
}