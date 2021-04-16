using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IFunctionCallNodeVisitorBundleBundle : INativeFunctionCallsVisitorBundle, IUntilFunctionCallVisitor
    {
        public void Visit(FunctionCallNode node);
    }

    public interface INativeFunctionCallsVisitorBundle: IMathFuncCallVisitor, IBoolFuncCallVisitor, IPointFuncCallVisitor, IParameterNodeVisitor
    {
    }
}