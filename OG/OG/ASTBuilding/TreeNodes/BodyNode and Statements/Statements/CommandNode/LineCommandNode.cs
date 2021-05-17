﻿using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.AstVisiting;
using OG.CodeGeneration;
using OG.Compiler;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class LineCommandNode : MovementCommandNode
    {
        public LineCommandNode(PointReferenceNode fromPosition, List<PointReferenceNode> toPosition): base(fromPosition, toPosition, MovementType.Line)
        {
        }
        
        public LineCommandNode(LineCommandNode node) : base(node)
        {
            
        }
        
        public void Accept(ILineCommandNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}