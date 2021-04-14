using OG.ASTBuilding.Terminals;

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
    }
}