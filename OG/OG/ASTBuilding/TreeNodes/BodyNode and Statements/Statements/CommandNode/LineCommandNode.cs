using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.AstVisiting;
using OG.CodeGeneration;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class LineCommandNode : MovementCommandNode
    {
        public LineCommandNode(PointReferenceNode fromPosition, List<PointReferenceNode> toPosition): base(fromPosition, toPosition, MovementType.Line)
        {
        }


        public void Accept(ILineCommandNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }

  
}