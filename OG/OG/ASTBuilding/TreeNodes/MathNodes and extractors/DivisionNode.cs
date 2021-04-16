using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class DivisionNode : InfixMathNode, IMathNodeVisitable
    {
        

        public DivisionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.DivisionNode)
        {
        }

        public void Accept(IMathNodeVisitor visitor)
        {
             visitor.Visit(this);   
        }
    }
}