using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NuGet.Frameworks;
using NUnit.Framework;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting.Visitors.ExpressionReduction;

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
        
        [TestCase(1,'-',1)]
        [TestCase(1,'+',1)]
        [TestCase(1,'*',1)]
        [TestCase(1,'/',1)]
        [TestCase(1,'^',1)]
        public void Test_Math_Declaration_RHS_Id_is_Reduced_To_Number(double lhs, char op, double rhs)
        {
            IdNode b = new IdNode("b");
            //number b = lhs op rhs;
            NumberDeclarationNode bDcl =
                new NumberDeclarationNode(b, CreateInfixMathNode(lhs, op, rhs));

            //a = b;
            IdNode a = new IdNode("a");
            MathAssignmentNode assign = new MathAssignmentNode(a,new MathIdNode("", b));

            var keys = new List<string>()
            {
                "a", "b"
            };
            var nodes = new List<AstNode>()
            {
                a,b
            };
            ExpressionReducerVisitor expressionReducer = InitiateReducer(InitiateSymbolTable(keys, nodes));
            
            //Act
            expressionReducer.Visit(assign);
            AstNode p = expressionReducer._symbolTable.GetElementBySymbolTableAddress("a");

            //Assert
            Assert.IsInstanceOf<MathAssignmentNode>(p);
            MathAssignmentNode assignmentNode = (MathAssignmentNode) p;
            Assert.IsInstanceOf<NumberNode>(assignmentNode.AssignedValue);
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
        
        
        

        public ExpressionReducerVisitor InitiateReducer(Dictionary<string, AstNode> symTable)
        {
            return new ExpressionReducerVisitor(symTable, new List<SemanticError>());
        }
    }
}