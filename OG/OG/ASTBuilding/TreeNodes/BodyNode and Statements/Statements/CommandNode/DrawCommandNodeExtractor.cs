using System;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class DrawCommandNodeExtractor : OGBaseVisitor<DrawCommandNode>
    {
        public override DrawCommandNode VisitDrawCmd(OGParser.DrawCmdContext context)
        {
            return new DrawCommandNode(id: new IdNode(context.id.Text));
        }

        private readonly PointReferenceNodeExtractor _pointReferenceNodeExtractor = new PointReferenceNodeExtractor();

        public override DrawCommandNode VisitDrawFromCmd(OGParser.DrawFromCmdContext context)
        {
            
            if (context == null || !context.GetText().Contains("from"))
            {
                throw new AstNodeCreationException("From node context does not contain the word from.");
            }

            Console.WriteLine("\tCreating drawCommand node for fromCommand...");
            IdNode id = new IdNode(context.id.Text);
            PointReferenceNode pointRef = _pointReferenceNodeExtractor.ExtractPointReferenceNode(context.fromCmd);
            
            return new DrawCommandNode(id, pointRef);
        }

        public override DrawCommandNode VisitStmt(OGParser.StmtContext context)
        {
            if (context.cmd?.drawCmd == null || context.cmd.drawCmd.IsEmpty) return null;

            return ExtractDrawCommandNode(context.cmd.drawCmd);

        }

        public DrawCommandNode ExtractDrawCommandNode(OGParser.DrawCommandContext context)
        {
            try
            {
                OGParser.DrawCmdContext drawCmdContext = (OGParser.DrawCmdContext) context;
                return VisitDrawCmd(drawCmdContext);
            }
            catch (InvalidCastException)
            {}
            
            OGParser.DrawFromCmdContext drawFromContext = (OGParser.DrawFromCmdContext) context;
            return VisitDrawFromCmd(drawFromContext);

        }
    }

   
}