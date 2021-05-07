using System;
using System.Collections.Generic;
using System.Data;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using OG.CodeGeneration;

namespace OG.Compiler
{
    public class MathArithmeticCalculator : ISemanticErrorable, IMathNodeReducer
    {
        private SymbolTable _symbolTable;
        public double Result { get; set; }
        readonly TypeCastVisitor _typeCaster = new TypeCastVisitor();
        private MathReducerVisitor _mathReducerVisitor = null;


        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        public MathArithmeticCalculator(SymbolTable symboltable, List<SemanticError> errs, MathReducerVisitor mathReducerVisitor)
        {
            _symbolTable = symboltable;
            SemanticErrors = errs;
            _mathReducerVisitor = mathReducerVisitor;
        }

        public NumberNode ReduceToNumberNode(MathNode node)
        {
            return node.Accept(this);
        }


        public NumberNode Visit(AdditionNode node)
        {
            double rhs = node.RHS.Accept(this).NumberValue;
            double lhs = node.LHS.Accept(this).NumberValue;
            return new NumberNode(lhs + rhs);
        }

        public NumberNode Visit(NumberNode node)
        {
            return node;
        }

        public NumberNode Visit(DivisionNode node)
        {
            double rhs = node.RHS.Accept(this).NumberValue;
            double lhs = node.LHS.Accept(this).NumberValue;
            return new NumberNode(lhs / rhs);
        }

        public NumberNode Visit(MathIdNode node)
        {
            
            //Assigned value to Id must be a math node for it to occur as mathIdNode
            AstNode symbolTableResult = _symbolTable.GetElementBySymbolTableAddress(node.AssignedValueId.SymboltableAddress);
             
            return (NumberNode)symbolTableResult.Accept(_mathReducerVisitor);
            
            
            //MathNode assignedMathValue = (MathNode) numberNode.AssignedExpression;
            return null;//assignedMathValue.Accept(this);
        }

        public NumberNode Visit(MultiplicationNode node)
        {
            double rhs = node.RHS.Accept(this).NumberValue;
            double lhs = node.LHS.Accept(this).NumberValue;
            return new NumberNode(lhs * rhs);
        }

        public NumberNode Visit(PowerNode node)
        {
            double rhs = node.RHS.Accept(this).NumberValue;
            double lhs = node.LHS.Accept(this).NumberValue;
            return new NumberNode(Math.Pow(lhs, rhs));
        }

        public NumberNode Visit(SubtractionNode node)
        {
            double rhs = node.RHS.Accept(this).NumberValue;
            double lhs = node.LHS.Accept(this).NumberValue;
            return new NumberNode(lhs - rhs);
        }

        public NumberNode Visit(MathFunctionCallNode node)
        {
            
            AstNode astNode = _symbolTable.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress);
            FunctionNode funcNode = (FunctionNode) astNode.Accept(_typeCaster);
            
            for (int i = 0; i < node.Parameters.Count; i++)
            {
                funcNode.Parameters[i].Expression = node.Parameters[i].Expression;
                _symbolTable.Add(funcNode.Parameters[i].IdNode.SymboltableAddress, funcNode.Parameters[i]);
            }

            funcNode.Accept(_mathReducerVisitor);
            return null;

        }

        public NumberNode Visit(CoordinateXyValueNode node)
        {
            SemanticErrors.Add(new SemanticError(node, "Coordinate XY value is not yet supported."){IsFatal = true});
            return null;
        }
    }

    public interface IMathNodeReducer : IMathNodeVisitor
    {
        public NumberNode ReduceToNumberNode(MathNode node);
    }
}