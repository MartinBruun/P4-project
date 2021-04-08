using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class PropertyAssignmentNode : AssignmentNode
    {
        public MathNode assignedValue { get; set; }

        public PropertyAssignmentNode(IDNode id, MathNode value) : base(id)
        {
            assignedValue = value;
        }
    }
}