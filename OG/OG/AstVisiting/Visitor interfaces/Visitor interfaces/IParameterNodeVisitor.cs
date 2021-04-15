using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IParameterNodeVisitor
    {
        public void Visit(FunctionCallParameterNode node);
        public void Visit(ParameterNode node);
    }
}