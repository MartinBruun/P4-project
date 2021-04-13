using System.Collections.Generic;
using Antlr4.Runtime.Misc;
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
            return base.VisitMovementCommand(context);
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