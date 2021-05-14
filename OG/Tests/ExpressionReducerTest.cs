using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Antlr4.Runtime;
using NuGet.Frameworks;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting.Visitors;
using OG.AstVisiting.Visitors.ExpressionReduction;
using OG.Compiler;

namespace Tests
{
    public class ExpressionReducerTest
    {
        
        [TestCase(1,'-',1)]
        [TestCase(1,'+',1)]
        [TestCase(1,'*',1)]
        [TestCase(1,'/',1)]
        [TestCase(1,'^',1)]
        public void Test_MathAssignment_RHS_Are_Reduced_To_Number(double lhs, char op, double rhs)
        {
            //Arrange
            //a = MATH; is reduced  to a = number; in this test.
            MathAssignmentNode assign = new MathAssignmentNode(new IdNode("a"), CreateInfixMathNode(lhs, op, rhs));
            ExpressionReducerVisitor expressionReducer = InitiateReducer(InitiateSymbolTable("a", assign));
            
            //Act
            expressionReducer.Visit(assign);
            AstNode p = expressionReducer._symbolTable.GetElementBySymbolTableAddress("a");

            //Assert
            Assert.IsInstanceOf<MathAssignmentNode>(p);
            MathAssignmentNode assignmentNode = (MathAssignmentNode) p;
            Assert.IsInstanceOf<NumberNode>(assignmentNode.AssignedValue);
        }

        [TestCase("MathfunctionCall.og", "Various function calls return values equal to what is indicated in function name")]
        public void Test_Math_Function_Call_Result_In_Number_Node_Return_Value(string fileName, string description)
        {
            //Arrange
            ProgramNode p = CreateProgram(fileName);
            Dictionary<string, AstNode> symtab = CreateSymbolTable(p);
            TypeCheck(p); //Needed as it decorates tree
            ExpressionReducerVisitor expressionReducer = InitiateReducer(symtab);
            
            //Act
            expressionReducer.Visit(p);
            List<NumberDeclarationNode> ExpectedResults = GetNumberDeclarations(p,symtab);
            
            //Assert
            Assert.IsNotEmpty(ExpectedResults);
            foreach (NumberDeclarationNode node in ExpectedResults)
            {
                Assert.IsNotNull(node);
                Assert.IsInstanceOf<NumberNode>(node.AssignedExpression);
            }

            
        }
        
        [TestCase("PointfunctionCall.og", "Various function calls return values equal to what is indicated in function name")]
        public void Test_Point_Function_Call_Result_In_Tuple_Point_Node_Return_Value(string fileName, string description)
        {
            //Arrange
            ProgramNode p = CreateProgram(fileName);
            Dictionary<string, AstNode> symtab = CreateSymbolTable(p);
            TypeCheck(p); //Needed as it decorates tree
            ExpressionReducerVisitor expressionReducer = InitiateReducer(symtab);
            
            //Act
            expressionReducer.Visit(p);
            List<PointDeclarationNode> ExpectedResults = GetPointDeclarations(p,symtab);
            //Assert

            Assert.IsNotEmpty(ExpectedResults);
            foreach (PointDeclarationNode node in ExpectedResults)
            {
                Assert.IsNotNull(node);
                Assert.IsInstanceOf<TuplePointNode>(node.AssignedExpression);
            }
        }
        

        public List<NumberDeclarationNode> GetNumberDeclarations(ProgramNode p,Dictionary<string, AstNode> symtab )
        {
            AstNode result = null;
            var a = symtab.TryGetValue("1_0_Global_Results", out result);
            if (a || result is FunctionNode)
            {
                FunctionNode func = (FunctionNode)result;
                return  GetNumberDeclarations(func);
            }
            else
            {
                throw new InvalidDataException(
                    "Symboltable did not contain a functionnode at key    1_0_Global_Results ");
            }

        }
        
