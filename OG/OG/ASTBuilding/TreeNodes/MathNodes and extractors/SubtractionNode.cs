using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class SubtractionNode : InfixMathNode, IMathNodeVisitable
    {
        public SubtractionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs,MathType.SubtractionNode)
        {
            
        }

        public void Accept(IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}