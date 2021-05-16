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
        private static Regex ArcRegex { get; } = new Regex(@"^(G02|G03) X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+ R-?\d*\.{0,1}\d+$");
        private static Regex G02Regex { get; } = new Regex(@"^G02 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+ R-?\d*\.{0,1}\d+$");
        private static Regex G03Regex { get; } = new Regex(@"^G03 X-?\d*\.{0,1}\d+ Y-?\d*\.{0,1}\d+ R-?\d*\.{0,1}\d+$");

        [TestCase(45, -0.0001, -0.0001, 999999.9999,9999999.9999)]
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
            //Arrange
            CurveCommandNode curveNode = CreateCurveNode(angle,  x1,  y1,  x2,  y2);
            CurveEmitter curveEmitter = SetupEmitter(curveNode);
            
            //Act and Assert
            Assert.DoesNotThrow(() =>
            {
                Assert.IsTrue(curveEmitter.SemanticErrors.Count == 0);
            });

            List<string> gCodeCommands = curveEmitter.Emit().Split("\n").ToList();
            gCodeCommands.RemoveAt(gCodeCommands.Count - 1); // Remove the empty string from the split operation.

            Assert.AreEqual(2, gCodeCommands.Count);
            Assert.AreEqual($"G00 X{x1} Y{y1}",gCodeCommands.First());
            Assert.IsTrue(ArcRegex.IsMatch(gCodeCommands.Last()));
        }

       


        [TestCase(0, -0.0001, -0.0001, 999999.9999,9999999.9999)]
        [TestCase(0, -1000, 0,1,0)]
        [TestCase(0, -1000, -1000,1,0)]
        [TestCase(0,1000, -1000,100,100)]
        [TestCase(-0,0, 0,99,99)]
        [TestCase(-0,10, 10.10, 5,5)]
        [TestCase(-0,0.0, 0.2, 999,9999)]
        public void Curve_With_Angle_Zero_Matches_Line_Regex(double angle, double x1, double y1, double x2, double y2)
        {
            
            //Arrange
            CurveCommandNode curveNode = CreateCurveNode(angle,  x1,  y1,  x2,  y2);
            CurveEmitter curveEmitter = SetupEmitter(curveNode);
            
            //Act and Assert
            List<string> resultCommand = curveEmitter.Emit().Split("\n").ToList();
            resultCommand.RemoveAt(resultCommand.Count - 1); // Remove the empty string from the split operation.
            
            Assert.AreEqual($"G00 X{x1} Y{y1}",resultCommand.First());
            Assert.AreEqual($"G01 X{x2} Y{y2}",resultCommand.Last());
        }
        

        [TestCase(-45,-0.01, -0.01, 0.01,0.001)]
        [TestCase(-1,-0, -1000, 0, 0)]
        [TestCase(-10,1000, -1000,100,100)]
        [TestCase(-89.999,10, 10.10, 5,5)]
        [TestCase(-0.999,0.0, 0.2, 999,9999)]
        public void Curve_With_Negative_Angle_Gives_G02 (double angle, double x1, double y1, double x2, double y2)
        {
            //Arrange
            CurveCommandNode curveNode = CreateCurveNode(angle,  x1,  y1,  x2,  y2);
            CurveEmitter curveEmitter = SetupEmitter(curveNode);
            
            //Act and Assert
            Assert.DoesNotThrow(() =>
            {
                Assert.IsTrue(curveEmitter.SemanticErrors.Count == 0);
            });

            List<string> gCodeCommands = curveEmitter.Emit().Split("\n").ToList();
            gCodeCommands.RemoveAt(gCodeCommands.Count - 1); // Remove the empty string from the split operation.

            Assert.AreEqual(2, gCodeCommands.Count);
            Assert.AreEqual($"G00 X{x1} Y{y1}",gCodeCommands.First());
            Assert.IsTrue(G02Regex.IsMatch(gCodeCommands.Last()));
        }
        
        [TestCase(45, -0.0001, -0.0001, 999999.9999,9999999.9999)]
        [TestCase(1, -1000, 0,1,0)]
        [TestCase(10, -1000, -1000,1,0)]
        [TestCase(89.999,0, 0,99,99)]
        [TestCase(0.999,1, 1,0001, 1)]
        public void Curve_With_Positive_Angle_Gives_G03 (double angle, double x1, double y1, double x2, double y2)
        {
            //Arrange
            CurveCommandNode curveNode = CreateCurveNode(angle,  x1,  y1,  x2,  y2);
            CurveEmitter curveEmitter = SetupEmitter(curveNode);
            
            //Act and Assert
            Assert.DoesNotThrow(() =>
            {
                Assert.IsTrue(curveEmitter.SemanticErrors.Count == 0);
            });

            List<string> gCodeCommands = curveEmitter.Emit().Split("\n").ToList();
            gCodeCommands.RemoveAt(gCodeCommands.Count - 1); // Remove the empty string from the split operation.

            Assert.AreEqual(2, gCodeCommands.Count);
            Assert.AreEqual($"G00 X{x1} Y{y1}",gCodeCommands.First());
            Assert.IsTrue(G03Regex.IsMatch(gCodeCommands.Last()));
        }
        
        [TestCase(0, -0.0001, -0.0001, 999999.9999,9999999.9999)]
        public void Curve_With_Angle_Zero_Gives_Warning (double angle, double x1, double y1, double x2, double y2)
        {
            //Arrange
            CurveCommandNode curveNode = CreateCurveNode(angle,  x1,  y1,  x2,  y2);
            CurveEmitter curveEmitter = SetupEmitter(curveNode);
            
            //Act and Assert

            Assert.IsTrue(curveEmitter.SemanticErrors.Count == 1);
            Assert.IsTrue(curveEmitter.SemanticErrors.First().IsFatal == false);
        }

        #region Helper functions

        


        private CurveEmitter SetupEmitter(CurveCommandNode curveNode)
        {
            CurveEmitter curveEmitter = new CurveEmitter( new List<SemanticError>());
            curveEmitter.SetupGCodeResult(curveNode);
            return curveEmitter;
        }

        private CurveCommandNode CreateCurveNode(in double angle, in double x1, in double y1, in double x2, in double y2)
        {
            NumberNode angleNode = new NumberNode(angle);
            TuplePointNode fromNode = new TuplePointNode("", new NumberNode(x1), new NumberNode(y1));
            List<PointReferenceNode> toNode = new List<PointReferenceNode>();
            toNode.Add(new TuplePointNode("", new NumberNode(x2), new NumberNode(y2)));
            return new CurveCommandNode(fromNode, toNode, angleNode);
        }
        
        #endregion
        
    }
    
}