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
        [TestCase("base_function.og", "Testing the base case for declaring a function")]
        [TestCase("base_shape.og", "Testing the base case for declaring a shape")]
        [TestCase("nested_shape.og", "Testing that shapes can be nested inside themselves")]
        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            CommonTokenStream tokenStream = CreateTokenStream(fileName);

            Assert.DoesNotThrow(() =>
            {
                tokenStream.Fill();
            }, description);
        }
        
        [TestCase("Errors/forbidden_signs.og", "Testing that the signs specified should give a lexical error")]
        public void Test_Fixtures_ShouldRaiseSyntaxExceptions(string fileName, string description)
        {
            CommonTokenStream tokenStream = CreateTokenStream(fileName);

            Assert.Throws<LexerExceptionHelper>(() =>
            {
                tokenStream.Fill();
            }, description);
        }
    }
}