using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr4.Runtime;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.CodeGeneration;
using OG.Compiler;

namespace Tests
{
    public class CodeGenerationTest
    {
        private OGParser CreateParser(string fileName, string dirName)
        {
            Dictionary<string, string> symbolTable = new Dictionary<string, string>();

            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            OGParser parser = parCon.Parser;
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser;
        }


        [TestCase(-0.000001, -0.000001, 999999.9999,9999999.9999)]
        [TestCase(-0.01, -0.01, 0.01,0.001)]
        [TestCase(-0, -1000, 0, 0)]
        [TestCase(-1000, 0,1,0)]
        [TestCase(-1000, -1000,1,0)]
        [TestCase(1000, -1000,100,100)]
        [TestCase(0, 0,99,99)]
        [TestCase(0.0, 0.2, 999,9999)]
        [TestCase(10, 10.10, 5,5)]
        [TestCase(1, 1,0001, 1)]
        [TestCase(99999, 99999, 0,0)]
        [TestCase(99999, 99999, 0,0)]
        [TestCase(0, 0, 0,0)]

        public async Task Point_Tuples_Should_Give_Equivalent_XY_Value_SingleTo(double x1, double y1, double x2, double y2)
        {
            NumberNode x1Val = new NumberNode(x1);
            NumberNode y1Val = new NumberNode(y2);
            
            NumberNode x2Val = new NumberNode(x2);
            NumberNode y2Val = new NumberNode(y2);
            List<PointReferenceNode> ToCommands = new List<PointReferenceNode>();
            ToCommands.Add(new TuplePointNode("", x2Val, y2Val));

            
            LineEmitterVisitor emitter = new LineEmitterVisitor(null, new List<SemanticError>());
            LineCommandNode lineCommand = new LineCommandNode(new TuplePointNode("",x1Val, y1Val), ToCommands);
            
            lineCommand.Accept(emitter);
            emitter.CodeGenerationNotification += (Console.WriteLine);
            
            
            await File.WriteAllTextAsync("WriteText.txt", emitter.Emit());

        }
    }
}