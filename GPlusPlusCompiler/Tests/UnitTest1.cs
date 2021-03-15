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
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BaseTest()
        {
            //Arr Load file 
            string code = @" Machine.WorkArea.size(0,0,100,100);
                           
            Draw {
                               
            }";
    
            ICharStream stream = new AntlrInputStream(code);
            var lexer = new OGLexer(stream);
            BErrorListener listener = new BErrorListener();
            lexer.AddErrorListener(listener);
            var tokenStream = new CommonTokenStream(lexer);
            
            //Act Brug parseren til at parse filen
            
            
            
            //Assert ingen syntaks fejl
            
           Assert.DoesNotThrow(() =>
           {
               tokenStream.Fill();
           });
        }
    }
}