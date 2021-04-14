using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MathIdNode : TerminalMathNode
    {
        public IdNode AssignedValueId { get; set; }

        public MathIdNode(string value, IdNode assignedValueId) : base(value, MathType.IdValueNode)
        {
            this.AssignedValueId = assignedValueId;
        }
    }
}