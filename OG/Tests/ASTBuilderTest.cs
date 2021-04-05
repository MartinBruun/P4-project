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
using OG.Compiler;

namespace Tests
{
    public class AstBuilderTests
    {
        private TNode CreateAST<TNode, TVisitor>(string fileName, string dirName) 
            where TVisitor : OGBaseVisitor<TNode>, ISemanticErrorable, IUnnecessarySettingsErrorable, new()
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);

            ASTBuilder<TVisitor, TNode> astBuilder = new ASTBuilder<TVisitor, TNode>(parCon.OGParser);
            
            return astBuilder.AST;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        public void Test_Fixtures_ShouldGiveCorrectAST(string fileName, string description)
        {
            ProgramNode program = CreateAST<ProgramNode, AstBuilderVisitor>(fileName, "Correct programs/");
            WorkAreaSettingNode node = (WorkAreaSettingNode) program.MachineSettings["WorkArea"];

            Assert.AreEqual(0, node.SizeProperty.XMin.Value);
            Assert.AreEqual(100, node.SizeProperty.XMax.Value);
            Assert.AreEqual(0, node.SizeProperty.YMin.Value);
            Assert.AreEqual(100, node.SizeProperty.YMax.Value);
            Assert.AreEqual(0, node.SizeProperty.ZMin.Value);
            Assert.AreEqual(100, node.SizeProperty.ZMax.Value);
        }
            
        [TestCase("base.og", "Testing that it is possible to choose the visitor the TypeChecker uses")]
        public void Test_MachineSettings_ShouldGiveCorrectAST(string fileName, string description)
        {
            TestContext.Out.WriteLine("TestStarting");
            Dictionary<string,MachineSettingNode> machineSettings = CreateAST<Dictionary<string,MachineSettingNode>, MachineSettingsVisitor>(fileName, "Correct programs/");
            TestContext.Out.WriteLine(machineSettings);
            WorkAreaSettingNode node = (WorkAreaSettingNode) machineSettings["WorkArea"];

            Assert.AreEqual(0, node.SizeProperty.XMin.Value);
            Assert.AreEqual(100, node.SizeProperty.XMax.Value);
            Assert.AreEqual(0, node.SizeProperty.YMin.Value);
            Assert.AreEqual(100, node.SizeProperty.YMax.Value);
            Assert.AreEqual(0, node.SizeProperty.ZMin.Value);
            Assert.AreEqual(100, node.SizeProperty.ZMax.Value);
        }
    }
}