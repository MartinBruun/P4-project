using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IFunctionCallNodeVisitor : IMathFuncCallVisitor, IBoolFuncCallVisitor, IPointFuncCallVisitor, IMathFunctionCallAssigmentVisitor
    {
        public void Visit(UntilFunctionCallNode node);
        public void Visit(ParameterNode node);
        public void Visit(FunctionCallNode node);
    }
}