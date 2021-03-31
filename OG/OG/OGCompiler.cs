using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.AST;
using OG.Compiler;

namespace OG
{
    public class OGCompiler
    {
        private static void Main(string[] args)
        {
            // Handle args arguments in finished implementation, so its not hardcoded to testFile.og
            
            string sourceFile       = File.ReadAllText("../../../testFile.og");
            LexerContainer lexCon   = new LexerContainer(sourceFile);
            ParserContainer parCon  = new ParserContainer(lexCon);
            var typeChecker         = new TypeChecker<OGProgramAST,AntlrToProgramAST>(parCon);
            
            Console.WriteLine("EXITED PROGRAM:\n\n");
            Console.WriteLine(typeChecker.AST.MachineSettings["WorkArea"]);
            
            // AFFTER THIS we need:
            // Translator :  ast -> intermediate representation (IR)
            // 0-many Optimizers optimising the IR inheriting from BaseOptimizer
            // Code Generator : IR -> G-code
            // All classes are to be found in OG.Compiler
        }
    }
}