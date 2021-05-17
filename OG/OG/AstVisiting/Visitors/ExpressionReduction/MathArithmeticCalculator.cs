using System;
using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.CodeGeneration;

namespace OG.AstVisiting.Visitors.ExpressionReduction
{
    public class MathArithmeticCalculator : ISemanticErrorable, IMathNodeVisitor
    {
        private SymbolTable _symbolTable;
        private MathReducerVisitor _mathReducerVisitor = null;


        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        public MathArithmeticCalculator(SymbolTable symboltable, List<SemanticError> errs, MathReducerVisitor mathReducerVisitor)
            :this(symboltable, errs)
        {
            _mathReducerVisitor = mathReducerVisitor;
        }
        
        public MathArithmeticCalculator(SymbolTable symboltable, List<SemanticError> errs)
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
            double lhs = node.LHS.Accept(this).NumberValue;
            double rhs = node.RHS.Accept(this).NumberValue;
            return new NumberNode(lhs + rhs);
        }

        public NumberNode Visit(NumberNode node)
        {
            return node;
        }

        public NumberNode Visit(DivisionNode node)
        {
            double lhs = node.LHS.Accept(this).NumberValue;
            double rhs = node.RHS.Accept(this).NumberValue;
            return new NumberNode(lhs / rhs);
        }

        public NumberNode Visit(MathIdNode node)
        {
            //Assigned value to Id must be a math node for it to occur as mathIdNode
            AstNode symbolTableResult =
                 _symbolTable.GetElementBySymbolTableAddress(node.AssignedValueId.SymboltableAddress);
            node.AssignedValueId.DeclaredValue = symbolTableResult;
            object q = symbolTableResult.Accept(_mathReducerVisitor);
            return (NumberNode) q;
            
            //MathNode assignedMathValue = (MathNode) numberNode.AssignedExpression;
            return null;//assignedMathValue.Accept(this);
        }

        public NumberNode Visit(MultiplicationNode node)
        {
            
            
            double lhs = node.LHS.Accept(this).NumberValue;
            double rhs = node.RHS.Accept(this).NumberValue;
            return new NumberNode(lhs * rhs);
        }

        public NumberNode Visit(PowerNode node)
        {
            double lhs = node.LHS.Accept(this).NumberValue;
            double rhs = node.RHS.Accept(this).NumberValue;
            return new NumberNode(Math.Pow(lhs, rhs));
        }

        public NumberNode Visit(SubtractionNode node)
        {
            double lhs = node.LHS.Accept(this).NumberValue;
            double rhs = node.RHS.Accept(this).NumberValue;
            return new NumberNode(lhs - rhs);
        }

        public NumberNode Visit(MathFunctionCallNode node)
        {
            string functionNodeAdresse = node.FunctionName.SymboltableAddress;
            FunctionNode funcNode = (FunctionNode) _symbolTable.GetElementBySymbolTableAddress(functionNodeAdresse);

            //Pass parameters to function body
            for (int i = 0; i < node.Parameters.Count; i++)
            {

                if (node.Parameters[i].ParameterId != null)
                {
                    var passedParamValue =
                        _symbolTable.GetElementBySymbolTableAddress(node.Parameters[i].ParameterId.SymboltableAddress);
                    funcNode.Parameters[i].Expression =
                        (ExpressionNode) passedParamValue?.Accept(_mathReducerVisitor); 
                    
                    node.Parameters[i].FormalParameterId = funcNode.Parameters[i].IdNode;

                }

                 if (funcNode.Parameters[i].Expression == null)
                 {
                     funcNode.Parameters[i].Expression = node.Parameters[i].Expression;
                 }
                
                _symbolTable.Add(funcNode.Parameters[i].IdNode.SymboltableAddress, funcNode.Parameters[i].Expression);
            }
            
            funcNode.Accept(_mathReducerVisitor);

            //We know that return value is math node - we can reduce math nodes to numbers.
            
            return (NumberNode)  funcNode.ReturnValue.Accept(_mathReducerVisitor);


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