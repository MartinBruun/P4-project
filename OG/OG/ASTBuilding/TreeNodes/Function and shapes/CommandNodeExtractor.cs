using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Visitors;

namespace OG.AST.Functions
{
    public class CommandNodeExtractor : OGBaseVisitor<CommandNode>
    {
        private AntlrToIterationCommand _iterationNodeExtractor = new AntlrToIterationCommand();
        private AntlrASTToMovementCommand _movementCommandExtractor = new AntlrASTToMovementCommand();
        private DrawCommandNodeExtractor _drawCommandNodeExtractor = new DrawCommandNodeExtractor();
        public override CommandNode VisitStmt(OGParser.StmtContext context)
        {
            if (context == null || context.cmd == null)
            {
                return null;
            }
            OGParser.DrawCommandContext drawCommandContext = context.cmd.drawCmd;
            OGParser.MovementCommandContext movementContext = context.cmd.movementCmd;
            OGParser.IterationCommandContext iterationContext = context.cmd.iterCmd;

            if (drawCommandContext != null && !drawCommandContext.IsEmpty)
            {
                return _drawCommandNodeExtractor.VisitStmt(context);
            }

            if (movementContext != null && !movementContext.IsEmpty)
            {
                return _movementCommandExtractor.VisitMovementCommand(movementContext);
            }

            if (iterationContext == null || iterationContext.IsEmpty) return null;
            if (iterationContext.numberIterCmd != null && !iterationContext.numberIterCmd.IsEmpty)
            {
                return _iterationNodeExtractor.VisitNumberIteration(iterationContext.numberIterCmd);
            }
            else if (iterationContext.untilIterCmd != null && !iterationContext.untilIterCmd.IsEmpty)
            {
                return _iterationNodeExtractor.ExtractIterationNode(iterationContext.untilIterCmd);
            }

            //It was not a command;
            return null;

        }
    }
}