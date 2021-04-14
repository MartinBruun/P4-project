using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.ASTBuilding.TreeNodes
{
    public class DrawNode : AstNode
    {
        public List<DrawCommandNode> drawCommands;

        public DrawNode(List<DrawCommandNode> drawCommands)
        {
            this.drawCommands = drawCommands;
        }

        public DrawNode()
        {
            drawCommands = new List<DrawCommandNode>();
        }
    }
}