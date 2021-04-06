using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class BoolDeclarationNode : DeclarationNode
    {
        public BoolDeclarationNode(IDNode id, BoolNode assignmentValue):base(id, assignmentValue)
        {
            Id = id;
            Value = assignmentValue;
        }
    }
}