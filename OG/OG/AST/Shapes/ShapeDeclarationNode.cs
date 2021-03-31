using OG.AST.Terminals;

namespace OG.AST.Shapes
{
    public class ShapeDeclarationNode
    {
        public IDNode ID { get; set; }

        public ShapeDeclarationNode(IDNode id)
        {
            ID = id;
        }
    }
}