using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using GPlusPlusCompiler;

namespace Tests
{
    public class LexerExceptionHelper : Exception
    {
        public LexerExceptionHelper(string msg) : base(msg)
        {
        }

        public LexerExceptionHelper() : base("Syntax error in lexer without Custom Message")
        {
            
        }
    }
    public class ErrorListenerHelper: IAntlrErrorListener<int>
    {
        public ErrorListenerHelper()
        {
            
        }
        
        public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new LexerExceptionHelper($"{msg}.\n Line {line} and column {charPositionInLine}");
            Console.WriteLine("Error in Lexer at line:" );
        }
    }
}