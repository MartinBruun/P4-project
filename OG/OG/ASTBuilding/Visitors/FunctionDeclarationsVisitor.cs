using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Functions;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Functions
{
    public class FunctionDeclarationsVisitor : ErrorInheritorVisitor<List<FunctionNode>>
    {
        public string TopNode { get; set; } = "functionDcls";
        public List<FunctionNode> FunctionDeclarations { get; set; }


        private readonly FunctionDeclarationVisitor singleFunctionVisitor;
        public FunctionDeclarationsVisitor(List<SemanticError> errs) : base(errs)
        {
            singleFunctionVisitor = new FunctionDeclarationVisitor(SemanticErrors);
        }
        


        public override List<FunctionNode> VisitFunctionDcls([NotNull] OGParser.FunctionDclsContext context)
        {
            OGParser.FunctionDclContext currentFunction = context.functionDcl();
            //If there is a function declaration visit it, if there are more recursively visit them
            if (currentFunction != null && !currentFunction.IsEmpty)
            {
                //Since singleFunctionVisitor uses error list from this, errors are still gather in this list.
                FunctionDeclarations.Add(singleFunctionVisitor.VisitFunctionDcl(currentFunction));
            }
            if (context.functionDcls() != null && !context.functionDcls().IsEmpty) 
                VisitFunctionDcls(context.functionDcls());
            
            return FunctionDeclarations;
        }


        
    }

}