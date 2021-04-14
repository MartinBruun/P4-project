using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class BoolDeclarationNode : DeclarationNode
    {
        public BoolDeclarationNode(IdNode id, BoolNode assignmentAssignedExpression):base(id, assignmentAssignedExpression, DeclarationType.BoolDeclarationNode)
        {
            Id = id;
            AssignedExpression = assignmentAssignedExpression;
        }
    }
}