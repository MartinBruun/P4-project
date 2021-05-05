using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class DivisionNode : InfixMathNode
    {
        

        public DivisionNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.DivisionNode)
        {
        }


        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
        
        public override  NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}