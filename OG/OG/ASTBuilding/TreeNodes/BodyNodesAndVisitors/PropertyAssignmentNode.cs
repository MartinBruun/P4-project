using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class PropertyAssignmentNode : AssignmentNode
    {
        public MathNode assignedValue { get; set; }

        public PropertyAssignmentNode(IdNode id, MathNode value) : base(id, AssignmentType.PropertyAssignmentNode)
        {
            assignedValue = value;
        }
    }
}