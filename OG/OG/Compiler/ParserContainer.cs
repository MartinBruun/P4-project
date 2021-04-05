using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace OG.Compiler
{
    /// <summary>
    /// The class which contains the Parser and all objects intermediate from the Lexer to the Parser.
    /// The Parser is responsible for the syntactical analysis of the source file.
    /// </summary>
    public class ParserContainer
    {
        public ITokenSource TokenSource { get; set; }
        public ITokenStream TokenStream { get; set; }
        public OGParser OGParser { get; set; }
        public ParserContainer(ITokenSource tokenSource)
        {
            TokenSource = tokenSource;
            TokenStream = new CommonTokenStream(TokenSource);
            OGParser = new OGParser(TokenStream);
        }
    }
}