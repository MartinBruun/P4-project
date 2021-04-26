using OG.AstVisiting;
using OG.AstVisiting.Visitors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements
{
    public abstract class StatementNode :AstNode, IAstNode//, IStatementNodeVisitable
    {
    }

    // public interface IStatementNodeVisitable : IAstNode
    // {
    //     public void Accept(IStatementVisitorBundle visitorBundle);
    // }
}