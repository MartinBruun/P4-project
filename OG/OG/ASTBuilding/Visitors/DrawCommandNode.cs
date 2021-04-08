using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Draw
{
    public class DrawCommandNode : AstNode
    {
        public IDNode id;
        public FromCommandNode from;

        public DrawCommandNode(IDNode id, FromCommandNode from)
        {
            this.id = id;
            this.from = from;
        }

        public DrawCommandNode(IDNode id)
        {
            this.id = id;
            from = null;
        }
    }
}