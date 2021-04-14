using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.Visitors;

namespace OG.ASTBuilding.Shapes
{
    public class ShapeDeclarationsVisitor : OGBaseVisitor<List<ShapeNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "shapeDcls";
        public List<ShapeNode> ShapeDeclarations { get; set; }
        public List<SemanticError> SemanticErrors { get; set; }
        
        private ShapeDeclarationVisitor _shapeDeclarationsVisitor;

        public ShapeDeclarationsVisitor()
        {
            SemanticErrors = new List<SemanticError>();
            _shapeDeclarationsVisitor = new ShapeDeclarationVisitor(SemanticErrors);
        }
        public ShapeDeclarationsVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
            ShapeDeclarations = new List<ShapeNode>();
            //The _shapeVisitor will add to the current errors instead of using own list.
            _shapeDeclarationsVisitor = new ShapeDeclarationVisitor(SemanticErrors);
        }

        public override List<ShapeNode> VisitShapeDcls(OGParser.ShapeDclsContext context)
        {
            OGParser.ShapeDclContext current = context.shapeDcl();
            if (current != null)
            {
                ShapeDeclarations.Add( _shapeDeclarationsVisitor.Visit(current));
            }

            if (context.shapeDeclarations != null)
                VisitShapeDcls(context.shapeDeclarations);

            return ShapeDeclarations;
        }
    }
}