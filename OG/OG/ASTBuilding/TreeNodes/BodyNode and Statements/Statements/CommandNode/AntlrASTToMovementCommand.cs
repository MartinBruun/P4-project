using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class AntlrASTToMovementCommand : AstBuilderErrorInheritor<MovementCommandNode>
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
            
            SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,"Movement command context did not contain curve or line")
            {
                IsFatal = true
            });
            return null;

        }

        public override MovementCommandNode VisitLineCommand(OGParser.LineCommandContext context)
        {
            PointReferenceNode from = new FromCommandNodeExtractor(SemanticErrors).ExtractFromCommandNode(context.fromCmd);
            List<PointReferenceNode> to = new ToCommandsListBuilder(SemanticErrors).BuildToCommandNodes(context.toCmds);
            LineCommandNode p = new LineCommandNode(from, to) 
                {Line = context.type.Line, Column = context.type.Column};
            return p;
        }

        public override MovementCommandNode VisitCurveCommand(OGParser.CurveCommandContext context)
        {
            PointReferenceNode from = new FromCommandNodeExtractor(SemanticErrors).ExtractFromCommandNode(context.fromCmd);
            List<PointReferenceNode> to = new ToCommandsListBuilder(SemanticErrors).BuildToCommandNodes(context.toCmds);
            MathNode angle = new MathNodeExtractor(SemanticErrors).ExtractMathNode(context.angle);
            CurveCommandNode res = new CurveCommandNode(from, to, angle) 
                {Line = context.type.Line, Column = context.type.Column};
            return res;
        }

        public AntlrASTToMovementCommand(List<SemanticError> errs) : base(errs)
        {
            
        }
    }
}