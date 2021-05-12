using NUnit.Framework;
using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using OG;
using OG.Compiler;

namespace Tests

{
    public class ParserTests
    {
        /// <summary>
        /// Creates the Parser used for all the tests in this file.
        /// </summary>
        /// <param name="fileName">The name of the fixture being used</param>
        /// <param name="dirName">The name of the directory the fixture is in</param>
        /// <returns></returns>
        private OGParser CreateParser(string fileName, string dirName)
        {
            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            OGParser parser = parCon.Parser;
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser;
        }
        
        [TestCase("base.og", "Testing the minimal meaningful product")]
        [TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("base_function.og", "Testing the base case for declaring a function")]
        [TestCase("base_shape.og", "Testing the base case for declaring a shape")]
        [TestCase("boolExpressions.og", "Testing declaration and use of bool expressions")]
        [TestCase("draw.og", "Testing if Draw can contain previously declared and defined shapes")]
        [TestCase("math.og", "Testing mathematical expressions are ok")]
        [TestCase("mathAddition.og", "Testing a file with additive math expressions")]
        [TestCase("mathMultiplication.og", "Testing a file with multiplicative math expressions")]
        [TestCase("while.og", "testing while loops")]
        [TestCase("functionCallAsAssignment.og", "Testing assigning a function call to an ID")]
        //[TestCase("soleFunctionCall.og", "Testing a single function call")]//Vi har valgt at dette ikke er muligt
        [TestCase("funcCallAssignmentWithParams.og", "Testing a function call to an ID with params")]
        [TestCase("DrawCurves.og", "Draw curves")]
        [TestCase("FunctionDeclParameters.og", "testing that two parameters are discovered")]
        


        public void Test_Fixtures_ShouldNotRaiseAnySyntaxExceptions(string fileName, string description)
        {
            OGParser parser = CreateParser(fileName, "Correct programs/");

            Assert.DoesNotThrow(() =>
            {
                IParseTree tree = parser.program();
            }, description);
        }
        
        [TestCase("nested_shape.og", true,"Testing that nested shapes are not valid")]        
        [TestCase("BoolAssignedToNumberDcl.og", true,"Check number declaration fails on wrong type assignment")]
        [TestCase("PointAssignedToNumberDcl.og", true,"Check number declaration fails on wrong type assignment")]
        [TestCase("PointAssignedToBoolDcl.og", true,"Check bool declaration fails on wrong type assignment")]
        [TestCase("NumberAssignedToBoolDcl.og", true,"Check bool declaration fails on wrong type assignment")]
        [TestCase("BoolAssignedToPointDcl.og", true,"Check point declaration fails on wrong type assignment")]
        [TestCase("NumberAssignedToPointDcl.og", true,"Check point declaration fails on wrong type assignment")]
        public void Test_Fixtures_ShouldRaiseSyntaxExceptions(string fileName,bool shouldFail, string description)
        {
            OGParser parser = CreateParser(fileName, "Incorrect programs/");

            if (shouldFail)
            {
                Assert.Throws<SyntaxException>(() =>
                {
                    IParseTree tree = parser.program();
                }, description);
            }
            else
            {
                Assert.DoesNotThrow(() =>
                {
                    IParseTree tree = parser.program();
                }, description);
            }
        }
    }
}
