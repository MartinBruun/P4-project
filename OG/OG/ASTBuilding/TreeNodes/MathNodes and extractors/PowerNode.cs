namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class PowerNode : InfixMathNode
    {
        public PowerNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.PowerNode)
        {
        }
    }
}