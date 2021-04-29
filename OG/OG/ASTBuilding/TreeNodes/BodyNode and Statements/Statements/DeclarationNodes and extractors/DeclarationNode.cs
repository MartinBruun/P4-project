using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public abstract class DeclarationNode : StatementNode
    {
        public enum DeclarationType
        {
          NumberDeclarationNode = 0,
          BoolDeclarationNode,
          PointDeclarationNode
        }
        public IdNode Id { get; set; }
        public ExpressionNode AssignedExpression { get; set; }
        public DeclarationType DeclaredType { get; set; }

        public DeclarationNode(IdNode id, ExpressionNode startAssignedExpression, DeclarationType type) :base(StatementType.DeclarationNode)
        {
            DeclaredType = type;
            Id = id;
            AssignedExpression = startAssignedExpression;
        }
    }

   
}