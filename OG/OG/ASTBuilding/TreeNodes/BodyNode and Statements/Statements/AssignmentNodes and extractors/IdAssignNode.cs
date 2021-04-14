using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class IdAssignNode : AssignmentNode
    {
        public IdNode AssignedValue { get; set; }

        public IdAssignNode(IdNode id, IdNode value) : base(id, AssignmentType.IdAssignment)
        {
            AssignedValue = value;
        }
    }
}