﻿using System;
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
            
            string sourceFile      = File.ReadAllText("../../../testFile.og");
            LexerContainer lexCon  = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            var typeChecker        = new TypeChecker<OGProgramAST,AntlrToProgramAST>(parCon.OGParser, "program");
            var translator         = new Translator<OGProgramAST>(typeChecker.AST);
            // var peepOptimizer   = new PeepOptimizer<OGProgramAST>(translator.IR);
            // ...                 = ...
            // var lastOptimizer   = new LastOptimizer<OGProgramAST>(peepOptimizer.IR);
            // var codeGenerator   = new CodeGenerator<OGProgramAST>(lastOptimizer.IR);
            // File.Write("code.gcode", codeGenerator.Code);
            
            Console.WriteLine("EXITED PROGRAM:\n\n");
            Console.WriteLine(typeChecker.AST.MachineSettings["WorkArea"]);
            Console.WriteLine("\n\nTRANSLATOR IS STILL WORK IN PROGRESS!");
        }
    }
}