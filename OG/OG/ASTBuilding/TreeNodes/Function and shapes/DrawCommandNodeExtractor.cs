using System;
using System.Linq;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Draw
{
    public class DrawCommandNodeExtractor : OGBaseVisitor<DrawCommandNode>
    {
        private PointReferenceNodeExtractor _pointReferenceNodeExtractor = new PointReferenceNodeExtractor();

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
    }

   
}