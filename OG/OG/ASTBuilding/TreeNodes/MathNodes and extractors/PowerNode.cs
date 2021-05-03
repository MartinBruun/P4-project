using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class PowerNode : InfixMathNode
    {
        public PowerNode(MathNode rhs, MathNode lhs) : base(rhs, lhs, MathType.PowerNode)
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