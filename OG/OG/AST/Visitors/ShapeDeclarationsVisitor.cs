using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using OG.AST.Terminals;
using OG.AST.Visitors;

namespace OG.AST.Shapes
{
    public class ShapeDeclarationsVisitor : OGBaseVisitor<List<ShapeDeclarationNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "shapeDcls";
        public List<ShapeDeclarationNode> ShapeDeclarations { get; set; }
        public List<SemanticError> SemanticErrors { get; set; }
        
        private ShapeDeclarationVisitor _shapeDeclerationsVisitor = new ShapeDeclarationVisitor();

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
            OGParser.ShapeDclContext current = context.shapeDcl();

            _shapeDeclerationsVisitor.Visit(current);
            SemanticErrors.AddRange(_shapeDeclerationsVisitor.SemanticErrors);
            
            //Create a list of shape declarations that can be visited later. 
            ShapeDeclarations.Add(new ShapeDeclarationNode(new IDNode(current.GetText())));

            //Recursively visit the next declarations
            if (context.shapeDeclarations != null)
                VisitShapeDcls(context.shapeDeclarations);

            return ShapeDeclarations;
        }
    }
}