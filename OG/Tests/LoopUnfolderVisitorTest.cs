using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using Antlr4.Runtime;
using NUnit.Framework;
using OG;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting.Visitors;
using OG.AstVisiting.Visitors.ExpressionReduction;
using OG.Compiler;

namespace Tests.Fixtures
{
    public class UnfolderVisitorTest
    {

        [TestCase("Testing repeat node containing 0 assignments, looping 1 times",0,1)]
        [TestCase("Testing repeat node containing 1 assignments, looping 10000 times",1,10000)]
        [TestCase("Testing repeat node containing 2 assignments, looping 999 times",2,999)]
        [TestCase("Testing repeat node containing 3 assignments, looping 100 times",3,100)]
        [TestCase("Testing repeat node containing 4 assignments, looping 99 times",4,99)]
        [TestCase("Testing repeat node containing 5 assignments, looping 5 times",5,5)]
        [TestCase("Testing repeat node containing 99 assignments, looping 4 times",99,4)]
        [TestCase("Testing repeat node containing 100 assignments, looping 3 times",100,3)]
        [TestCase("Testing repeat node containing 999 assignments, looping 2 times",999,2)]
        [TestCase("Testing repeat node containing 10000 assignments, looping 1 times",10000,1)]
        public void Test_Repeat_N_Times_Gives_N_Times_More_Statements(string description, int numberOfAssignments, int numberOfLoops)
        {
            //Arrange
            List<SemanticError> errors = new List<SemanticError>();
            Dictionary<string, AstNode> elements = new Dictionary<string, AstNode>();
            List<StatementNode> originalStatements = CreateStatements(numberOfLoops, numberOfAssignments);
            NumberIterationNode loop = CreateNumberIterationNode(numberOfLoops, originalStatements);
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(elements,errors );

            //Act
            loop.Accept(loopUnfolder);
            Assert.IsEmpty(errors);
            //Assert
            Assert.IsTrue(loop.Body.StatementNodes.Count == numberOfAssignments * numberOfLoops);
        }
        
        
        

        [TestCase("Testing repeat node containing 1 assignments, looping 2 times", 1,2)]
        [TestCase("Testing repeat node containing 2 assignments, looping 2 times", 2,2)]
        [TestCase("Testing repeat node containing 3 assignments, looping 2 times", 3,2)] 
        [TestCase("Testing repeat node containing 4 assignments, looping 2 times", 4,2)]
        [TestCase("Testing repeat node containing 5 assignments, looping 2 times", 5,2)]
        [TestCase("Testing repeat node containing 6 assignments, looping 2 times", 6,2)]
        public void Test_Statements_Occur_Multiple_Times_By_in_Order_By_Reference(string description, int numberOfAssignments, int numberOfLoops)
        {
            //Arrange
            List<SemanticError> errors = new List<SemanticError>();
            Dictionary<string, AstNode> elements = new Dictionary<string, AstNode>();
            List<StatementNode> originalStatements = CreateStatements(numberOfLoops, numberOfAssignments);
            NumberIterationNode loop = CreateNumberIterationNode(numberOfLoops, originalStatements);
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(elements,errors );

            //Act
            loop.Accept(loopUnfolder);
            Assert.IsEmpty(errors);
            
            //Assert
            for (int i = 0; i < numberOfAssignments*numberOfLoops; i++)
            {
                StatementNode expected = originalStatements[i % numberOfAssignments];
                Assert.AreEqual(expected, loop.Body.StatementNodes[i]);
            }
        }
        
        [TestCase("Testing repeat node containing 1 assignments, looping 2 times", 1,2)]
        [TestCase("Testing repeat node containing 2 assignments, looping 2 times", 2,2)]
        [TestCase("Testing repeat node containing 3 assignments, looping 2 times", 3,2)]
        [TestCase("Testing repeat node containing 4 assignments, looping 2 times", 4,2)]
        [TestCase("Testing repeat node containing 5 assignments, looping 2 times", 5,2)]
        [TestCase("Testing repeat node containing 0 assignments, looping 2 times", 0,100)]
        public void Test_Nested_Loops_Are_Visited_And_Unfolded(string description, int numberOfAssignments, int numberOfLoops)
        {
            //Arrange
            List<SemanticError> errors = new List<SemanticError>();
            List<StatementNode> originalStatements = CreateStatements(numberOfLoops, numberOfAssignments);
            NumberIterationNode nestedLoop = CreateNumberIterationNode(numberOfLoops, CreateStatements(numberOfLoops, numberOfAssignments));
            NumberIterationNode loop = CreateNumberIterationNode(numberOfLoops, originalStatements);
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(new Dictionary<string, AstNode>(),errors );

            //Act
            originalStatements.Add(nestedLoop);
            loopUnfolder.Visit(loop);
            Assert.IsEmpty(errors);
            
            //Assert
            int outerLoopCount = loop.Body.StatementNodes.Count;
            int nestedCount = nestedLoop.Body.StatementNodes.Count;
            
            //Plus one for the added inner loop
            Assert.AreEqual(numberOfLoops* (numberOfAssignments + 1), outerLoopCount);
            Assert.AreEqual(numberOfLoops*numberOfAssignments, nestedCount);
        }
        
