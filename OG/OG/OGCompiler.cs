using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr4.Runtime;
using OG.ASTBuilding;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting.Visitors;
using OG.AstVisiting.Visitors.ExpressionReduction;
using OG.CodeGeneration;
using OG.Compiler;

namespace OG
{
    public class OGCompiler
    {
        private static async Task Main(string[] args)
        {
            // Load file
            string fileName = args.Length != 0 ? args[0] : "testFile.og";
            string fileLoc = args.Length != 0 ? null : $"../../../{fileName}";
            string sourceFile = File.ReadAllText(fileLoc);

            // Syntactic Analysis
            Console.WriteLine("\n\n-----Lexical ERRORS!----- :\n");
            LexerContainer lexCon = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);

            // Create AST
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parCon.Parser, new AstBuilder("program"));
            ProgramNode p = astContainer.AstTreeTopNode;
            
            // Setup SymbolTable
            List<SemanticError> errors = new List<SemanticError>();
            Dictionary<string, AstNode> symbolTable = new Dictionary<string, AstNode>();
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            p.Accept(ST);
            errors.AddRange(ST.GetErrors());
            
            // Semantic Analysis
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            p.Accept(TT);
            errors.AddRange(TT.GetErrors());
            if (errors.Count == 0)
            {
                // AST Complexity Reduction
                symbolTable = TT.GetSymbolTable();
                LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(symbolTable, errors);
                p.Accept(loopUnfolder);

                ExpressionReducerVisitor reducer = new ExpressionReducerVisitor(symbolTable, errors);

                // Code Generation
                CodeGeneratorVisitor gCodeGeneratorVisitor = new CodeGeneratorVisitor(symbolTable, errors, reducer);
                p.Accept(gCodeGeneratorVisitor);
                string gcode = gCodeGeneratorVisitor.Emit();
                string gcodeFileLoc = fileLoc.Replace(".og", ".gcode");
                File.WriteAllText(Directory.GetCurrentDirectory() + $"/{gcodeFileLoc}", gcode);
            }

            Console.WriteLine("\n\n-----FIX the following ERRORS!----- :\n");
            Console.WriteLine("-----Declaration ERRORS!----- :");
            foreach (var item in ST.GetErrors())
            {
                Console.Write("\n" + item + "\n");
            }
            Console.WriteLine("\n-----Type ERRORS!----- :");
            foreach (var item in TT.GetErrors())
            {
                Console.Write("\n" + item + "\n");
            }
        }
    }
}