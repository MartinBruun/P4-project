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
    public class Parser
    {
        public static OGParser CreateParser(string program)
        {
            ITokenSource lexer = Lexer.CreateLexer(program);
            ITokenStream tokens = new CommonTokenStream(lexer);
            return new OGParser(tokens);
        }
    }
}