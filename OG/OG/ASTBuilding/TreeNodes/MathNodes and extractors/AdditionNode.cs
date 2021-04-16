using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class AdditionNode : InfixMathNode, IMathNodeVisitable
    {
        public AdditionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.AdditionNode)
        {
        }
        
        public void Accept(IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}