using System;
using System.Linq.Expressions;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.ASTBuilding.Shapes
{
    public class AssignmentNode : StatementNode
    {
        public enum AssignmentType
        {
            PropertyAssignmentNode = 0,
            VariableAssignmentNode, 
            IdAssignment,
            FunctionCallAssignment
        }

        public AssignmentType AssignType { get; set; }
        public IDNode Id { get; set; }
        public AssignmentNode(IDNode id, AssignmentType assignmentType)
        {
            this.AssignType = assignmentType;
        }
    }
}