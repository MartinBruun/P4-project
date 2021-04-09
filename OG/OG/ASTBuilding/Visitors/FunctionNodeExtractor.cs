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
            string functionName;
            string returnType;
            
            if (voidFunction != null && !voidFunction.IsEmpty)
            {
                functionName = voidFunction.id.Text;
                returnType = voidFunction.type.Text;
                IdNode id = new IdNode(functionName);
                Console.WriteLine("\t{1} function named {0} detected! Creating node...", functionName, returnType);
                return new FunctionNode(id, returnType, _bodyNodeExtractor.VisitBody(voidFunction.body()));
            } 
            if (returnFunction != null && !returnFunction.IsEmpty)
            {
                functionName = returnFunction.funcName.Text;
                returnType = returnFunction.type.GetText();
                IdNode id = new IdNode(functionName);
                Console.WriteLine("\t{1} function named {0} detected! Creating node...", functionName, returnType);
                return new FunctionNode(id, returnType, _bodyNodeExtractor.VisitBody(returnFunction.body()));

            }
            else
            {
                throw new FormatException("Function was neither return or void function.");
            }
            return resultNode;
        }
    }
}