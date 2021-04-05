using System.Collections.Generic;
using OG.AST.Terminals;

namespace OG.AST.Shapes
{
    public class ShapeDeclarationNode : ASTNode
    {
        public IDNode ID { get; set; }
        public BodyNode body;

        public ShapeDeclarationNode(IDNode id)
        {
            ID = id;
        }
        public override string ToString()
        {
            return "ShapeDeclarationNode with ID: " + ID.ToString();
        }
    }

    public class BodyNode : ASTNode
    {
        public List<DeclarationNode> declarations = new List<DeclarationNode>();
        public List<AssignmentNode> AssignmentNodes = new List<AssignmentNode>();
        public List<CommandNodes> CommandNodes = new List<CommandNodes>();
    }
}