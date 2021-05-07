using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class AdditionNode : InfixMathNode
    {
        public AdditionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.AdditionNode)
        {
        }
        
 

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
    
        }
        
        public override  NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}