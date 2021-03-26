using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using OG;

namespace Tests

{
    public class ParserTests
    {
        private OGParser CreateParser(string fileName, string dirName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            ICharStream stream = new AntlrInputStream(code);
            OGLexer lexer = new OGLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();
            OGParser parser = new OGParser(tokenStream);
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

            Assert.DoesNotThrow(() =>
            {
                IParseTree tree = parser.program();
            }, description);
        }
        
        [TestCase("nested_shape.og", "Testing that nested shapes are not valid")]
        public void Test_Fixtures_ShouldRaiseSyntaxExceptions(string fileName, string description)
        {
            OGParser parser = CreateParser(fileName, "Incorrect programs/");

            Assert.Throws<SyntaxException>(() =>
            {
                IParseTree tree = parser.program();
            }, description);
        }
    }
}
