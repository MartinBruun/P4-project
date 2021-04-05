using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Terminals;

namespace OG.AST.Functions
{
    public class FunctionDeclarationsVisitor : OGBaseVisitor<List<FunctionNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "functionDcls";
        public List<FunctionNode> FunctionDeclarations { get; set; }
        public  List<SemanticError> SemanticErrors { get; set; }

        private readonly FunctionDeclarationVisitor singleFunctionVisitor = new FunctionDeclarationVisitor();

        public FunctionDeclarationsVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public FunctionDeclarationsVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
            singleFunctionVisitor = new FunctionDeclarationVisitor(semanticErrors);
        }

        public override List<FunctionNode> VisitFunctionDcls([NotNull] OGParser.FunctionDclsContext context)
        {

            OGParser.FunctionDclContext currentFunction = context.functionDcl();
            if (currentFunction != null)
            {
                //Since singleFunctionVisitor uses error list from this, errors are still gather in this list.
                FunctionDeclarations.Add(singleFunctionVisitor.VisitFunctionDcl(currentFunction));
            }
            if (context.functionDcls() != null) 
                VisitFunctionDcls(context.functionDcls());
            
            return FunctionDeclarations;
        }

        
        
    }

    public class FunctionDeclarationNode
    {
    }
}