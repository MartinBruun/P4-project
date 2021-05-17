using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class PowerNode : InfixMathNode
    {
        public PowerNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.PowerNode)
        {
        }

        public PowerNode(PowerNode node) : base(node)
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