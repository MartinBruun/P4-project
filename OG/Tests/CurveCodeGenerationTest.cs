﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using OG.CodeGeneration;

namespace Tests
{
    public class CurveCodeGenerationTest
    {
        private static Regex LineRegex { get; } = new Regex(@"^G01 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+$");
        private static Regex ArcRegex { get; } = new Regex(@"^(G02|G03) X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+ R-?\d*\.{0,1}\d+$");
        private static Regex G02Regex { get; } = new Regex(@"^G02 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+ R-?\d*\.{0,1}\d+$");
        private static Regex G03Regex { get; } = new Regex(@"^G03 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+ R-?\d*\.{0,1}\d+$");
        
        
        [TestCase(45, -0.000001, -0.000001, 999999.9999,9999999.9999)]
        [TestCase(-45,-0.01, -0.01, 0.01,0.001)]
        [TestCase(-1,-0, -1000, 0, 0)]
        [TestCase(1, -1000, 0,1,0)]
        [TestCase(10, -1000, -1000,1,0)]
        [TestCase(-10,1000, -1000,100,100)]
        [TestCase(89.999,0, 0,99,99)]
        [TestCase(-89.999,10, 10.10, 5,5)]
        [TestCase(-0.999,0.0, 0.2, 999,9999)]
        [TestCase(0.999,1, 1,0001, 1)]
        public void Curve_Should_Match_RegexForG02Or (double angle, double x1, double y1, double x2, double y2)
        {
            NumberNode angleNode = new NumberNode(angle);
            TuplePointNode fromNode = new TuplePointNode("", new NumberNode(x1), new NumberNode(y2));
            List<PointReferenceNode> toNode = new List<PointReferenceNode>();
            toNode.Add(new TuplePointNode("", new NumberNode(x2), new NumberNode(y2)));
            
            CurveCommandNode curveNode = new CurveCommandNode(fromNode, toNode, angleNode);
            CurveEmitterVisitor curveEmitter = new CurveEmitterVisitor(new SymbolTable(), new List<SemanticError>());
            Assert.DoesNotThrow(() =>
            {
                curveNode.Accept(curveEmitter);
                Assert.IsTrue(curveEmitter.SemanticErrors.Count == 0);
            });

            string result = curveEmitter.Emit();
            Assert.IsTrue(ArcRegex.IsMatch(result));
        }
    }
}