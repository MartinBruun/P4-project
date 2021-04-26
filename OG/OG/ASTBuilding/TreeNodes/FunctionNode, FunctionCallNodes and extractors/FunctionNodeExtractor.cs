using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using static System.String;

namespace OG.ASTBuilding.TreeNodes
{
    public class FunctionNodeExtractor : AstBuilderErrorInheritor<FunctionNode>
    {
        private readonly BodyNodeExtractor _bodyNodeExtractor;

        
        public FunctionNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            _bodyNodeExtractor = new BodyNodeExtractor(errs);
        }



        
        public override FunctionNode VisitFunctionDcl(OGParser.FunctionDclContext context)
        {
            OGParser.VoidFunctionDCLContext voidFunction  = context.voidFunctionDCL();
            OGParser.ReturnFunctionDCLContext returnFunction = context.returnFunctionDCL();
            ParameterTypeListBuilder paramDclsListBuilder = new ParameterTypeListBuilder(SemanticErrors);
            //If it is a void function, create a function node from its body and text.
            string functionName;
            string returnType;
            
            
            if (voidFunction != null && !voidFunction.IsEmpty)
            {
                functionName = voidFunction.id.Text;
                returnType = voidFunction.type.Text;
                IdNode id = new IdNode(functionName);
                Console.WriteLine("\t{1} function named {0} detected! Creating node...", functionName, returnType);
               
                List<ParameterTypeNode> paramDcls = paramDclsListBuilder.VisitVoidFunctionDCL(voidFunction);
                return new FunctionNode(id, returnType, _bodyNodeExtractor.VisitBody(voidFunction.body()),paramDcls);
            } 
            if (returnFunction != null && !returnFunction.IsEmpty)
            {
                functionName = returnFunction.funcName.Text;
                returnType = returnFunction.type.GetText();
                IdNode id = new IdNode(functionName);
                Console.WriteLine("\t{1} function named {0} detected! Creating node...", functionName, returnType);
                
                
                
                List<ParameterTypeNode> paramDcls = paramDclsListBuilder.VisitReturnFunctionDCL(returnFunction);
                return new FunctionNode(id, returnType, _bodyNodeExtractor.VisitBody(returnFunction.body()), paramDcls);

            }
            
            SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column, "Function was neither void or typed with return value.")
            {
                IsFatal = true
            });

            return null;

        }


    }

   
}