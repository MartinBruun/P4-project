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
            OGLexer lexer = new OGLexer(stream);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();
            OGParser parser = new OGParser(tokenStream);
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser.program();
        }

        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("boolExpressions.og", "Testing declaration and use of bool expressions")]
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
