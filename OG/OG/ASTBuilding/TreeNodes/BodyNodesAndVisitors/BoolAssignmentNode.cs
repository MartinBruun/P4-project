using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Shapes
{
    public class BoolAssignmentNode : AssignmentNode
    {
        public BoolNode AssignedValue { get; set; }

        public BoolAssignmentNode(IDNode id, BoolNode value) : base(id)
        {
            AssignedValue = value;
        }
    }
}