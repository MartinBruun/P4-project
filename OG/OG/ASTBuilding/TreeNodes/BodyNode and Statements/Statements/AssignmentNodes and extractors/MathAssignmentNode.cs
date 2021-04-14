using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
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