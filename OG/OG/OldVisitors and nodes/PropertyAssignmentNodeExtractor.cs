using System;
using Antlr4.Runtime.Atn;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using CoordinateXyValueNode = OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode;

namespace OG.ASTBuilding.Visitors
{
    public class PropertyAssignmentNodeExtractor : OGBaseVisitor<AssignmentNode>
    {
        
        public PropertyAssignmentNode VisitPropertyAssignmentNode(OGParser.PropertyAssignmentContext context)
        {
            
            CoordinateXyValueNode xyValue = new CoordinateXyValueNode(new IdNode(context.xyVal.id.Text), context.xyVal.xy.Text);
            MathNode value = new MathNodeExtractor().ExtractMathNode(context.mathExpression());
            return new PropertyAssignmentNode(xyValue, value);
        }
    }
}