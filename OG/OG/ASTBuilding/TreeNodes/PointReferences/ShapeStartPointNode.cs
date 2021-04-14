using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class ShapeStartPointNode : ShapePointReference
    {
        public ShapeStartPointNode(string pointText, IdNode shapeName) : base(pointText,  shapeName, PointReferenceNodeType.ShapeStartPointNode)
        {
        }
    }
}