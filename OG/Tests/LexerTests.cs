using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using OG;

namespace Tests

{
    public class LexerTests
    {
        private CommonTokenStream CreateTokenStream(string fileName, string dirName)
        {
            string code = File.ReadAllText("../../../Fixtures/" +dirName + fileName);

            ICharStream stream = new AntlrInputStream(code);
            OGLexer lexer = new OGLexer(stream);
            ErrorListenerHelper<int> listener = new ErrorListenerHelper<int>();
            lexer.AddErrorListener(listener);
            return new CommonTokenStream(lexer);
        }
        
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("boolExpressions.og", "Testing declaration and use of bool expressions")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("base_function.og", "Testing the base case for declaring a function")]
        [TestCase("base_shape.og", "Testing the base case for declaring a shape")]
        [TestCase("draw.og", "Testing if Draw can contain previously declared and defined shapes")]
        [TestCase("math.og", "Testing mathematical expressions are ok")]
        [TestCase("mathAddition.og", "Testing a file with additive math expressions")]
        [TestCase("mathMultiplication.og", "Testing a file with multiplicative math expressions")]
        [TestCase("while.og", "testing while loops")]
        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            CommonTokenStream tokenStream = CreateTokenStream(fileName, "Correct programs/");

            Assert.DoesNotThrow(() =>
            {
                tokenStream.Fill();
            }, description);
        }
        
        public void Test_Fixtures_ShouldRaiseSyntaxExceptions(string fileName, string description)
        {
            CommonTokenStream tokenStream = CreateTokenStream(fileName, "Incorrect programs/");

            Assert.Throws<SyntaxException>(() =>
            {
                tokenStream.Fill();
            }, description);
        }
    }
}