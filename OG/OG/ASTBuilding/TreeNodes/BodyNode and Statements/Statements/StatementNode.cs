using OG.AstVisiting;
using OG.AstVisiting.Visitors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements
{
    public abstract class StatementNode :AstNode, IAstNode//, IStatementNodeVisitable
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
    }

    // public interface IStatementNodeVisitable : IAstNode
    // {
    //     public void Accept(IStatementVisitorBundle visitorBundle);
    // }
}