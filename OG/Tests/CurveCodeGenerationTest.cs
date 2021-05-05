using System;
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

        Regex G02Regex = new Regex(@"^G01 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+$");
        
        [TestCase(45, -0.000001, -0.000001, 999999.9999,9999999.9999)]

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
                
            });

            
         
        }
    }
}