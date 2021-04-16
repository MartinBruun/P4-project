using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.AstVisiting
{
    public interface IUntilNodeVisitorBundleBundle : IFunctionCallNodeVisitorBundleBundle
    {
        public void Visit(UntilNode node);
    }


}
