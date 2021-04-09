using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class PointDeclarationNode : DeclarationNode
    {
        public PointDeclarationNode(IdNode id, PointReferenceNode pointRef):base(id, pointRef, DeclarationType.PointDeclarationNode)
        {
            
        }
    }
}