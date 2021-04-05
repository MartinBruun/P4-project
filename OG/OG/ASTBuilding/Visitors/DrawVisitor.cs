using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Shapes;
using OG.AST.Terminals;

namespace OG.AST.Draw
{
    public class DrawVisitor : OGBaseVisitor<List<DrawNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "draw";
        public List<DrawNode> DrawElements { get; set; }
        public  List<SemanticError> SemanticErrors { get; set; }

        public DrawVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public DrawVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }

        public override List<DrawNode> VisitDraw(OGParser.DrawContext context)
        {
            DrawElements = new List<DrawNode>();

            IDNode id = new IDNode("ID For a Shape Node in the Draw Function");
            DrawElements.Add(new DrawNode(id));
            
            VisitChildren(context);

            return DrawElements;
        }
    }

    public class DrawNode
    {
        private IDNode id;

        public DrawNode(IDNode id)
        {
            
        }
    }
}