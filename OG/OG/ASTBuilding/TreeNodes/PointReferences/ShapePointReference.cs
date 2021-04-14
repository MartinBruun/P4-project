using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public abstract class ShapePointReference : PointReferenceNode
    {
        public ShapePointReference(string pointText, IdNode shapeName, PointReferenceNodeType type):base(pointText, type)
        {
            ShapeName = shapeName;
        }
        public IdNode ShapeName { get; set; }
    }
}