using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.AstVisiting
{
    public interface IPointReferenceNodeVisitor: IIdNodeVisitor, IPointFuncCallVisitor
    {
        public void Visit(PointReferenceIdNode node);
        public void Visit(ShapeEndPointNode node);
        public void Visit(ShapeStartPointNode node);
        public void Visit(TuplePointNode node);
    }
}