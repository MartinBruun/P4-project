namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class DivisionNode : InfixMathNode
    {
        public DivisionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.DivisionNode)
        {
        }

    }
}