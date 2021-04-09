using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Draw
{
    public class DrawCommandNode : AstNode
    {
        public IdNode id;
        public FromCommandNode from;

        public DrawCommandNode(IdNode id, FromCommandNode from)
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