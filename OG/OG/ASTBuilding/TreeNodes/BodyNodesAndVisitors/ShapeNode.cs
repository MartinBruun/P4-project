using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class ShapeNode : AstNode
    {
        public IdNode ID { get; set; }
        public BodyNode body;

        public ShapeNode(IdNode id, BodyNode bodynode)
        {
            ID = id;
            body = bodynode;
        }
        public override string ToString()
        {
            return "ShapeDeclarationNode with ID: " + ID.ToString();
        }
    }
}