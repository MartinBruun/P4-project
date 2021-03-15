using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using GPlusPlusCompiler;

namespace Tests
{
    public class ErrorListenerHelper<T>: IAntlrErrorListener<T>
    {
        public ErrorListenerHelper()
        {
            
        }
        
        public void SyntaxError(TextWriter output, IRecognizer recognizer, T offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new LexerExceptionHelper($"{msg}.\n Line {line} and column {charPositionInLine}");
        }
        public void ReportAmbiguity(TextWriter output, IRecognizer recognizer, T offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new ParserExceptionHelper($"{msg}.\n Line {line} and column {charPositionInLine}");
        }
    }
    
    public class LexerExceptionHelper : Exception
    {
        public LexerExceptionHelper(string msg) : base(msg)
        {
        }

        public LexerExceptionHelper() : base("Syntax error in lexer without Custom Message")
        {
            
        }
    }
    
    public class ParserExceptionHelper : Exception
    {
        public ParserExceptionHelper(string msg) : base(msg)
        {
        }

        public ParserExceptionHelper() : base("Syntax error in parser without Custom Message")
        {
            
        }
    }
}