using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Terminals;

namespace OG.AST.Draw
{
    public class DrawVisitor : OGBaseVisitor<List<ShapeNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "draw";
        public List<ShapeNode> DrawElements { get; set; }
        public  List<SemanticError> SemanticErrors { get; set; }

        public DrawVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public DrawVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }

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