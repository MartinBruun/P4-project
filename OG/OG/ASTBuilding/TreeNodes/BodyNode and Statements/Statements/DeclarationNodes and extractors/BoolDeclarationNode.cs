using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class BoolDeclarationNode : DeclarationNode
    {
        public BoolDeclarationNode(IdNode id, ExpressionNode assignmentAssignedExpression):base(id, assignmentAssignedExpression, DeclarationType.BoolDeclarationNode)
        {

        }
        public BoolDeclarationNode(BoolDeclarationNode node) : base(node)
        {
            
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}