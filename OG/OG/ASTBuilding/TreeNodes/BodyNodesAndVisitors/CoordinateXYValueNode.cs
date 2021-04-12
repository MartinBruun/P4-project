using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class CoordinateXYValueNode : AstNode
    {
        public IdNode id { get; set; }
        public string property { get; set; }

        public enum xyProperty
        {
            xProperty = 0,
            yProperty,
        }

        public CoordinateXYValueNode(IdNode ID, string xyProperty)
        {
            this.id = ID;
            this.property = xyProperty;

        }
    }
}