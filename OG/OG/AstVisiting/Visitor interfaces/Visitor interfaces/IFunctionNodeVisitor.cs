using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IFunctionNodeVisitor : IBodyNodeVisitor
    {
        public void Visit(IFunctionNode node);
        public void Visit(FunctionNode node);
    }
}