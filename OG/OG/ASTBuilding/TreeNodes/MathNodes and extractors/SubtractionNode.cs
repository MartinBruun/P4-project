namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class SubtractionNode : InfixMathNode
    {
        public SubtractionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs,MathType.SubtractionNode)
        {
            
        }
    }
}