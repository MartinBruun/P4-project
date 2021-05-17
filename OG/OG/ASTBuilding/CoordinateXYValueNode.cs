using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;
using IMathNodeVisitor = OG.CodeGeneration.IMathNodeVisitor;

namespace OG.ASTBuilding.Terminals
{
    public class CoordinateXyValueNode : TerminalMathNode
    {
        public CoordinateXyValueNode(string value, MathType mathNodeTypeOf) : base(value, mathNodeTypeOf)
        {
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
   
        }

        public override NumberNode Accept(IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}