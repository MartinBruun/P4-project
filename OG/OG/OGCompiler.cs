using System;
using System.Collections.Generic;
using System.IO;
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
using OG.CodeGeneration;
using OG.Compiler;

namespace OG
{

    public abstract class ErrorInheritorVisitor : IErrorable
    {
        
        public ErrorInheritorVisitor(List<SemanticError> errs)
        {
            SemanticErrors = errs;
        }
        public List<SemanticError> SemanticErrors { get; set; }
    }     
    
    
    
    
    public class OGCompiler
    {
        public static Dictionary<IdNode, FunctionNode> GlobalFunctionDeclarations = new Dictionary<IdNode, FunctionNode>();
        public static readonly Dictionary<IdNode, ShapeNode>    GlobalShapeDeclarations    = new Dictionary<IdNode, ShapeNode>();
        private static async Task Main(string[] args)
        {
            
            double x1 = -0.000001, x2 = -1, y1 = 2.9999, y2 = 9999999.9999;
            NumberNode x1Val = new NumberNode(x1);
            NumberNode y1Val = new NumberNode(y2);
            
            NumberNode x2Val = new NumberNode(x2);
            NumberNode y2Val = new NumberNode(y2);
            List<PointReferenceNode> ToCommands = new List<PointReferenceNode>();

            LineEmitterVisitor emitter = new LineEmitterVisitor(null, new List<SemanticError>());
            
            ToCommands.Add(new TuplePointNode("", x2Val, y2Val));
            
            
            LineCommandNode lineCommand = new LineCommandNode(new TuplePointNode("",x1Val, y1Val), ToCommands);
            lineCommand.Accept(emitter);
            emitter.CodeGenerationNotification += (Console.WriteLine);
            
            
            await File.WriteAllTextAsync("../../WriteText.txt", emitter.Emit());


            
            
            // Handle args arguments in finished implementation, so its not hardcoded to testFile.og
            
            List<SemanticError> errors = new List<SemanticError>();
            Dictionary<string, AstNode> symbolTable = new Dictionary<string, AstNode>();

            string sourceFile      = File.ReadAllText("../../../testFile.og");
            LexerContainer lexCon  = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            
            
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parCon.Parser, new AstBuilder("program"));
            
            ProgramNode p = astContainer.AstTreeTopNode;

            PrettyPrinter PP = new PrettyPrinter();
            p.Accept(PP);
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            p.Accept(ST);
            errors.AddRange(ST.GetErrors());
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            p.Accept(TT);
            errors.AddRange(TT.GetErrors());
            symbolTable = TT.GetSymbolTable();

            Console.WriteLine("\n\n-----FIX the following ERRORS!----- :\n");

            foreach (var item in errors)
            {
                Console.Write("\n"+item + "\n");

            }
            
            Console.WriteLine("\n\n---The SYMBOLTABLE contains:---\n");
            foreach (var item in symbolTable)
            {
                Console.WriteLine(item);
            }

            


            // errors.AddRange(ST.GetErrors());
            // TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            // p.Accept(TT);
            // errors.AddRange(TT.GetErrors());
            // symbolTable = TT.GetSymbolTable();
            //
            // Console.WriteLine("\n\n-----FIX the following ERRORS!----- :\n");
            //
            // foreach (var item in errors)
            // {
            //     Console.Write("\n"+item + "\n");
            //
            // }
            //
            // Console.WriteLine("\n\n---The SYMBOLTABLE contains:---\n");
            // foreach (var item in symbolTable)
            // {
            //     Console.WriteLine(item);
            // }
            //






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