using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    public class ShapeNode : AstNode, IShapeNodeVisitable
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

      
        public void Accept(IShapeNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}