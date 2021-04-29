using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class ShapeEndPointNode : ShapePointReference
    {
        
        public ShapeEndPointNode(string pointText, IdNode shapeName) : base(pointText, shapeName, PointReferenceNodeType.ShapeEndPointNode)
        {
        }
        
        public override void Accept(ILineCommandNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}