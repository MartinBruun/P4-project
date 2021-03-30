using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using OG.gen;

using OG.AST;
using OG.AST.MachineSettings;

namespace OG
{
    public static class Program
    {
        private static void Main(string[] args)
        {

            const string program = @"

Machine.WorkArea.size(xmin=0,xmax=10,ymin=0,ymax=222);

draw {
    a;
    b.from(1,1);
}

function void funA(){}
function point funPOINT(){ point a = (2,2);return a;}

shape shapeA{}
shape shapeB{}

";
            ICharStream charStream = new AntlrInputStream(program);
            ITokenSource lexer = new OGLexer(charStream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            OGParser parser = new OGParser(tokens);
            IParseTree tree = parser.program();
            Console.WriteLine(tree.ToStringTree());
            AntlrToProgramAST visitor = new AntlrToProgramAST();
            
            visitor.Visit(tree);
            if (visitor.SemanticErrors != null)
            {
                Console.WriteLine("\nSEMANTIC ERRORS DETECTED");
                foreach (var e in visitor.SemanticErrors)
                {
                    Console.WriteLine("\n" + e.Msg + " in \nline:" + e.Line + "\ncolumn :" + e.Column);
                }
                
            // Dictionary<string, MachineSettingNode> machineSettingNodes = new MachineSettingVisitor().Visit(tree);
            //
            // Console.WriteLine(machineSettingNodes["WorkArea"]);

        }

    }
    }
}
