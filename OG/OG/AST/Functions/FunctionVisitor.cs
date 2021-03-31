using System.Collections.Generic;
using Antlr4.Runtime.Misc;

namespace OG.AST.Functions
{
    public class FunctionVisitor : OGBaseVisitor<List<FunctionDeclarationNode>>
    {
        public List<FunctionDeclarationNode> FunctionDeclarations { get; set; }

        public override List<FunctionDeclarationNode> VisitFunctionDcl([NotNull] OGParser.FunctionDclContext context)
        {
            FunctionDeclarations = new List<FunctionDeclarationNode>();
            
            VisitChildren(context);

            return FunctionDeclarations;
        }
    }
}