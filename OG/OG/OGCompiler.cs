using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using OG.AST;
using OG.AST.Functions;
using OG.AST.Shapes;
using OG.AST.Terminals;
using OG.Compiler;

namespace OG
{
    public class OGCompiler
    {
        public static Dictionary<IDNode, FunctionDeclarationNode> GlobalFunctionDeclarations = new Dictionary<IDNode, FunctionDeclarationNode>();
        public static Dictionary<IDNode, ShapeDeclarationNode>    GlobalShapeDeclarations = new Dictionary<IDNode, ShapeDeclarationNode>();
        private static void Main(string[] args)
        {
            // Handle args arguments in finished implementation, so its not hardcoded to testFile.og
            
            string sourceFile      = File.ReadAllText("../../../testFile.og");
            LexerContainer lexCon  = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            
            ASTBuilder<AstBuilderVisitor, ProgramNode> asTbuilder =
                new ASTBuilder<AstBuilderVisitor, ProgramNode>(parCon.OGParser);

            ProgramNode ast = asTbuilder.AST;

            SemanticAnalyserCon semanticAnalyserCon = new SemanticAnalyserCon(ast);
            
            
            //De resterende items bør udelukkende være dependant på opdaterede AST'er.
            /*
            TypeChecker<ProgramNode, ASTBuilderVisitor> typeChecker        = new TypeChecker<ProgramNode,ASTBuilderVisitor>(parCon.OGParser);
            Translator translator  = new Translator(typeChecker.AST);
            // var peepOptimizer   = new PeepOptimizer(translator.IR);
            // ...                 = ...
            // var lastOptimizer   = new LastOptimizer(peepOptimizer.IR);
            // var codeGenerator   = new CodeGenerator(lastOptimizer.IR);
            // File.Write("testFile.gcode", codeGenerator.Code);
            
            Console.WriteLine("EXITED PROGRAM:");
            Console.WriteLine(typeChecker.AST.MachineSettings["WorkArea"]);
            Console.WriteLine(typeChecker.AST.DrawElements[0]);
            Console.WriteLine(typeChecker.AST.FunctionDcls[0]);
            Console.WriteLine(typeChecker.AST.ShapeDcls[0]);
            Console.WriteLine("\n\nTRANSLATOR IS STILL WORK IN PROGRESS!");
            */
        }
    }

    /// <summary>
    /// Container performing all semantic analysis of the AST. All decoration of the AST before code generation happens here. 
    /// </summary>
    public class SemanticAnalyserCon
    {
        //TypeChecker<ProgramNode, ASTBuilderVisitor> typeChecker = new TypeChecker<ProgramNode,ASTBuilderVisitor>(parCon.OGParser);
        public ProgramNode AST { get; private set; }

        public SemanticAnalyserCon(ProgramNode ast)
        {
            AST = ast;
        }
    }
}