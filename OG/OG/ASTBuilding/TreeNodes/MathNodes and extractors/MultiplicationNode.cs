namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MultiplicationNode : InfixMathNode
    {
        public MultiplicationNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.MultiplicationNode)
        {
        }

    }
}