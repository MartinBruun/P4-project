using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.AST;
using OG.Compiler;
using Lexer = OG.Compiler.Lexer;
using Parser = Antlr4.Runtime.Parser;

namespace OG
{
    public class OGCompiler
    {
        private static void Main(string[] args)
        {
            // Handle args arguments in finished implementation.
            
            string sourceFile        = File.ReadAllText("../../../testFile.og");
            ITokenStream tokenStream = Lexer.CreateTokenStream(sourceFile);
            IParseTree parseTree     = OG.Compiler.Parser.CreateParseTree(tokenStream); // Needs OG.Compiler because Parser is already a class in C#
            OGProgramAST ast         = TypeChecker.CreateAST(parseTree);

            Console.WriteLine("EXITED PROGRAM:\n\n");
            Console.WriteLine(ast.Machinesettings["WorkArea"]);
            
            // AFFTER THIS we need:
            // Translator :  ast -> intermediate representation (IR)
            // 0-many Optimizers optimising the IR inheriting from BaseOptimizer
            // Code Generator : IR -> G-code
            // All classes are to be found in OG.Compiler
        }
    }
}