using System;
using System.IO;
using Antlr4.Runtime;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.AstVisiting.Visitors;
using OG.Compiler;

namespace Tests.Fixtures
{
    public class PrettyPrinterTest
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
        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            OGParser parser = CreateParser(fileName, "Correct programs/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));

            ProgramNode p = astContainer.AstTreeTopNode;
            PrettyPrinter ST = new PrettyPrinter();

            p.Accept(ST);
            Assert.True(true);

        }
        
    }
}