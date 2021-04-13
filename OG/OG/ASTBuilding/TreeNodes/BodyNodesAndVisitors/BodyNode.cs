using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    public class BodyNode : AstNode
    {
        // TODO: Should be one List<Statement> instead, so the order is preserved.
        public List<DeclarationNode> DeclarationNodes = new List<DeclarationNode>();
        public List<AssignmentNode> AssignmentNodes = new List<AssignmentNode>();
        public List<CommandNode> CommandNodes = new List<CommandNode>();


        public BodyNode(List<DeclarationNode> dcls, List<AssignmentNode> assignments, List<CommandNode> commands)
        {
            CommandNodes = commands;
            DeclarationNodes = dcls;
            AssignmentNodes = assignments;
        }
    }
}