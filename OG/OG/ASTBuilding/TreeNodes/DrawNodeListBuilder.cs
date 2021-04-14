using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using static System.String;

namespace OG.ASTBuilding.TreeNodes
{
    public class DrawNodeListBuilder : OGBaseVisitor<List<DrawCommandNode>>
    {
        private List<DrawCommandNode> DrawCommandNodes { get; set; } = new List<DrawCommandNode>();
        private DrawCommandNodeExtractor _drawCommandNodeExtractor = new DrawCommandNodeExtractor();

        /// <summary>
        /// TODO Create setting nodes
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override List<DrawCommandNode> VisitDraw(OGParser.DrawContext context)
        {

            DrawCommandNodes = VisitDrawCommands(context.shapesToDraw);
            
            return DrawCommandNodes;
        }

        public override List<DrawCommandNode> VisitDrawCommands(OGParser.DrawCommandsContext context)
        {
            OGParser.DrawCommandsContext nextCommands = context.drawCommands();
            OGParser.DrawCommandContext currentCommand = context.drawCommand();
            //Create node from current drawCommand
            if (currentCommand != null && !currentCommand.IsEmpty)
            {
                Console.WriteLine("\nDraw command found. Detecting drawCommand type... ");
                DrawCommandNodes.Add(ExtractDrawCommandNode(currentCommand));
            }
            
            //If there are more commands visit them recursively.
            if (nextCommands != null &&  !nextCommands.IsEmpty)
            {
                VisitDrawCommands(nextCommands);
            }


            return DrawCommandNodes;
        }
        
        private DrawCommandNode ExtractDrawCommandNode(OGParser.DrawCommandContext context)
        {
            try
            {
                DrawCommandNode result = null;
                try
                {
                    OGParser.DrawFromCmdContext fromContext = (OGParser.DrawFromCmdContext) context;
                    if (!fromContext.IsEmpty)
                    {
                        string id = fromContext.id.Text;
                        string valueString = Concat(fromContext.GetText().Replace(";","").Replace(".from","").Replace(id,"")
                            .Where(c => !char.IsWhiteSpace(c)));
                        Console.WriteLine("\tFromCommand with ID '{0}' and from value {1} detected. Creating Node...",
                            id, valueString);
                        result = _drawCommandNodeExtractor.VisitDrawFromCmd(fromContext);
                        return result;
                    }
                }
                catch (InvalidCastException)
                {
                    //if we have a failed cast, try the other type before throwing
                }

                OGParser.DrawCmdContext drawContext = (OGParser.DrawCmdContext) context;
                if (!drawContext.IsEmpty)
                {
                    Console.WriteLine("\tDrawCmd with ID \"{0}\" detected. Creating Node...",
                        drawContext.id.Text);
                    result = _drawCommandNodeExtractor.VisitDrawCmd(drawContext);
                    return result;
                }
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nEXCEPTION IN CREATE DRAW COMMAND NODE!!\n\n");
            }

            return null;
        }

    }
}

