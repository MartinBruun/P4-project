using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using OG.AST.Shapes;
using OG.AST.Terminals;

namespace OG.AST.Visitors
{
    public class ShapeDeclarationVisitor : OGBaseVisitor<ShapeDeclarationNode>, ISemanticErrorable
    {
        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        public ShapeDeclarationVisitor()
        {
           
        }
        public override ShapeDeclarationNode VisitShapeDcl(OGParser.ShapeDclContext context)
        {
            string shapeId = context.id.Text;
            IDNode idNode = new IDNode(shapeId);
            try
            {
                OGCompiler.GlobalShapeDeclarations.Add(idNode, new ShapeDeclarationNode(idNode));
            }
            catch (ArgumentException e)
            {
                IToken token = context.Start;
                SemanticErrors.Add(new SemanticError(token.Line,token.Column,
                    "A shape with that name has already been declared.", context.GetText()));
                Console.WriteLine(e);
                throw;
            }

            
            return base.VisitShapeDcl(context);
        }
    }
}