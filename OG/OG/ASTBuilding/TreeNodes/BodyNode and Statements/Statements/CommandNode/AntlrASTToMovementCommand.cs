using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
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