using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace OG.Compiler
{
    /// <summary>
    /// The class responsible for converting a file into a CharStream, which is fed to the Parser.
    /// Is responsible for securing the source file is grammatically valid.
    /// </summary>
    public class LexerContainer
    {
        public ICharStream CharStream { get; set; }
        public ITokenSource TokenSource { get; set; }
        public OGLexer OGLexer { get; set; }
        public LexerContainer(string program)
        {
            CharStream = new AntlrInputStream(program);
            TokenSource = new OGLexer(CharStream);
            OGLexer = new OGLexer(CharStream);
        }
    }
}