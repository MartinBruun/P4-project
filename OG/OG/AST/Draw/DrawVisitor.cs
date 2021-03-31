using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Terminals;

namespace OG.AST.Draw
{
    public class DrawVisitor : OGBaseVisitor<List<ShapeNode>>
    {
        public List<ShapeNode> DrawElements { get; set; }

        public override List<ShapeNode> VisitDraw(OGParser.DrawContext context)
        {
            DrawElements = new List<ShapeNode>();

            IDNode id = new IDNode("ID For a Shape Node in the Draw Function");
            DrawElements.Add(new ShapeNode(id));
            
            VisitChildren(context);

            return DrawElements;
        }
    }
}