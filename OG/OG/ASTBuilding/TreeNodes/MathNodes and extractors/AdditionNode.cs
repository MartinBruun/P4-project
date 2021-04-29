using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class AdditionNode : InfixMathNode
    {
        public AdditionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.AdditionNode)
        {
        }
        
 

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
        
        public override void Accept(CodeGeneration.IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}