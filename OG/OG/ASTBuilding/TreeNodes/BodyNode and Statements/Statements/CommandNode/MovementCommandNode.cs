using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.AstVisiting;
using OG.CodeGeneration;
using OG.Compiler;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public abstract class MovementCommandNode : CommandNode
    {
        public enum MovementType
        {
            Line,
            Curve
        }
        public PointReferenceNode From { get; set; }
        public List<PointReferenceNode> To { get; set; }

        public MovementType TypeOfMovement { get; }

        public MovementCommandNode(PointReferenceNode from, List<PointReferenceNode> toNodes, MovementType type) : base(
            CommandType.MovementNode)
        {
            From = from;
            To = toNodes;
            TypeOfMovement = type;
        }


    }


}