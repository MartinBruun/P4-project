using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace OG.Compiler
{
    /// <summary>
    /// The class responsible for converting the CharStream into a ParseTree using Antlr4.
    /// Is responsible for the syntactical analysis of the source file.
    /// </summary>
    public class ParserContainer
    {
        public ITokenSource TokenSource { get; set; }
        public ITokenStream TokenStream { get; set; }
        public OGParser OGParser { get; set; }
        public ParserContainer(LexerContainer lexer)
        {
            TokenSource = lexer.TokenSource;
            TokenStream = new CommonTokenStream(TokenSource);
            OGParser = new OGParser(TokenStream);
        }
    }
}