using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace OG.Compiler
{
    /// <summary>
    /// The class which contains the Lexer and all objects intermediate to create said lexer.
    /// The Lexer is responsible for securing the source file is grammatically valid.
    /// </summary>
    public class LexerContainer
    {
        public ICharStream CharStream { get; set; }
        public ITokenSource TokenSource { get; set; }
        public LexerContainer(string program)
        {
            CharStream = new AntlrInputStream(program);
            TokenSource = new OGLexer(CharStream);
        }
    }
}