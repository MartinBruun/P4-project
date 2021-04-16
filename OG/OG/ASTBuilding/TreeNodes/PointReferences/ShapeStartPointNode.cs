using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class ShapeStartPointNode : ShapePointReference, IPointReferenceVisitable
    {
        public ShapeStartPointNode(string pointText, IdNode shapeName) : base(pointText,  shapeName, PointReferenceNodeType.ShapeStartPointNode)
        {
        }

        public void Accept(IPointReferenceNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}