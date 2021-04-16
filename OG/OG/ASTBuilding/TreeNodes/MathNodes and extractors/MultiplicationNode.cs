using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MultiplicationNode : InfixMathNode, IMathNodeVisitable
    {
        public MultiplicationNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.MultiplicationNode)
        {
        }

        public void Accept(IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}