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
    public class ASTTests
    {
        private Node CreateAST<Node, Visitor>(string fileName, string dirName, string ruleBeingTested) 
            where Visitor : OGBaseVisitor<Node>, ISemanticErrorable, new()
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            TypeChecker<Node,Visitor> typeChecker = new TypeChecker<Node,Visitor>(parCon.OGParser, ruleBeingTested);
            return typeChecker.AST;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        public void Test_Fixtures_ShouldGiveCorrectAST(string fileName, string description)
        {
            OGProgramAST program = CreateAST<OGProgramAST, AntlrToProgramAST>(fileName, "Correct programs/", "program");
            WorkAreaModificationNode node = (WorkAreaModificationNode) program.MachineSettings["WorkArea"];

            Assert.AreEqual(0, node.SizeProperty.XMin.Value);
            Assert.AreEqual(100, node.SizeProperty.XMax.Value);
            Assert.AreEqual(0, node.SizeProperty.YMin.Value);
            Assert.AreEqual(100, node.SizeProperty.YMax.Value);
            Assert.AreEqual(0, node.SizeProperty.ZMin.Value);
            Assert.AreEqual(100, node.SizeProperty.ZMax.Value);
        }
    }
}