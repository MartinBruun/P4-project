﻿using System;
using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;
using OG.Compiler;

namespace OG.AstVisiting.Visitors
{
    public class PointReducerVisitor : IVisitor, ISemanticErrorable
    {
        private SymbolTable _symbolTable = new SymbolTable();
        private readonly MathReducerVisitor _mathReducer;
        public PointReducerVisitor(Dictionary<string, AstNode> symbolTable, List<SemanticError> errs)
        {
            SemanticErrors = errs;
            _symbolTable.Elements = symbolTable;
            _mathReducer = new MathReducerVisitor(symbolTable, errs);
        }

        
        public object Visit(BoolAssignmentNode node)
        {
return node;        }

        public object Visit(FunctionCallAssignNode node)
        {
return node;        }

        public object Visit(IdAssignNode node)
        {
return node;        }

        public object Visit(MathAssignmentNode node)
        {
return node;        }

        public object Visit(PointAssignmentNode node)
        {
return node;        }

        public object Visit(PropertyAssignmentNode node)
        {
return node;        }

        public object Visit(ParameterTypeNode node)
        {
return node;        }

        public object Visit(CurveCommandNode node)
        {
return node;        }

        public object Visit(DrawCommandNode node)
        {
return node;        }

        public object Visit(LineCommandNode node)
        {
return node;        }

        public object Visit(NumberIterationNode node)
        {
return node;        }

        public object Visit(UntilFunctionCallNode node)
        {
return node;        }

        public object Visit(UntilNode node)
        {
return node;        }

        public object Visit(BoolDeclarationNode node)
        {
return node;        }

        public object Visit(NumberDeclarationNode node)
        {
return node;        }

        public object Visit(PointDeclarationNode node)
        {
                return node.AssignedExpression.Accept(this);
        }

        public object Visit(BoolExprIdNode node)
        {
return node;        }

        public object Visit(BodyNode node)
        {
            foreach (StatementNode nodeStatementNode in node.StatementNodes)
            {
                Console.WriteLine(nodeStatementNode);
                nodeStatementNode.Accept(this);
            }

            return node;
        }

        public object Visit(AndComparerNode node)
        {
return node;        }

        public object Visit(BoolNode node)
        {
return node;        }

        public object Visit(EqualsComparerNode node)
        {
return node;        }

        public object Visit(GreaterThanComparerNode node)
        {
return node;        }

        public object Visit(LessThanComparerNode node)
        {
return node;        }

        public object Visit(NegationNode node)
        {
return node;        }

        public object Visit(OrComparerNode node)
        {
return node;        }

        public object Visit(BoolFunctionCallNode node)
        {
return node;        }

        public object Visit(FunctionCallNode node)
        {
return node;        }

        public object Visit(FunctionCallParameterNode node)
        {
return node;        }

        public object Visit(MathFunctionCallNode node)
        {
return node;        }

        public object Visit(ParameterNode node)
        {
return node;        }

        public object Visit(FunctionNode node)
        {
            return node.Body.Accept(this);
        }

        public object Visit(AdditionNode node)
        {
return node;        }

        public object Visit(DivisionNode node)
        {
return node;        }

        public object Visit(MathIdNode node)
        {
return node;        }

        public object Visit(MultiplicationNode node)
        {
return node;        }

        public object Visit(PowerNode node)
        {
return node;        }

        public object Visit(SubtractionNode node)
        {
return node;        }

        public object Visit(PointFunctionCallNode node)
        {
            string functionNodeAdresse = node.FunctionName.SymboltableAddress;
            FunctionNode funcNode = (FunctionNode) _symbolTable.GetElementBySymbolTableAddress(functionNodeAdresse);

            //Pass parameters to function body
            for (int i = 0; i < node.Parameters.Count; i++)
            {
                funcNode.Parameters[i].Expression = (ExpressionNode) node.Parameters[i].Expression;
                //This will go wrong
              
                if (funcNode.Parameters[i].Expression == null)
                {
                    AstNode xVal = _symbolTable.GetElementBySymbolTableAddress(node.Parameters[i].ParameterId
                        .SymboltableAddress);

                    xVal.Accept(this);
                    funcNode.Parameters[i].Expression = (ExpressionNode)xVal;
                }
                
                _symbolTable.Add(funcNode.Parameters[i].IdNode.SymboltableAddress, funcNode.Parameters[i]);
            }
            
            funcNode.Accept(this);

            //We know that return value is math node - we can reduce math nodes to numbers.
            
            return (PointReferenceNode)  funcNode.ReturnValue.Accept(this);
        }

        public object Visit(PointReferenceIdNode node)
        {
            AstNode res =  _symbolTable.GetElementBySymbolTableAddress(node.AssignedValue.SymboltableAddress);
            return  res.Accept(this);
        }

        public object Visit(ShapeEndPointNode node)
        {
return node;        }

        public object Visit(ShapePointRefNode node)
        {
return node;        }

        public object Visit(ShapeStartPointNode node)
        {
return node;        }

        public object Visit(TuplePointNode node)
        {
            NumberNode x = (NumberNode) node.XValue.Accept(_mathReducer);
            NumberNode y = (NumberNode) node.YValue.Accept(_mathReducer);

            node.XValue = x;
            node.YValue = y;
            return node;
        }
        public object Visit(FalseNode node)
        {
return node;        }

        public object Visit(IdNode node)
        {
return node;        }

        public object Visit(NumberNode node)
        {
return node;        }

        public object Visit(TrueNode node)
        {
return node;        }

        public object Visit(SizePropertyNode node)
        {
return node;        }

        public object Visit(WorkAreaSettingNode node)
        {
return node;        }

        public object Visit(AstNode node)
        {
return node;        }

        public object Visit(DrawNode node)
        {
return node;        }

        public object Visit(ProgramNode node)
        {
            foreach (FunctionNode nodeFunctionDcl in node.FunctionDcls)
            {
                nodeFunctionDcl.Accept(this);
            }

            foreach (var shape in node.ShapeDcls)
            {
                shape.Accept(this);
            }

            return node;
        }

        public object Visit(ShapeNode node)
        {
            return node.Body.Accept(this);
        }

        public object Visit(CoordinateXyValueNode node)
        {
return node;        }

        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }
    }
}