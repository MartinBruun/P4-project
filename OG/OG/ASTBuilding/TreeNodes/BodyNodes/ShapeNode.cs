﻿using OG.AST.Terminals;

namespace OG.AST.Shapes
{
    public class ShapeNode : ASTNode
    {
        public IDNode ID { get; set; }
        public BodyNode body;

        public ShapeNode(IDNode id, BodyNode bodynode)
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