using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class ShapePointRefNode : AstNode
    {
        public  IdNode ShapeNameId{ get; set; }

        public enum PointTypes
        {
            StartPoint,
            Endpoint
        }

        public PointTypes PointType
        {
            get;
            set;
        }


        public ShapePointRefNode(IdNode id, PointTypes p)
        {
            ShapeNameId = id;
            PointType = p;
        }

    }
}