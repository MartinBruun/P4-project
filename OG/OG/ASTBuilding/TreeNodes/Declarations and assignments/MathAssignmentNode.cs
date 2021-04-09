using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class MathAssignmentNode : AssignmentNode
    {
        private MathNode AssignedValue { get; set; }

        public MathAssignmentNode(IdNode id, MathNode value) : base(id, AssignmentType.VariableAssignmentNode)
        {
            AssignedValue = value;
        }
    }
}