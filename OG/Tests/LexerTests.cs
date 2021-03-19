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
        private CommonTokenStream CreateTokenStream(string fileName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + fileName);
            ICharStream stream = new AntlrInputStream(code);
            var lexer = new OGLexer(stream);
            ErrorListenerHelper<int> listener = new ErrorListenerHelper<int>();
            lexer.AddErrorListener(listener);
            return new CommonTokenStream(lexer);
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("mathAddition.og", "Testing a file with additive math expressions")]
        [TestCase("mathMultiplication.og", "Testing a file with multiplicative math expressions")]
        [TestCase("while.og", "testing while loops")]
        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            CommonTokenStream tokenStream = CreateTokenStream(fileName);

            Assert.DoesNotThrow(() =>
            {
                tokenStream.Fill();
            }, description);
        }
    }
}