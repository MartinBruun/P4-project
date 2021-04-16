using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements
{
    public  class StatementNode : AstNode, IStatementNodeVisitable
    {
        public void Accept(IStatementVisitorBundle visitorBundle)
        {
            visitorBundle.Visit( this);
        }
    }

    public interface IStatementNodeVisitable : IAstNode
    {
        public void Accept(IStatementVisitorBundle visitorBundle);
    }
}