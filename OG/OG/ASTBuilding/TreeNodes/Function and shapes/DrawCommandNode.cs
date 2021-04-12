using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Draw
{
    public class DrawCommandNode : AstNode
    {
        public IdNode id;
        public PointReferenceNode from;

        public DrawCommandNode(IdNode id, PointReferenceNode from)
        {
            this.id = id;
            this.from = from;
        }

        public DrawCommandNode(IdNode id)
        {
            this.id = id;
            from = null;
        }
    }
}