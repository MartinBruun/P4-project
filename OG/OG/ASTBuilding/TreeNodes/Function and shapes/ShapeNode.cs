using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class ShapeNode : AstNode
    {
        public IdNode Id { get; set; }
        public BodyNode Body;

        public ShapeNode(IdNode id, BodyNode bodyNode)
        {
            Id = id;
            Body = bodyNode;
        }
        public override string ToString()
        {
            return "ShapeDeclarationNode with ID: " + Id;
        }
    }
}