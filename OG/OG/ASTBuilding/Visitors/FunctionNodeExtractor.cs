using System;
using Antlr4.Runtime;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.AST.Functions
{
    public class FunctionNodeExtractor : OGBaseVisitor<FunctionNode>
    {
        private BodyNodeExtractor _bodyNodeExtractor = new BodyNodeExtractor();
        public override FunctionNode VisitFunctionDcl(OGParser.FunctionDclContext context)
        {
            FunctionNode resultNode = null;
            OGParser.VoidFunctionDCLContext voidFunction  = context.voidFunctionDCL();
            OGParser.ReturnFunctionDCLContext returnFunction = context.returnFunctionDCL();
            //If it is a void function, create a function node from its body and text.
            if (voidFunction != null && !voidFunction.IsEmpty)
            {
                string functionName = voidFunction.id.Text;
   
                Console.WriteLine("\tvoid function named {0} detected! Creating node...", functionName);

                IDNode idNode = new IDNode(functionName);
                throw new NotImplementedException("Cannot create bodynodes yet. Working on it.");
                BodyNode body = null;
                try
                {
                    return new FunctionNode(idNode, "void", body);
                    OGCompiler.GlobalFunctionDeclarations.Add(idNode, resultNode);
                }
                catch (ArgumentException e)
                {
                    throw new AstNodeCreationException(e.Message);
                }
            }
            
            if (returnFunction != null && !returnFunction.IsEmpty)
            {
                try
                {
                    OGParser.ReturnFunctionDCLContext function  = context.returnFunctionDCL();
                    string functionName = function.funcName.Text;
                    string returnType   = function.type.GetText();
                    Console.WriteLine("\t{1} function named {0} detected! Creating node...", functionName, returnType);
                    
                    BodyNode body = _bodyNodeExtractor.VisitBody(function.body());
                    IDNode idNode = new IDNode(functionName);
                    return new FunctionNode(idNode, returnType, body);

                }
                catch (ArgumentException e)
                {
                    IToken token = context.Start;

                    throw new AstNodeCreationException(e.Message);
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