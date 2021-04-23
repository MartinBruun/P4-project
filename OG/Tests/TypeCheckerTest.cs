using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.AstVisiting.Visitors;
using OG.Compiler;

namespace Tests
{
    public class TypeCheckerTest
    {
        /// <summary>
        /// Creates the Parser used for all the tests in this file.
        /// </summary>
        /// <param name="fileName">The name of the fixture being used</param>
        /// <param name="dirName">The name of the directory the fixture is in</param>
        /// <returns></returns>
        private OGParser CreateParser(string fileName, string dirName)
        {
            Dictionary<string, string> symbolTable = new Dictionary<string, string>();

            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            OGParser parser = parCon.Parser;
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
       // [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("base_function.og", "Testing the base case for declaring a function")]
        [TestCase("base_shape.og", "Testing the base case for declaring a shape")]
        [TestCase("boolExpressions.og", "Testing declaration and use of bool expressions")]
        [TestCase("draw.og", "Testing if Draw can contain previously declared and defined shapes")]
        [TestCase("math.og", "Testing mathematical expressions are ok")]
        [TestCase("mathAddition.og", "Testing a file with additive math expressions")]
        [TestCase("mathMultiplication.og", "Testing a file with multiplicative math expressions")]
        [TestCase("while.og", "testing while loops")]
        [TestCase("MultibleRepeatLoopsInFunction.og", "testing Repeat loops in function")]
        [TestCase("MultibleRepeatLoopsInShape.og", "testing Repeat loops in shape")]
        [TestCase("NestedRepeatLoopsInFunction.og", "testing nested Repeat loops in function")]
        [TestCase("NestedRepeatLoopsInShape.og", "testing nested Repeat loops in shape")]

        
        public void Test_Fixtures_ShouldNotFindAnyTypeMismatches(string fileName, string description)
        {
            OGParser parser = CreateParser(fileName, "Correct programs/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));

            ProgramNode p = astContainer.AstTreeTopNode;
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            p.Accept(ST);
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            p.Accept(TT);
            
            var symboltable = TT.GetSymbolTable();
            var errors = TT.GetErrors();
            
            Console.WriteLine("\n---Type Errors---");
            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\n-----Contents of symboltable-----");
            foreach (var item in symboltable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Assert.AreEqual(0,errors.Count,
             description);
        }
        
        
        // [TestCase("ShapeDoubleDeclarations.og",2, "testing that two shapes of the same name are discovered")]
        // [TestCase("FunctionDoubleDeclarations.og",1, "testing that two Functions of the same name are discovered")]
        // [TestCase("VariableDoubleDeclarations.og",6, "testing that two Variables of the same name are discovered")]
        [TestCase("boolToNumber.og",6, "testing that a boolian can not be assigned to a number variable")]

        public void Test_Fixtures_ShouldFindTypeMismatch(string fileName,int errorCount, string description)
        {
            OGParser parser = CreateParser(fileName, "Incorrect programs/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));

            ProgramNode p = astContainer.AstTreeTopNode;
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();

            p.Accept(ST);
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            p.Accept(TT);
            
            var symboltable = TT.GetSymbolTable();
            var errors = TT.GetErrors();
            
            
            Console.WriteLine("\n---Type mismatch ERRORS---");
            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\n-----Contents of symboltable-----");
            foreach (var item in symboltable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            
            Assert.AreEqual(errorCount,errors.Count,
                description);
        }
        
    }
}