using System;
using Antlr4.Runtime.Atn;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using CoordinateXYValueNode = OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXYValueNode;

namespace OG.ASTBuilding.Visitors
{
    public class PropertyAssignmentNodeExtractor : OGBaseVisitor<AssignmentNode>
    {
        public PropertyAssignmentNode VisitPropertyAssignmentNode(OGParser.PropertyAssignmentContext context)
        {
            CoordinateXYValueNode xyValue = new CoordinateXYValueNode(new IdNode(context.xyVal.id.Text), context.xyVal.xy.Text);
            MathNode value = new MathNode(context.value.GetText(), MathNode.MathType.CoordinateXyValueNode);
            
            return new PropertyAssignmentNode(xyValue, value);
        }
    }
}