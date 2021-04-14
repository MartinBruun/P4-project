using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class ShapeEndPointNode : ShapePointReference
    {
        
        public ShapeEndPointNode(string pointText, IdNode shapeName) : base(pointText, shapeName, PointReferenceNodeType.ShapeEndPointNode)
        {
        }
    }
}