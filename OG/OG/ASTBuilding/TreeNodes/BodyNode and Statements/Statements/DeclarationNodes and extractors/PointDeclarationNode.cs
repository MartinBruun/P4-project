using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class PointDeclarationNode : DeclarationNode
    {
        public PointDeclarationNode(IdNode id, ExpressionNode pointRef):base(id, pointRef, DeclarationType.PointDeclarationNode)
        {
            
        }
        public PointDeclarationNode(PointDeclarationNode node) : base(node)
        {
            
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}