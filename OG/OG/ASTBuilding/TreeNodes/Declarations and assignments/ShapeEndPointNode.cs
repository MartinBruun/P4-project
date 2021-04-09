using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class ShapeEndPointNode : ShapePointReference
    {
        
        public ShapeEndPointNode(string pointText, IdNode shapeName) : base(pointText, shapeName, PointReferenceNodeType.ShapeEndPointNode)
        {
        }
    }
}