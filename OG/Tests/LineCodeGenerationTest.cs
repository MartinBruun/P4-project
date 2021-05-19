using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public class LineCodeGenerationTest
    {
        private static Regex G00Regex { get; } = new Regex(@"^G00 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+$");
        private static Regex G01Regex { get; } = new Regex(@"^G01 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+$");
        
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
        [TestCase(1, 1, 1,1)]
        [TestCase(-1, -1, -1,-1)]

        public void Point_Tuples_Should_Give_Equivalent_XY_Value_SingleTo(double x1, double y1, double x2, double y2)
        {
            LineCommandNode lineCommand = SetupLineNode(x1, y1);
            LineEmitter emitter = SetupLineEmitter(lineCommand);
            List<string> result = new List<string>();

            Assert.DoesNotThrow(() =>
            {
                emitter.SetupGCodeResult(lineCommand);
                result = emitter.Emit().Split('\n').ToList();
            });

            
            result.RemoveAll(string.IsNullOrWhiteSpace);
            result.ForEach(str =>
            {
                Assert.IsTrue(G01Regex.IsMatch(str) || G00Regex.IsMatch(str));
            });

        }
        
        [TestCase(-0.000001, -0.000001)]
        [TestCase(-0.01, -0.01)]
        [TestCase(-0, -1000)]
        [TestCase(-1000, 0)]
        [TestCase(-1000, -1000)]
        [TestCase(1000, -1000)]
        [TestCase(0, 0)]
        [TestCase(0.0, 0.2)]
        [TestCase(10, 10.10)]
        [TestCase(1, 1)]
        [TestCase(99999, 99999)]
        [TestCase(99999, 99999)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        public void Point_Tuples_Should_Give_Equivalent_XY_Value_Using_To_Chaining(double x1, double y1)
        {
            LineCommandNode lineCommand = SetupLineNode(x1, y1);
            LineEmitter emitter = SetupLineEmitter(lineCommand);
            
            List<string> result = new List<string>();
            Assert.DoesNotThrow(() =>
            {
                result = emitter.Emit().Split('\n').ToList();
            });

            
            result.RemoveAll(string.IsNullOrWhiteSpace);
            result.ForEach(str =>
            {
                Assert.IsTrue(G01Regex.IsMatch(str) || G00Regex.IsMatch(str));
            });
        }

        public LineEmitter SetupLineEmitter(LineCommandNode node)
        {
            LineEmitter emitter = new LineEmitter(new List<SemanticError>());
            emitter.SetupGCodeResult(node);
            return emitter;
        }

        public LineCommandNode SetupLineNode(double x1, double y1)
        {
            NumberNode x1Val = new NumberNode(x1);
            NumberNode y1Val = new NumberNode(y1);
            NumberNode x2Val = new NumberNode(x1 + 5);
            NumberNode y2Val = new NumberNode(y1 + 5);
            
            
            List<TuplePointNode> tupleNodes = new List<TuplePointNode>();

            for (int n = 0; n < 20; n++)
            {
                tupleNodes.Add(n % 2 == 0
                    ? new TuplePointNode("", new NumberNode(n + 1), new NumberNode(-n - 1))
                    : new TuplePointNode("", new NumberNode(n - 1), new NumberNode(-n + 1)));
            }

            
            List<PointReferenceNode> toCommands = new List<PointReferenceNode>();
            toCommands.AddRange(tupleNodes);
            return new LineCommandNode(new TuplePointNode("", x1Val, y1Val), toCommands);
        }
 
    }
}