using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MultiplicationNode : InfixMathNode
    {
        public MultiplicationNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.MultiplicationNode)
        {
        }

        public MultiplicationNode(MultiplicationNode node) : base(node)
        {
            
        }

    
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
    
        }
        
        public override NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}