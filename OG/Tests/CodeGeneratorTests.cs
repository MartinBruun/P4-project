using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.AstVisiting.Visitors;
using OG.AstVisiting.Visitors.ExpressionReduction;
using OG.CodeGeneration;
using OG.Compiler;

namespace Tests
{
    public class CodeGeneratorTests
    {
        /// <summary>
        /// Creates the Parser used for all the tests in this file.
        /// </summary>
        /// <param name="fileName">The name of the fixture being used</param>
        /// <param name="dirName">The name of the directory the fixture is in</param>
        /// <returns></returns>
        private AstBuilderContainer<AstBuilder,ProgramNode> CreateAstBuilder(string fileName, string dirName)
        {
            string sourceFile = File.ReadAllText("../../../Fixtures/" + dirName + fileName);

            LexerContainer lexCon = new LexerContainer(sourceFile);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);

            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parCon.Parser, new AstBuilder("program"));

            return astContainer;
        }

        [TestCase("base.og", "Testing the minimal meaningful product")]
        //[TestCase("largeExampleProgram.og", "Testing a file with a large amount of mixed commands")]
        [TestCase("base_function.og", "Testing the base case for declaring a function")]
        [TestCase("base_shape.og", "Testing the base case for declaring a shape")]
        [TestCase("boolExpressions.og", "Testing declaration and use of bool expressions")]
        [TestCase("draw.og", "Testing if Draw can contain previously declared and defined shapes")]
        [TestCase("math.og", "Testing mathematical expressions are ok")]
        [TestCase("mathAddition.og", "Testing a file with additive math expressions")]
        [TestCase("mathMultiplication.og", "Testing a file with multiplicative math expressions")]
        [TestCase("while.og", "testing while loops")]
        [TestCase("MultibleRepeatLoopsInFunction.og", "testing Repeat loops in function")]
        [TestCase("MultibleRepeatLoopsInShape.og", "testing Repeat loops in shape")]
        [TestCase("NestedRepeatLoopsInFunction.og", "testing nested Repeat loops in function")]
        [TestCase("NestedRepeatLoopsInShape.og", "testing nested Repeat loops in shape")]
        [TestCase("FunctionCallParameters.og", "testing that a function can take id as params")]
        [TestCase("DrawCurves.og", "Draw curves")]
        public void Test_Fixtures_ShouldNotThrowAnyErrors(string fileName, string description)
        {
            Dictionary<string, AstNode> symbolTable = new Dictionary<string, AstNode>();
            List<SemanticError> errors = new List<SemanticError>();
            AstBuilderContainer<AstBuilder,ProgramNode> astContainer = CreateAstBuilder(fileName,"Correct programs/");
            ProgramNode p = astContainer.AstTreeTopNode;
            
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            Assert.DoesNotThrow(
                    () => p.Accept(ST), description + "\nThrows at CreateSymbolTableVisitor"
                );
            errors.AddRange(ST.GetErrors());
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            Assert.DoesNotThrow(
                () => p.Accept(TT), description + "\nThrows at TypeCheckAssignmentsVisitor"
            );
            errors.AddRange(TT.GetErrors());
            
            symbolTable = TT.GetSymbolTable();
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(symbolTable,errors);
            Assert.DoesNotThrow(
                () => p.Accept(loopUnfolder), description + "\nThrows at LoopUnfolderVisitor"
            );

            ExpressionReducerVisitor reducer = new ExpressionReducerVisitor(symbolTable, errors);
            CodeGeneratorVisitor gCodeGeneratorVisitor = new CodeGeneratorVisitor(symbolTable, errors, reducer );
            Assert.DoesNotThrow(
                () => p.Accept(gCodeGeneratorVisitor), description + "\nThrows at CodeGeneratorVisitor"
            );
            
            Assert.AreEqual(0, errors.Count, description);
        }
    }
}