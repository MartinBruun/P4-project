using System.Collections.Generic;
using Antlr4.Runtime.Misc;

namespace OG.AST.Draw
{
    public class DrawVisitor : OGBaseVisitor<List<ShapeNode>>
    {
        public List<ShapeNode> DrawElements { get; set; }

        public override List<ShapeNode> VisitDraw(OGParser.DrawContext context)
        {
            DrawElements = new List<ShapeNode>();
            
            VisitChildren(context);

            return DrawElements;
        }
    }
}