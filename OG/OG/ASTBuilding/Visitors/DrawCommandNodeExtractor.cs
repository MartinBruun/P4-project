using System;
using System.Linq;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Draw
{
    public class DrawCommandNodeExtractor : OGBaseVisitor<DrawCommandNode>
    {

        public override DrawCommandNode VisitDrawFromCmd(OGParser.DrawFromCmdContext context)
        {
            
            if (context == null || !context.GetText().Contains("from"))
            {
                throw new AstNodeCreationException("From node context does not contain the word from.");
            }

            Console.WriteLine("\tCreating drawCommand node for fromCommand...");
            IDNode id = new IDNode(context.id.Text);
            PointReferenceNode pointRef = CreatePointRefNode(context.fromCmd);
            FromCommandNode from = new FromCommandNode(pointRef);
            
            return new DrawCommandNode(id, from);
        }

        private PointReferenceNode CreatePointRefNode(OGParser.FromCommandContext fromCmdContext)
        {
            string valueString = string.Concat(fromCmdContext.GetText()
                .Replace(";","").Replace(".from","")
                .Where(c => !char.IsWhiteSpace(c)));
            return new PointReferenceNode(valueString);
        }

    }
}