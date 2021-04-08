using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using OG.ASTBuilding;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.Compiler;

namespace OG
{
    public class OGCompiler
    {
        public static Dictionary<IDNode, FunctionNode> GlobalFunctionDeclarations = new Dictionary<IDNode, FunctionNode>();
        public static Dictionary<IDNode, ShapeNode>    GlobalShapeDeclarations    = new Dictionary<IDNode, ShapeNode>();
        private static void Main(string[] args)
        {
            // Handle args arguments in finished implementation, so its not hardcoded to testFile.og
            
            string sourceFile      = File.ReadAllText("../../../testFile.og");
            LexerContainer lexCon  = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);

            AstBuilder builder = new AstBuilder();

            
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parCon.Parser);
            
            
            
            //ASTContainer<AstBuilderVisitor, ProgramNode> ast = new ASTContainer<AstBuilderVisitor, ProgramNode>(parCon.Parser);
            

            /*
             
            ASTContainer<AstBuilder, ProgramNode> astContainer =
                new ASTContainer<AstBuilder, ProgramNode>(parCon.OGParser);

            ProgramNode ast = astContainer.AST;

            SemanticAnalyserContainer semanticAnalyserContainer = new SemanticAnalyserContainer(ast);
            
            */
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
}