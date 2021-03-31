using System.Collections.Generic;
using Antlr4.Runtime.Misc;

namespace OG.AST.Shapes
{
    public class ShapesVisitor : OGBaseVisitor<List<ShapeDeclarationNode>>
    {
        public List<ShapeDeclarationNode> ShapeDeclarations { get; set; }

        public override List<ShapeDeclarationNode> VisitShapeDeclarations(OGParser.ShapeDeclarationsContext context)
        {
            ShapeDeclarations = new List<ShapeDeclarationNode>();
            
            VisitChildren(context);

            return ShapeDeclarations;
        }
    }
}