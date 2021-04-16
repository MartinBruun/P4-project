using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MathIdNode : TerminalMathNode, IMathNodeVisitable
    {
        public IdNode AssignedValueId { get; set; }

        public MathIdNode(string value, IdNode assignedValueId) : base(value, MathType.IdValueNode)
        {
            this.AssignedValueId = assignedValueId;
        }

        public void Accept(IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

      
    }
}