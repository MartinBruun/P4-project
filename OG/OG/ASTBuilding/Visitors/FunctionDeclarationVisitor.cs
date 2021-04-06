using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using OG.ASTBuilding;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.AST.Functions
{
    /// <summary>
    /// Visits a single function declaration and builds a FunctionNode from it by building a BodyNode, IdNode, and setting return type of the node. Global symbol table for functions is checked for duplicate values.
    /// </summary>
    public class FunctionDeclarationVisitor : ErrorInheritorVisitor<FunctionNode>
    {

        public FunctionDeclarationVisitor(List<SemanticError> errs) : base(errs)
        {
        }
        
        
        /// <summary>
        /// Creates FunctionNode from FunctionDclContext and returns it.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="FormatException"></exception>
        public override FunctionNode VisitFunctionDcl(OGParser.FunctionDclContext context)
        {
            FunctionNode resultNode = null;
            OGParser.VoidFunctionDCLContext voidFunction  = context.voidFunctionDCL();
            OGParser.ReturnFunctionDCLContext returnFunction = context.returnFunctionDCL();
            //If it is a void function, create a function node from its body and text.
            if (voidFunction != null && !voidFunction.IsEmpty)
            {
                string functionName = voidFunction.id.Text;
                BodyNode body = new BodyNode(voidFunction.body(), SemanticErrors);

                IDNode idNode = new IDNode(functionName);
                try
                {
                    resultNode = new FunctionNode(idNode, "void", body);
                    OGCompiler.GlobalFunctionDeclarations.Add(idNode, resultNode);
                }
                catch (ArgumentException e)
                {
                    IToken token = context.Start;
                    SemanticErrors.Add(new SemanticError(token.Line,token.Column,
                        "A shape with that name has already been declared.", context.GetText()));
                    Console.WriteLine(e);
                    throw;
                }
            }
            else if (returnFunction != null && !returnFunction.IsEmpty)
            {
                OGParser.ReturnFunctionDCLContext functionDcl  = context.returnFunctionDCL();
                string functionName = functionDcl.funcName.Text;
                string returnType = functionDcl.type.GetText();
                BodyNode body = new BodyNode(functionDcl.body(), SemanticErrors);

                IDNode idNode = new IDNode(functionName);
                try
                {
                    resultNode = new FunctionNode(idNode, returnType, body);
                    OGCompiler.GlobalFunctionDeclarations.Add(idNode, resultNode);
                }
                catch (ArgumentException e)
                {
                    IToken token = context.Start;
                    SemanticErrors.Add(new SemanticError(token.Line,token.Column,
                        "A function with that name has already been declared.", context.GetText()));
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                throw new FormatException("Function was neither return or void function.");
            }
            return resultNode;
        }


    }
}