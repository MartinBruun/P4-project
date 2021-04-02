using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG.AST.Shapes;
using OG.AST.Terminals;

namespace OG.AST.Functions
{
    public class FunctionDeclarationsVisitor : OGBaseVisitor<List<FunctionDeclarationNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "functionDcls";
        /// <summary>
        /// The primary output of FunctionDeclarationVisitor
        /// </summary>
        public List<FunctionDeclarationNode> FunctionDeclarations { get; set; }
        /// <summary>
        /// The secondary output of FunctionDeclarationVisitor
        /// </summary>
        public  List<SemanticError> SemanticErrors { get; set; }

        public FunctionDeclarationsVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public FunctionDeclarationsVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }

        public override List<FunctionDeclarationNode> VisitFunctionDcls([NotNull] OGParser.FunctionDclsContext context)
        {
            FunctionDeclarations = new List<FunctionDeclarationNode>();
            
            IDNode id = new IDNode("ID For Function Declaration");
            FunctionDeclarations.Add(new FunctionDeclarationNode(id));
            
            VisitChildren(context);

            return FunctionDeclarations;
        }
    }
}