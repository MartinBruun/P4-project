using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.AstVisiting;
using OG.CodeGeneration;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class CurveCommandNode : MovementCommandNode
    {
        public MathNode Angle;

        public CurveCommandNode(PointReferenceNode fromPosition, List<PointReferenceNode> toPosition, MathNode angleExpression)
            :base(fromPosition, toPosition, MovementType.Curve)
        {
            Angle = angleExpression;
        }

      
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }

       
    }

    
}