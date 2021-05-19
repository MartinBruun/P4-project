using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class PointReferenceIdNode : PointReferenceNode
    {
        /// <summary>
        /// The value the variable is assigned to.
        /// </summary>
        public IdNode AssignedValue { get; set; }

        public PointReferenceIdNode(string pointText, IdNode assignedValue) : base(pointText, PointReferenceNodeType.PointIdNode)
        {
            AssignedValue = assignedValue;
        }
        public PointReferenceIdNode(PointReferenceIdNode node) : base(node)
        {
            AssignedValue = node.AssignedValue;
        }

        public override void Accept(IPointReferenceNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}