using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Shapes
{
    public class BoolAssignmentNode : AssignmentNode
    {
        public BoolNode AssignedValue { get; set; }

        public BoolAssignmentNode(IdNode id, BoolNode value) : base(id, AssignmentType.VariableAssignmentNode)
        {
            AssignedValue = value;
        }
    }
}