using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using GPlusPlusCompiler;

namespace Tests

{


    public class LexerException : Exception
    {
        public LexerException(string msg) : base(msg)
        {
        }

        public LexerException() : base("Syntax error in lexer without Custom Message")
        {
            
        }
    }
    public class BErrorListener: IAntlrErrorListener<int>
    {
        public BErrorListener()
        {
            
        }
        
        public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new LexerException("syntaxError in Lexer");
            Console.WriteLine("Error in Lexer at line:" );
        }
    }
    
    
    
    public class LexerTests
    {
        private CommonTokenStream CreateTokenStream(string fileName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + fileName);
            ICharStream stream = new AntlrInputStream(code);
            var lexer = new OGLexer(stream);
            BErrorListener listener = new BErrorListener();
            lexer.AddErrorListener(listener);
            return new CommonTokenStream(lexer);
        }

        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        public void Test_Lexer_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            CommonTokenStream tokenStream = CreateTokenStream(fileName);

            Assert.DoesNotThrow(() =>
           {
               tokenStream.Fill();
           }, description);
        }
    }
}