        public List<PointDeclarationNode> GetPointDeclarations(ProgramNode p,Dictionary<string, AstNode> symtab )
        {
            AstNode result = null;
            var a = symtab.TryGetValue("1_0_Global_Results", out result);
            if (a || result is FunctionNode)
            {
                FunctionNode func = (FunctionNode)result;
                return  GetPointDeclarations(func);
            }
            else
            {
                throw new InvalidDataException(
                    "Symboltable did not contain a functionnode at key    1_0_Global_Results ");
            }

        }
        
        private List<PointDeclarationNode> GetPointDeclarations(FunctionNode node)
        {
            List<StatementNode> statements = node.Body.StatementNodes;
            return  GetPointDeclarations(statements);
        }
        
        private List<PointDeclarationNode> GetPointDeclarations(List<StatementNode> statements)
        {
            
            List<PointDeclarationNode> res = new List<PointDeclarationNode>();
            foreach (StatementNode statementNode in statements)
            {
                if (statementNode is PointDeclarationNode node)
                {
                    res.Add(node);
                }
            }

            return res;
        }


        private List<NumberDeclarationNode> GetNumberDeclarations(FunctionNode node)
        {
            List<StatementNode> statements = node.Body.StatementNodes;
            return  GetNumberDeclarations(statements);
        }

        private List<NumberDeclarationNode> GetNumberDeclarations(List<StatementNode> statements)
        {
            List<NumberDeclarationNode> res = new List<NumberDeclarationNode>();
            foreach (StatementNode statementNode in statements)
            {
                if (statementNode is NumberDeclarationNode node)
                {
                    res.Add(node);
                }
            }

            return res;
        }

        /// <summary>
        /// -99.5 is used as error value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private double AnalyseNumberResult(NumberDeclarationNode node)
        {
            string[] q = null;
            string id = node.Id.Value.Replace("2_0_Global_Results_", "");

            
            if (id.StartsWith("nm"))
            {
                q = id.Split("nm");
                id = id.Replace("nm", "-");
                q[1] = id;
            } 
            else if (id.StartsWith('n'))
            {
                q = node.Id.Value.Split('n');
                id = id.Replace("n", "");
            }
            else
            {
                return -99.5;
            }

            if (q.Length != 2)
            {
                return -99.5;
            }

            string resultStringNumber = q[1];
            double number = 0;
            var isSucces = Double.TryParse(resultStringNumber, out number);
            if (!isSucces)
            {
                return -99.5;
            }
            else
            {
                return number;
            }
        }

        
       
        public void TypeCheck(AstNode p)
        {
            List<SemanticError> errors = new List<SemanticError>();
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            p.Accept(ST);
            errors.AddRange(ST.GetErrors());
            TypeCheckAssignmentsVisitor TT = new TypeCheckAssignmentsVisitor(ST.GetSymbolTable());
            p.Accept(TT);
            errors.AddRange(TT.GetErrors());

            GetDeclaredValueVisitor GV = new GetDeclaredValueVisitor(TT.GetSymbolTable());
            p.Accept(GV);
            errors.AddRange(GV.GetErrors());
            
        }

        private Dictionary<string, AstNode> CreateSymbolTable(ProgramNode node)
        {
            CreateSymbolTableVisitor ST = new CreateSymbolTableVisitor();
            node.Accept(ST);
            return ST.GetSymbolTable();
        }

        private ProgramNode CreateProgram(string fileName)
        {
            OGParser parser = CreateParser(fileName, "Correct programs/");
            AstBuilderContainer<AstBuilder, ProgramNode> astContainer =
                new AstBuilderContainer<AstBuilder, ProgramNode>(parser, new AstBuilder("program"));
            return astContainer.AstTreeTopNode;
        }


