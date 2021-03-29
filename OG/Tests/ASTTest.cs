using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using OG;
using OG.AST;
using OG.AST.MachineSettings;
using OG.AST.Terminals;

namespace Tests
{
    public class ASTTests
    {
        private ASTNode CreateAST(string fileName, string dirName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            ICharStream stream = new AntlrInputStream(code);
            OGLexer lexer = new OGLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();
            OGParser parser = new OGParser(tokenStream);
            IParseTree tree = parser.machineStns(); // TODO!!!! Change to parser.program()!!!
            ASTNode machineSettingNodes = new MachineSettingVisitor().Visit(tree);
            return machineSettingNodes;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            ASTNode ast = CreateAST(fileName, "Correct programs/");
            MachineNode node = (MachineNode) ast;
            
            Console.WriteLine(node.WorkArea.SizeProperty.XMin);
            Console.WriteLine(new NumberNode<int>(0));
            
            Assert.AreEqual(0, node.WorkArea.SizeProperty.XMin.Value);
            Assert.AreEqual(100, node.WorkArea.SizeProperty.XMax.Value);
            Assert.AreEqual(0, node.WorkArea.SizeProperty.YMin.Value);
            Assert.AreEqual(100, node.WorkArea.SizeProperty.YMax.Value);
            Assert.AreEqual(0, node.WorkArea.SizeProperty.ZMin.Value);
            Assert.AreEqual(100, node.WorkArea.SizeProperty.ZMax.Value);
        }
    }
}