using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
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