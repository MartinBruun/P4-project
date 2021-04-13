using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNodes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Draw
{
    public class DrawCommandNode : CommandNode
    {
        public IdNode Id;
        public PointReferenceNode From;

        public DrawCommandNode(IdNode id, PointReferenceNode from)
        {
            Id = id;
            From = from;
        }

        public DrawCommandNode(IdNode id)
        {
            Id = id;
            From = null;
        }
    }
}