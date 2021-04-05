using System;
using System.Collections.Generic;

namespace OG.AST.Shapes
{
    public class BodyNode : ASTNode
    {
        public List<DeclarationNode> declarations = new List<DeclarationNode>();
        public List<AssignmentNode> AssignmentNodes = new List<AssignmentNode>();
        public List<CommandNode> CommandNodes = new List<CommandNode>();

        /// <summary>
        /// TODO Create declarations, assignmentnodes and commandNodes from the bodyContezxt
        /// </summary>
        /// <param name="context"></param>
        public BodyNode(OGParser.BodyContext context)
        {
            throw new NotImplementedException();

        }
    }
}