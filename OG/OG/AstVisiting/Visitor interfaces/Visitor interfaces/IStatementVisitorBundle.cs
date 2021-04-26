using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;

namespace OG.AstVisiting
{
    public interface IStatementVisitorBundle : IDeclarationVisitor, ICommandNodeVisitorBundle, IAssignmentVisitorBundle
    {
        // public void Visit(IStatementNodeBundleVisitable node);
    }
}