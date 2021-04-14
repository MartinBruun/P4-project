using OG.ASTBuilding.TreeNodes.TerminalNodes;

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
    }
}