using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IParameterFunctionCall
    {
        public void Visit(FunctionCallParameterNode node);
    }
}