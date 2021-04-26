using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IFunctionNodeVisitorBundle
    {
        public void Visit(FunctionNode node);
    }
}