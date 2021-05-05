using System;
using System.Collections.Generic;
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
    public class MathNodeReducer : ISemanticErrorable, IMathNodeVisitor
    {
        private SymbolTable _symbolTable;
        public double Result { get; set; }


        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        public MathNodeReducer(SymbolTable symboltable, List<SemanticError> errs)
        {
            _symbolTable = symboltable;
            SemanticErrors = errs;
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
            MathNode assignedValue = (MathNode) _symbolTable.GetElementById(node.AssignedValueId);
            return assignedValue.Accept(this);
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
            throw new NotImplementedException();
        }

        public NumberNode Visit(CoordinateXyValueNode node)
        {
            throw new NotImplementedException("Cannot get XY values yet");
            return new NumberNode(2);
        }
    }
}