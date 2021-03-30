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
    public class Lexer
    {
        public static ITokenStream CreateTokenStream(string program)
        {
            ICharStream charStream = new AntlrInputStream(program);
            ITokenSource lexer = new OGLexer(charStream);
            return new CommonTokenStream(lexer);
        }
    }
}