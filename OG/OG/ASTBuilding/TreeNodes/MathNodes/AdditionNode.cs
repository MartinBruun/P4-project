namespace OG.ASTBuilding.Terminals
{
    public class AdditionNode : InfixMathNode
    {
        public AdditionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs)
        {
        }
        
    }
}