using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace OG
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            
            const string program = @"Machine.WorkArea.size(xmin=0,xmax=100,ymin=0,ymax=100);

draw {
    
}";
            ICharStream charStream = new AntlrInputStream(program);
            ITokenSource lexer = new OGLexer(charStream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            OGParser parser = new OGParser(tokens);
            IParseTree tree = parser.program();
            Console.WriteLine(tree.ToStringTree());
            
        }
    }
}
