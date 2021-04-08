using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class BoolDeclarationNode : DeclarationNode
    {
        public BoolDeclarationNode(IdNode id, BoolNode assignmentAssignedValue):base(id, assignmentAssignedValue, DeclarationType.BoolDeclarationNode)
        {
            Id = id;
            AssignedValue = assignmentAssignedValue;
        }
    }
}