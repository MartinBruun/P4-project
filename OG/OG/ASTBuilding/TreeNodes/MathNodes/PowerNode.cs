namespace OG.ASTBuilding.Terminals
{
    public class PowerNode : InfixMathNode
    {
        public PowerNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.PowerNode)
        {
        }
    }
}