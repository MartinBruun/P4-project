using System;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes
{
    public class FunctionNodeExtractor : OGBaseVisitor<FunctionNode>
    {
        private readonly BodyNodeExtractor _bodyNodeExtractor = new BodyNodeExtractor();
        public override FunctionNode VisitFunctionDcl(OGParser.FunctionDclContext context)
        {
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

            throw new FormatException("Function was neither return or void function.");
            
        }
    }
}