using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.AstVisiting.Visitors;
using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using OG;
using OG.Compiler;

namespace Tests

{
    public class SymboltableCreatorTest
    {
        /// <summary>
        /// Creates the Parser used for all the tests in this file.
        /// </summary>
        /// <param name="fileName">The name of the fixture being used</param>
        /// <param name="dirName">The name of the directory the fixture is in</param>
        /// <returns></returns>
        private OGParser CreateParser(string fileName, string dirName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            OGParser parser = parCon.Parser;
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
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
        [TestCase("DrawCurves.og", "Draw curves")]
        

        
        public void Test_Fixtures_ShouldNotFindAnyDoubleDeclarations(string fileName, string description)
        {
            OGParser parser = CreateParser(fileName, "Correct programs/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));

            ProgramNode p = astContainer.AstTreeTopNode;
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();

            p.Accept(ST);
            var symboltable = ST.GetSymbolTable();
            var errors = ST.GetErrors();
            
            Console.WriteLine("\n-----Contents of symboltable-----");
            foreach (var item in symboltable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            
            Console.WriteLine("\n---Bad declarations---");
            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }
            
            Assert.AreEqual(0,errors.Count,
             description);
        }
        
       
        [TestCase("Correct programs/FunctionDeclParameters.og",5, "testing that two parameters are discovered and stored in symboltable")]
        [TestCase("Incorrect programs/boolToNumber.og", 8,"Check Boolian should create 6 elements in symboltable")]
        [TestCase("Incorrect programs/FunctionCallAssignTypeMisMatch.og",12, "testing that this can be created in symboltable: a boolian function can not be assigned to a number variable and numberFunction to a boolian variable")]
        [TestCase("Incorrect programs/UndeclaredEndPointRefference.og",4, "testing that this can be created in symboltable:a value  can not be assigned to a xy value on an undeclared pointrefference")]


        public void Test_Fixtures_ShouldCreateElementsInSymbolTable(string fileName,int elementCount, string description)
        {
            OGParser parser = CreateParser(fileName, "");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));

            ProgramNode p = astContainer.AstTreeTopNode;
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();

            p.Accept(ST);
            var symboltable = ST.GetSymbolTable();
            var errors = ST.GetErrors();
            
            Console.WriteLine("\n-----Contents of symboltable-----");
            foreach (var item in symboltable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            
            Console.WriteLine("\n---Bad declarations---");
            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }
            
            Assert.AreEqual(elementCount,symboltable.Count,
                description);
        }
        
        
        [TestCase("ShapeDoubleDeclarations.og",2, "testing that two shapes of the same name are discovered")]
        [TestCase("FunctionDoubleDeclarations.og",1, "testing that two Functions of the same name are discovered")]
        [TestCase("VariableDoubleDeclarations.og",9, "testing that two Variables of the same name are discovered")]
        
        public void Test_Fixtures_ShouldFindDoubleDeclarations(string fileName,int errorCount, string description)
        {
            OGParser parser = CreateParser(fileName, "Incorrect programs/DoubleDeclarationErrors/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));

            ProgramNode p = astContainer.AstTreeTopNode;
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();

            p.Accept(ST);
            var symboltable = ST.GetSymbolTable();
            var errors = ST.GetErrors();
            
            Console.WriteLine("\n-----Contents of symboltable-----");
            foreach (var item in symboltable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            
            Console.WriteLine("\n---Bad declarations---");
            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }
            
            Assert.AreEqual(errorCount,errors.Count,
                description);
        }
        
        
    }
}

    
