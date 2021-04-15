using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IFunctionCallNodeVisitor : INativeFunctionCallsVisitor, IUntilFunctionCallVisitor
    {
        public void Visit(FunctionCallNode node);
    }

    public interface INativeFunctionCallsVisitor: IMathFuncCallVisitor, IBoolFuncCallVisitor, IPointFuncCallVisitor, IParameterNodeVisitor
    {
    }
}