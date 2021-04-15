using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;

namespace OG.AstVisiting
{
    public interface IStatementVisitor : IDeclarationVisitor, ICommandNodeVisitor
    {
        public void Visit(IStatementNodeVisitable node);
    }
}