using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public abstract class AssignmentNode : StatementNode
    {
        public enum AssignmentType
        {
            PropertyAssignmentNode = 0,
            VariableAssignmentNode, 
            IdAssignment,
            FunctionCallAssignment
        }

        public AssignmentType AssignType { get; set; }
        public IdNode Id { get; set; }
        public AssignmentNode(IdNode id, AssignmentType assignmentType):base(StatementType.AssignmentNode)
        {
            this.AssignType = assignmentType;
            this.Id = id;
        }
    }
    
}