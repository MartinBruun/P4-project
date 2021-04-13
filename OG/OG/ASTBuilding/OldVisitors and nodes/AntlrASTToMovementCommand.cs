using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.MathExpression;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Visitors
{
    public class AntlrASTToMovementCommand : OGBaseVisitor<MovementCommandNode>
    {
        public override MovementCommandNode VisitMovementCommand(OGParser.MovementCommandContext context)
        {
            if (context.curveCmd != null && !context.curveCmd.IsEmpty)
            {
                return VisitCurveCommand(context.curveCmd);
            } else if (context.lineCmd != null && !context.lineCmd.IsEmpty)
            {
                return VisitLineCommand(context.lineCmd);
            }

            throw new AstNodeCreationException("Movement command context did not contain curve or line");
        }

        public override MovementCommandNode VisitLineCommand(OGParser.LineCommandContext context)
        {
            PointReferenceNode from = new FromCommandNodeExtractor().ExtractFromCommandNode(context.fromCmd);
            List<PointReferenceNode> to = new ToCommandsListBuilder().BuildToCommandNodes(context.toCmds);

            return new LineCommandNode(from, to);
        }

        public override MovementCommandNode VisitCurveCommand(OGParser.CurveCommandContext context)
        {
            PointReferenceNode from = new FromCommandNodeExtractor().ExtractFromCommandNode(context.fromCmd);
            List<PointReferenceNode> to = new ToCommandsListBuilder().BuildToCommandNodes(context.toCmds);
            MathNode angle = new MathNodeExtractor().ExtractMathNode(context.angle);

            return new CurveCommandNode(from, to, angle);
        }
    }
}