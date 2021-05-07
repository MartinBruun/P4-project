using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class CoordinateXyValueNode : AstNode
    {
        public IdNode Id { get; set; }
        public string Property { get; set; }

        public enum XyProperty
        {
            XProperty = 0,
            YProperty,
        }

        public CoordinateXyValueNode(IdNode id, string xyProperty)
        {
            Id = id;
            Property = xyProperty;

        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
   
        }
    }
}