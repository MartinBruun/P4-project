using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.AstVisiting
{
    public interface IPointFuncCallVisitor
    {   
        public void Visit(PointFunctionCallNode node);
    }
}