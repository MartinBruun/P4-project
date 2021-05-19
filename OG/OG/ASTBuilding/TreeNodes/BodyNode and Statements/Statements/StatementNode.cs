using OG.AstVisiting;
using OG.AstVisiting.Visitors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements
{
    public abstract class StatementNode :AstNode, IAstNode
    {
        public enum StatementType
        {
            AssignmentNode,
            DeclarationNode,
            CommandNode
        }

        public StatementType Type;

        public StatementNode(StatementType type)
        {
            Type = type;
        }
        public StatementNode(StatementNode node) : base(node)
        {
            Type = node.Type;
        }
    }

    // public interface IStatementNodeVisitable : IAstNode
    // {
    //     public void Accept(IStatementVisitorBundle visitorBundle);
    // }
}