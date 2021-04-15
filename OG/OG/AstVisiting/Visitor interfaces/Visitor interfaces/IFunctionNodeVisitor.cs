using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IFunctionNodeVisitor : IBodyNodeVisitor, IBoolFuncCallVisitor, IMathFuncCallVisitor, IPointFuncCallVisitor
    {
        public void Visit(IFunctionNode node);
        public void Visit(FunctionNode node);
    }
}