        [TestCase("Testing repeat node containing 1 assignments, looping 2 times", 1,2)]
        [TestCase("Testing repeat node containing 2 assignments, looping 2 times", 2,2)]
        [TestCase("Testing repeat node containing 3 assignments, looping 2 times", 3,2)]
        [TestCase("Testing repeat node containing 4 assignments, looping 2 times", 4,2)]
        [TestCase("Testing repeat node containing 5 assignments, looping 2 times", 5,2)]
        [TestCase("Testing repeat node containing 6 assignments, looping 2 times", 6,2)]
        [TestCase("Testing repeat node containing 0 assignments, looping 2 times", 0,100)]
        public void Test_Nested_Loops_Are_Repeated_In_Order_In_Statement_List_by_Reference(string description, int numberOfAssignments, int numberOfLoops)
        {
            //Arrange
            List<SemanticError> errors = new List<SemanticError>();
            List<StatementNode> originalStatements = CreateStatements(numberOfLoops, numberOfAssignments);
            NumberIterationNode nestedLoop =
                CreateNumberIterationNode(numberOfLoops, CreateStatements(numberOfLoops, numberOfAssignments));
            NumberIterationNode loop = CreateNumberIterationNode(numberOfLoops, originalStatements);
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(new Dictionary<string, AstNode>(),errors);

            //Act
            originalStatements.Add(nestedLoop);
            loopUnfolder.Visit(loop);
            Assert.IsEmpty(errors);
            
            //Assert
            for (int i = 0; i < numberOfAssignments*numberOfLoops; i++)
            {
                //Plus one for added inner loop
                StatementNode expected = originalStatements[i % (numberOfAssignments+1)];
                Assert.AreEqual(expected, loop.Body.StatementNodes[i]);
            }
        }

        [TestCase("Testing repeat node containing 2 assignments, looping 0.5 times", 2,0.5)]
        [TestCase("Testing repeat node containing 4 assignments, looping 0.00001 times", 4,0.1)]
        [TestCase("Testing repeat node containing 5 assignments, looping 99.999 times", 5,99.9999)]
        [TestCase("Testing repeat node containing 6 assignments, looping 0.99999 times", 6,0.99999)]
        public void Test_Non_Integer_Number_Of_Loops_Gives_Fatal_Semantic_Error(string description, int numberOfAssignments, double numberOfLoops)
        {
            //Arrange
            List<SemanticError> errors = new List<SemanticError>();
            List<StatementNode> originalStatements = CreateStatements(numberOfLoops, numberOfAssignments);
            NumberIterationNode loop = CreateNumberIterationNode(numberOfLoops, originalStatements);
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(new Dictionary<string, AstNode>(),errors );

            //Act
            loopUnfolder.Visit(loop);

            //Assert
            Assert.IsNotEmpty(errors);
        }
        
        [TestCase("Testing repeat node containing 1 assignments, looping 0 times", 2,0)]
        public void Test_Repeat_Visit_0_times_Causes_No_Statements_And_A_Semantic_Error(string description, int numberOfAssignments, double numberOfLoops)
        {
            //Arrange
            List<SemanticError> errors = new List<SemanticError>();
            List<StatementNode> originalStatements = CreateStatements(numberOfLoops, numberOfAssignments);
            NumberIterationNode loop = CreateNumberIterationNode(numberOfLoops, originalStatements);
            LoopUnfolderVisitor loopUnfolder = new LoopUnfolderVisitor(new Dictionary<string, AstNode>(),errors );
            //Act
            loopUnfolder.Visit(loop);

            //Assert
            Assert.IsNotEmpty(errors);
            Assert.IsEmpty(loop.Body.StatementNodes);
            Assert.AreEqual( 0,loop.Body.StatementNodes.Count);
        }

        #region Helper functions
        
        private BodyNode CreateMockBody(NumberIterationNode loop)
        {
            List<StatementNode> mockBodyStatements = new List<StatementNode>();
            mockBodyStatements.Add(loop);
            return new BodyNode(mockBodyStatements);
        }

        private List<StatementNode> CreateStatements( double numberOfLoops, int numberOfAssignments)
        {
            List < StatementNode > statements = new List<StatementNode>();
            for (int i = 0; i < numberOfAssignments; i++)
            {
                statements.Add(new MathAssignmentNode(new IdNode($"variable{i}"), new NumberNode(2)));
            }

            return statements;
        }


        private NumberIterationNode CreateNumberIterationNode(double numberOfLoops, List<StatementNode> statements)
        {
            return new NumberIterationNode(new NumberNode(numberOfLoops), new BodyNode(statements));
        }

        private void ReduceExpressions(ProgramNode p,Dictionary<string,AstNode> symbolTable, List<SemanticError> errs )
        {
            //Reducer is well tested so we do not examine found errors.
            MathReducerVisitor reducer = new MathReducerVisitor(symbolTable, errs);
            p.Accept(reducer);

            PointReducerVisitor preducer = new PointReducerVisitor(symbolTable, errs);
            p.Accept(preducer);
        }

        private Dictionary<string,AstNode> TypeCheck(ProgramNode programNode)
        {
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            programNode.Accept(ST);
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            programNode.Accept(TT);
            return ST.GetSymbolTable();
        }

        private ProgramNode BuildAst(string fileName)
        {
            OGParser parser = CreateParser(fileName, "Correct programs/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));
            
            return astContainer.AstTreeTopNode;
        }


        private OGParser CreateParser(string fileName, string dirName)
        {
            Dictionary<string, string> symbolTable = new Dictionary<string, string>();

            string code = File.ReadAllText("../../../Fixtures/" + dirName + fileName);
            LexerContainer lexCon = new LexerContainer(code);
            ParserContainer parCon = new ParserContainer(lexCon.TokenSource);
            OGParser parser = parCon.Parser;
            ErrorListenerHelper<IToken> listener = new ErrorListenerHelper<IToken>();
            parser.AddErrorListener(listener);
            return parser;
        }

        #endregion
        
    }
    
    
}