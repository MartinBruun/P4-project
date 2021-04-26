using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IMathFuncCallVisitor
    { 
        public void Visit(MathFunctionCallNode node);
      
    }
}