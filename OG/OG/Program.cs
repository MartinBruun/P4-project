using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.AST;
using OG.AST.MachineSettings;

namespace OG
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            const string program = "Machine.WorkArea.size(xmin=0,xmax=80,ymin=0,ymax=80);";
            ICharStream charStream = new AntlrInputStream(program);
            ITokenSource lexer = new OGLexer(charStream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            OGParser parser = new OGParser(tokens);
            IParseTree tree = parser.machineStns();
            Dictionary<string, MachineSettingNode> machineSettingNodes = new MachineSettingVisitor().Visit(tree);
            
            Console.WriteLine(machineSettingNodes["WorkArea"]);

        }
    }
}
