namespace OG.ASTBuilding.Terminals
{
    public class MultiplicationNode : InfixMathNode
    {
        public MultiplicationNode(MathNode rhs, MathNode lhs) : base(rhs, lhs)
        {
        }

    }
}