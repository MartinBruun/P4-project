using System;
using System.Collections.Generic;
using System.IO;
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
using OG.AstVisiting.Visitors.ProgramRunner;
using OG.CodeGeneration;
using OG.Compiler;

namespace OG
{
    public class OGCompiler
    {
        public static readonly Dictionary<IdNode, ShapeNode> GlobalShapeDeclarations =
            new Dictionary<IdNode, ShapeNode>();

        private static async Task Main(string[] args)
        {
            // Handle args arguments in finished implementation, so its not hardcoded to testFile.og
            List<SemanticError> errors = new List<SemanticError>();
            Dictionary<string, AstNode> symbolTable = new Dictionary<string, AstNode>();

            string sourceFile = File.ReadAllText("../../../testFile.og");
            LexerContainer lexCon = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            //TODO: add errorlistener to the parCon.Parser, that collects the errors in the errors list for later print.

            AstBuilder builder = new AstBuilder("program");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parCon.Parser, builder);
            
            ProgramNode p = astContainer.AstTreeTopNode;

            // PrettyPrinter PP = new PrettyPrinter();
            // p.Accept(PP);
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            p.Accept(ST);
            errors.AddRange(ST.GetErrors());
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            p.Accept(TT);
            errors.AddRange(TT.GetErrors());

            // GetDeclaredValueVisitor GV = new GetDeclaredValueVisitor(TT.GetSymbolTable());
            // p.Accept(GV);
            // errors.AddRange(GV.GetErrors());
            //
            // PrintsymboltableAddress PA = new PrintsymboltableAddress();
            // p.Accept(PA);
            // // var symboltable = GV.GetSymbolTable();
            symbolTable = TT.GetSymbolTable();

            if (errors.Count == 0)
            {
                runProgramVisitor run = new runProgramVisitor();
                p.Accept(run);

                LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(symbolTable,errors);
                p.Accept(loopUnfolder);

                ExpressionReducerVisitor reducer = new ExpressionReducerVisitor(symbolTable, errors);
                CodeGeneratorVisitor gCodeGeneratorVisitor = new CodeGeneratorVisitor(symbolTable, errors, reducer );
                p.Accept(gCodeGeneratorVisitor);
                string gcode = gCodeGeneratorVisitor.Emit();
                Console.WriteLine(gcode);
                //File.WriteAllText("testFile.gcode",gcode);
            }
            else
            {
                foreach (var item in errors)
                {
                    Console.Write("\n" + item + "\n");
                }

            }


            
            
            Console.WriteLine("\n\n-----FIX the following ERRORS!----- :\n");
           
            Console.WriteLine("\n---Errors in Parser AstBuilder---");
            foreach (var error in builder.SemanticErrors)
            {
                Console.WriteLine(error);
            }
            Console.WriteLine("\n---Errors found in Declarations by Symboltable Creater---");
            foreach (var item in ST.GetErrors())
            {
                Console.Write("\n" + item + "\n");
            }
            
            Console.WriteLine("\n---Errors found in Applied Occurrences and typeChecking by Typechecker---");
            foreach (var item in ST.GetErrors())
            {
                Console.Write("\n" + item + "\n");
            }
            
            // Console.WriteLine("\n---Errors found in Applied Occurrences and typeChecking by Typechecker---");
            // foreach (var item in ST.GetErrors())
            // {
            //     Console.Write("\n" + item + "\n");
            // }
            
            Console.WriteLine("\n\n---The SYMBOLTABLE contains:---\n");
            foreach (var item in symbolTable)
            {
                Console.WriteLine(item);
            }
        }
    }
}