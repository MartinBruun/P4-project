using OG.ASTBuilding.TreeNodes.TerminalNodes;

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

        public DeclarationNode(IdNode id, ExpressionNode startAssignedExpression, DeclarationType type)
        {
            DeclaredType = type;
            Id = id;
            AssignedExpression = startAssignedExpression;
        }
    }

    public interface IDeclarationNode
    {
        public IIdNode Id { get; set; }
        public IExpressionNode AssignedExpression { get; set; }
    }
}