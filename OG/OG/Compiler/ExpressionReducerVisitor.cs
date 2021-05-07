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
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using OG.CodeGeneration;

namespace OG.Compiler
{
    public class ExpressionReducerVisitor : IVisitor, ISemanticErrorable
    {
        private SymbolTable _symbolTable;
        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        private readonly IMathNodeReducer _mathNodeReducer;


        public ExpressionReducerVisitor(SymbolTable symTab, List<SemanticError> errs)
        {
            SemanticErrors = errs;
            _symbolTable = symTab;
            _mathNodeReducer = new MathNodeReducer(symTab, errs);
        }
        
        public object Visit(BoolAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            
            throw new System.NotImplementedException();
        }

        public object Visit(IdAssignNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathAssignmentNode node)
        {
            NumberNode res = node.AssignedValue.Accept(_mathNodeReducer);
            node.AssignedValue = res;

            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ParameterTypeNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(CurveCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(DrawCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(LineCommandNode node)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// TODO Enter Body
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public object Visit(NumberIterationNode node)
        {
            NumberNode result = node.Iterations.Accept(_mathNodeReducer);
            node.Iterations = result;
            
            
            
            return new object();
        }

        
        public object Visit(UntilFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// TODO Enter Body
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public object Visit(UntilNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NumberDeclarationNode node)
        {
            //Number declarations' expressions are always math.
            // Caught in parser and type checking.
            MathNode mathNode = (MathNode) node.AssignedExpression;
            NumberNode res = mathNode.Accept(_mathNodeReducer);
            node.AssignedExpression = res;
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolExprIdNode node)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// TODO Enter Body
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public object Visit(BodyNode node)
        {
            foreach (StatementNode nodeStatementNode in node.StatementNodes)
            {
                nodeStatementNode.Accept(this);
            }

            return node;
        }

        public object Visit(AndComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(EqualsComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            NumberNode rhs = node.RHS.Accept(_mathNodeReducer);
            NumberNode lhs = node.LHS.Accept(_mathNodeReducer);
            node.RHS = rhs;
            node.LHS = lhs;
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NegationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(OrComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ParameterNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(AdditionNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        public object Visit(DivisionNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        
        /// <summary>
        /// TODO det bliver træls det her
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Visit(InfixMathNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathIdNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        public object Visit(MultiplicationNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        public object Visit(PowerNode node)
        {
            
            return node.Accept(_mathNodeReducer);
        }

        public object Visit(SubtractionNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        /// <summary>
        /// Det bliver måske også træls
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public object Visit(TerminalMathNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        public object Visit(PointFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointReferenceIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeEndPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapePointRefNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeStartPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(TuplePointNode node)
        {
            NumberNode x = node.XValue.Accept(_mathNodeReducer);
            NumberNode y = node.YValue.Accept(_mathNodeReducer);

            node.XValue = x;
            node.YValue = y;
            return node;
        }

        public object Visit(FalseNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NumberNode node)
        {
            return node.Accept(_mathNodeReducer);
        }

        public object Visit(TrueNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(SizePropertyNode node)
        {
            node.XMax = node.XMax.Accept(_mathNodeReducer);
            node.YMax = node.XMax.Accept(_mathNodeReducer);
            node.YMin = node.YMin.Accept(_mathNodeReducer);
            node.XMin = node.XMin.Accept(_mathNodeReducer);

            return node;
        }

        public object Visit(WorkAreaSettingNode node)
        {
            node.SizeProperty.Accept(this);
            return node;
        }

        public object Visit(AstNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(DrawNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ProgramNode node)
        {
            foreach (ShapeNode nodeShapeDcl in node.ShapeDcls)
            {
                nodeShapeDcl.Accept(this);
            }

            return node;
        }

        public object Visit(ShapeNode node)
        {
            node.Body.Accept(this);
            return node;
        }

        public object Visit(CoordinateXyValueNode node)
        {
            throw new System.NotImplementedException();
        }


    }
}