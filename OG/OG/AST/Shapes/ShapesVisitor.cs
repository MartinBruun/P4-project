using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Terminals;

namespace OG.AST.Shapes
{
    public class ShapesVisitor : OGBaseVisitor<List<ShapeDeclarationNode>>
    {
        public List<ShapeDeclarationNode> ShapeDeclarations { get; set; }

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