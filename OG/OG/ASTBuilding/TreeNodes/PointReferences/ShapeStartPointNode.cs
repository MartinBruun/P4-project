using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class ShapeStartPointNode : ShapePointReference
    {
        public ShapeStartPointNode(string pointText, IdNode shapeName) : base(pointText,  shapeName, PointReferenceNodeType.ShapeStartPointNode)
        {
        }
        public ShapeStartPointNode(ShapeStartPointNode node) : base(node)
        {
            
        }
        
        public override void Accept(IPointReferenceNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}