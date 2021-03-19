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
        private IParseTree CreateTree(string fileName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + fileName);
            ICharStream stream = new AntlrInputStream(code);
            var lexer = new OGLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();
            OGParser parser = new OGParser(tokenStream);
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser.program();
        }

        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("base_function.og", "Testing the base case for declaring a function")]
        [TestCase("base_shape.og", "Testing the base case for declaring a shape")]
        [TestCase("nested_shape.og", "Testing that shapes can be nested inside themselves")]
        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            IParseTree tree = CreateTree(fileName);

            Assert.DoesNotThrow(() =>
            {
                tree.ToStringTree();
            }, description);
        }
    }
}
