using OG.AST;
using OG.AST.Terminals;

namespace OG.AST.Draw
{
    public class ShapeNode : ASTNode
    {
        public IDNode ID { get; set; }

        public ShapeNode(IDNode id)
        {
            ID = id;
        }

        public override string ToString()
        {
            return "ShapeNode with ID: " + ID.ToString();
        }
    }
}