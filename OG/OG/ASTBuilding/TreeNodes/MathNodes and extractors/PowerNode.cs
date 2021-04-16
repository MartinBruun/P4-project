using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class PowerNode : InfixMathNode, IMathNodeVisitable
    {
        public PowerNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.PowerNode)
        {
        }

        public void Accept(IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}