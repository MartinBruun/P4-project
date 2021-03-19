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
            OGLexer lexer = new OGLexer(stream);
            ErrorListenerHelper<int> listener = new ErrorListenerHelper<int>();
            lexer.AddErrorListener(listener);
            return new CommonTokenStream(lexer);
        }
        
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("boolExpressions.og", "Testing declaration and use of bool expressions")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
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