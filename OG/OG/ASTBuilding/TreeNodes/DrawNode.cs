using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.AstVisiting;

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

    
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}