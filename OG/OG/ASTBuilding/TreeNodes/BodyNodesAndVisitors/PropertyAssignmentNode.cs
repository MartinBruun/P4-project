using OG.ASTBuilding.Terminals;
using CoordinateXYValueNode = OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXYValueNode;

namespace OG.ASTBuilding.Shapes
{
    public class PropertyAssignmentNode : AssignmentNode
    {
        public MathNode assignedValue { get; set; }
        public CoordinateXYValueNode coordinateValueNode { get; set; }

        public PropertyAssignmentNode(CoordinateXYValueNode xyValue, MathNode value) : base(xyValue.id, AssignmentType.PropertyAssignmentNode)
        {
            assignedValue =  value;
            this.coordinateValueNode = xyValue;
        }
    }
}