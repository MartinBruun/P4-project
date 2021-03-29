using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        private Dictionary<string, MachineSettingNode> CreateMachineSettings(string fileName, string dirName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            ICharStream stream = new AntlrInputStream(code);
            OGLexer lexer = new OGLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();
            OGParser parser = new OGParser(tokenStream);
            IParseTree tree = parser.machineStns(); // TODO!!!! Change to parser.program()!!!
            Dictionary<string, MachineSettingNode> machineSettingNodes = new MachineSettingVisitor().Visit(tree);
            return machineSettingNodes;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        public void Test_Fixtures_ShouldGiveCorrectAST(string fileName, string description)
        {
            Dictionary<string, MachineSettingNode> machineSettings = CreateMachineSettings(fileName, "Correct programs/");
            WorkAreaModificationNode node = (WorkAreaModificationNode) machineSettings["WorkArea"];

            Assert.AreEqual(0, node.SizeProperty.XMin.Value);
            Assert.AreEqual(100, node.SizeProperty.XMax.Value);
            Assert.AreEqual(0, node.SizeProperty.YMin.Value);
            Assert.AreEqual(100, node.SizeProperty.YMax.Value);
            Assert.AreEqual(0, node.SizeProperty.ZMin.Value);
            Assert.AreEqual(100, node.SizeProperty.ZMax.Value);
        }
    }
}