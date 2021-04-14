namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class CommandNodeExtractor : OGBaseVisitor<CommandNode>
    {
        public override CommandNode VisitStmt(OGParser.StmtContext context)
        {
            if (context?.cmd == null)
            {
                return null;
            }
            OGParser.DrawCommandContext drawCommandContext = context.cmd.drawCmd;
            OGParser.MovementCommandContext movementContext = context.cmd.movementCmd;
            OGParser.IterationCommandContext iterationContext = context.cmd.iterCmd;

            if (drawCommandContext != null && !drawCommandContext.IsEmpty)
            {
                return new DrawCommandNodeExtractor().VisitStmt(context);
            }

            if (movementContext != null && !movementContext.IsEmpty)
            {
                return new AntlrASTToMovementCommand().VisitMovementCommand(movementContext);
            }

            if (iterationContext == null || iterationContext.IsEmpty) return null;
            if (iterationContext.numberIterCmd != null && !iterationContext.numberIterCmd.IsEmpty)
            {
                return new AntlrToIterationCommand().VisitNumberIteration(iterationContext.numberIterCmd);
            }

            if (iterationContext.untilIterCmd != null && !iterationContext.untilIterCmd.IsEmpty)
            {
                return new AntlrToIterationCommand().ExtractIterationNode(iterationContext.untilIterCmd);
            }

            //It was not a command;
            return null;

        }
    }
}