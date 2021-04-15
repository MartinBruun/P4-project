using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IParameterNodeVisitor : IParameterFunctionCall, IMathNodeVisitor, IBoolNodeVisitor, IPointReferenceNodeVisitor
    {

        public void Visit(ParameterNode node);
    }

    public interface IParameterFunctionCall
    {
        public void Visit(FunctionCallParameterNode node);
    }
}