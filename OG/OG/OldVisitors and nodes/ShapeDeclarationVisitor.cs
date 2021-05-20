// using System;
// using System.Collections.Generic;
// using Antlr4.Runtime;
// using OG.ASTBuilding.Shapes;
// using OG.ASTBuilding.Terminals;
// using OG.ASTBuilding.TreeNodes;
// using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
// using OG.ASTBuilding.TreeNodes.TerminalNodes;
//
// namespace OG.ASTBuilding.Visitors
// {
//     /// <summary>
//     /// Visits a single shape declaration and builds a FunctionNode from it by building a BodyNode, IdNode, and setting return type of the node. Global symbol table for functions is checked for duplicate values.
//     /// </summary>
//     public class ShapeDeclarationVisitor : OGBaseVisitor<ShapeNode>, ISemanticErrorable
//     {
//         public List<SemanticError> SemanticErrors { get; set; }
//         public string TopNode { get; set; }
//         
//         public ShapeDeclarationVisitor(List<SemanticError> semanticErrors)
//         {
//             this.SemanticErrors = semanticErrors;
//         }
//         public override ShapeNode VisitShapeDcl(OGParser.ShapeDclContext context)
//         {
//             string shapeId = context.id.Text;
//             BodyNode body = null;
//             IdNode idNode = new IdNode(shapeId);
//             try
//             {
//                 OGCompiler.GlobalShapeDeclarations.Add(idNode, new ShapeNode(idNode, body));
//             }
//             catch (ArgumentException e)
//             {
//                 IToken token = context.Start;
//                 SemanticErrors.Add(new SemanticError(token.Line,token.Column,
//                     "A shape with that name has already been declared.", context.GetText()));
//                 Console.WriteLine(e);
//                 throw;
//             }
//             return base.VisitShapeDcl(context);
//         }
//     }
// }