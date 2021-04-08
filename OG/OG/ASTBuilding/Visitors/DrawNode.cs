﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OG.ASTBuilding.Draw
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