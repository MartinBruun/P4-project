using OG.AST;
using OG.AST.Terminals;

namespace OG.AST.Draw
{
    public class ShapeNode
    {
        public IDNode ID { get; set; }

        public ShapeNode(IDNode id)
        {
            ID = id;
        }
    }
}