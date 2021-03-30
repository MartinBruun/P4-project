using System;
using System.Reflection;
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
        internal static OGProgramAST CreateAST(string program)
        {
            OGParser parser = Parser.CreateParser(program);
            IParseTree tree = parser.program();  // Consider adding reflection, so the rule isnt hardcoded to "program" but can be other rules.
            AntlrToProgramAST visitor = new AntlrToProgramAST();
            
            OGProgramAST ast = visitor.Visit(tree);
            if (visitor.SemanticErrors != null)
            {
                Console.WriteLine("\nSEMANTIC ERRORS DETECTED");
                foreach (SemanticError error in visitor.SemanticErrors)
                {
                    Console.WriteLine(error);
                }
            }
            return ast;
        }
    }
}