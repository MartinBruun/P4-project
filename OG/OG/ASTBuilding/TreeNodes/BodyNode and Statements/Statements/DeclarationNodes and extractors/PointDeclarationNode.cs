using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class PointDeclarationNode : DeclarationNode
    {
        public PointDeclarationNode(IdNode id, PointReferenceNode pointRef):base(id, pointRef, DeclarationType.PointDeclarationNode)
        {
            
        }
    }
}