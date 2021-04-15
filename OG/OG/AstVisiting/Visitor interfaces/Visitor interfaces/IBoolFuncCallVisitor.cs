using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IBoolFuncCallVisitor
    {  
        public void Visit(BoolFunctionCallNode node);
     
    }
}