        [TestCase(-9999999.9999,'-',6)]
        [TestCase(-9,'+',1)]
        [TestCase(-1,'*',999999.999999)]
        [TestCase(-2,'/',0)]
        [TestCase(-2,'^',-2)]
        public void Test_TuplePoint_With_Coordinate_Math_Values_Is_Reduced_To_Number_Coordinates(double lhs, char op, double rhs)
        {
            //Arrange
            TuplePointNode tuple =
                new TuplePointNode("", CreateInfixMathNode(lhs, op, rhs), CreateInfixMathNode(lhs, op, rhs));
            PointAssignmentNode assign = new PointAssignmentNode(new IdNode("a"), tuple );
            ExpressionReducerVisitor expressionReducer = InitiateReducer(InitiateSymbolTable("a", assign));
            
            //Act
            expressionReducer.Visit(assign);
            AstNode p = expressionReducer._symbolTable.GetElementBySymbolTableAddress("a");

            //Assert
            Assert.IsInstanceOf<PointAssignmentNode>(p);
            PointAssignmentNode assignmentNode = (PointAssignmentNode) p;
            Assert.IsInstanceOf<TuplePointNode>(assignmentNode.AssignedValue);
            TuplePointNode t = (TuplePointNode) assignmentNode.AssignedValue;
            Assert.IsInstanceOf<NumberNode>(t.XValue);
            Assert.IsInstanceOf<NumberNode>(t.YValue);
        }

        
        public void Test_Point_Assignment_RHS_Reduced_To_TuplePoint(double lhs, char op, double rhs)
        {
            //Arrange
            MathAssignmentNode assign = new MathAssignmentNode(new IdNode("a"), CreateInfixMathNode(lhs, op, rhs));
            ExpressionReducerVisitor expressionReducer = InitiateReducer(InitiateSymbolTable("a", assign));
            
            //Act
            expressionReducer.Visit(assign);
            AstNode p = expressionReducer._symbolTable.GetElementBySymbolTableAddress("a");

            //Assert
            Assert.IsInstanceOf<MathAssignmentNode>(p);
            MathAssignmentNode assignmentNode = (MathAssignmentNode) p;
            Assert.IsInstanceOf<NumberNode>(assignmentNode.AssignedValue);
        }

        public IdNode CreateIdNode(string name)
        {
            var res = new IdNode(name);
            res.SymboltableAddress = name;

            return res;
        }
        
        public MathIdNode CreateMathIdNode(string name)
        {
            var res = new MathIdNode(name,CreateIdNode(name));
            res.AssignedValueId.SymboltableAddress = name;

            return res;
        }
        

        public InfixMathNode CreateInfixMathNode( double lhs,char op, double rhs)
        {
            InfixMathNode node = null;
            switch (op)
            {
                case '^':
                    node = new PowerNode(new NumberNode(rhs), new NumberNode(lhs));
                    break;
                case '+':
                    node = new AdditionNode(new NumberNode(rhs), new NumberNode(lhs));
                    break;
                case '-': 
                    node = new SubtractionNode(new NumberNode(rhs), new NumberNode(lhs));
                    break;
                case '*': 
                    node = new MultiplicationNode(new NumberNode(rhs), new NumberNode(lhs));
                    break;
                case '/': 
                    node = new DivisionNode(new NumberNode(rhs), new NumberNode(lhs));
                    break;
                    default:
                        throw new AssertionException("Operator is not valid" + op.ToString());
            }

            InitateNode(node, "number");
            return node;
        }
        
        public AstNode InitateNode(AstNode node, string type)
        {
            node.CompileTimeType = type;
            return node;
        }
        
        public Dictionary<string, AstNode> InitiateSymbolTable(string key, AstNode astnode)
        {
            Dictionary<string, AstNode> res = new Dictionary<string, AstNode>();
            res.Add(key, astnode);
            return res;
        }
        
        public Dictionary<string, AstNode> InitiateSymbolTable(List<string> keys, List<AstNode> astnodes)
        {
            Dictionary<string, AstNode> res = new Dictionary<string, AstNode>();

            for (int i = 0; i < keys.Count(); i++)
            {
                res.Add(keys[i], astnodes[i]);
                
            }
            
            return res;
        }

        public AstNode InitiateTableElement(IdNode node, string symbolTableAddress)
        {
            node.SymboltableAddress = symbolTableAddress;
            return node;
        }
        
        
        

        public ExpressionReducerVisitor InitiateReducer(Dictionary<string, AstNode> symTable)
        {
            return new ExpressionReducerVisitor(symTable, new List<SemanticError>());
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
    }
}