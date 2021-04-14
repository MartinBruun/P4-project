using OG.ASTBuilding.Terminals;
using CoordinateXyValueNode = OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode;

namespace OG.ASTBuilding.Shapes
{
    public class PropertyAssignmentNode : AssignmentNode
    {
        public MathNode assignedValue { get; set; }
        public CoordinateXyValueNode coordinateValueNode { get; set; }

        public PropertyAssignmentNode(CoordinateXyValueNode xyValue, MathNode value) : base(xyValue.Id, AssignmentType.PropertyAssignmentNode)
        {
            assignedValue =  value;
            this.coordinateValueNode = xyValue;
        }
    }
}