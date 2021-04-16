using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IParameterNodeVisitor : IParameterFunctionCall, IMathNodeVisitor, IBoolNodeVisitor, IPointReferenceNodeVisitor, IIdNodeVisitor
    {
        public void Visit(ParameterNode node);
    }
}