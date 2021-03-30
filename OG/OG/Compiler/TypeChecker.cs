using System;
using Antlr4.Runtime.Tree;
using OG.AST;

namespace OG.Compiler
{
    /// <summary>
    /// Takes in a ParseTree and converts it to a decorated AST.
    /// Is responsible for the semantic analysis of the source file.
    /// </summary>
    public class TypeChecker
    {
        internal static OGProgramAST CreateAST(IParseTree tree)
        {
            AntlrToProgramAST visitor = new AntlrToProgramAST();
            
            OGProgramAST programAST = visitor.Visit(tree);
            if (visitor.SemanticErrors != null)
            {
                Console.WriteLine("\nSEMANTIC ERRORS DETECTED");
                foreach (SemanticError error in visitor.SemanticErrors)
                {
                    Console.WriteLine(error);
                }
            }
            return programAST;
        }
    }
}