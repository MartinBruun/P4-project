using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Terminals;

namespace OG.AST.Shapes
{
    public class ShapeDeclarationsVisitor : OGBaseVisitor<List<ShapeDeclarationNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "shapeDcls";
        public List<ShapeDeclarationNode> ShapeDeclarations { get; set; }
        public  List<SemanticError> SemanticErrors { get; set; }
        
        public ShapeDeclarationsVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public ShapeDeclarationsVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
            ShapeDeclarations = new List<ShapeDeclarationNode>();
        }

        public override List<ShapeDeclarationNode> VisitShapeDcls(OGParser.ShapeDclsContext context)
        {
            ShapeDeclarations = new List<ShapeDeclarationNode>();

            IDNode id = new IDNode("ID For Shape Declaration");
            ShapeDeclarations.Add(new ShapeDeclarationNode(id));
            
            VisitChildren(context);

            return ShapeDeclarations;
        }
    }
}