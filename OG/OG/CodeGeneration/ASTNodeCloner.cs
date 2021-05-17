using System;
using System.Collections.Generic;
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

namespace OG.CodeGeneration
{
    public class ASTNodeCloner : IVisitor
    {
        public object Visit(BoolAssignmentNode node)
        {
            return new BoolAssignmentNode(node.Id,node.AssignedValue);
        }

        public object Visit(FunctionCallAssignNode node)
        {
            return new FunctionCallAssignNode(node.Id,node.FunctionName,node.Parameters);
        }

        public object Visit(IdAssignNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (IdNode) node.AssignedValue.Accept(this);
            return new IdAssignNode(node.Id,node.AssignedValue);
        }

        public object Visit(MathAssignmentNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (MathNode) node.AssignedValue.Accept(this);
            return new MathAssignmentNode(node.Id,node.AssignedValue);
        }

        public object Visit(PointAssignmentNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (PointReferenceNode) node.AssignedValue.Accept(this);
            return new PointAssignmentNode(node.Id, node.AssignedValue);
        }

        public object Visit(PropertyAssignmentNode node)
        {
            return new PropertyAssignmentNode(node.coordinateValueNode, node.assignedValue);
        }

        public object Visit(ParameterTypeNode node)
        {
            return node;
        }

        public object Visit(CurveCommandNode node)
        {
            node.From = (PointReferenceNode) node.From.Accept(this);
            List<PointReferenceNode> toList = new List<PointReferenceNode>();
            foreach (PointReferenceNode pointNode in node.To)
            {
                toList.Add((PointReferenceNode) pointNode.Accept(this));
            }
            node.To = toList;
            node.Angle = (MathNode) node.Angle.Accept(this);
            
            return new CurveCommandNode(node.From, node.To,node.Angle);
        }

        public object Visit(DrawCommandNode node)
        {
            return new DrawCommandNode(node.Id);
        }

        public object Visit(LineCommandNode node)
        {
            node.From = (PointReferenceNode) node.From.Accept(this);
            List<PointReferenceNode> toList = new List<PointReferenceNode>();
            foreach (PointReferenceNode pointNode in node.To)
            {
                toList.Add((PointReferenceNode) pointNode.Accept(this));
            }

            node.To = toList;
            
            return new LineCommandNode(node.From, node.To);
        }

        public object Visit(NumberIterationNode node)
        {
            return new NumberIterationNode(node.Iterations, node.Body);
        }

        public object Visit(UntilFunctionCallNode node)
        {
            return new UntilFunctionCallNode(node.Predicate, node.Body);
        }

        public object Visit(UntilNode node)
        {
            return new UntilNode(node.Predicate, node.Body);
        }

        public object Visit(BoolDeclarationNode node)
        {
            return new BoolDeclarationNode(node.Id,node.AssignedExpression);
        }

        public object Visit(NumberDeclarationNode node)
        {
            return new NumberDeclarationNode(node.Id, node.AssignedExpression);
        }

        public object Visit(PointDeclarationNode node)
        {
            return new PointDeclarationNode(node.Id, node.AssignedExpression);
        }

        public object Visit(BoolExprIdNode node)
        {
            return new BoolExprIdNode(node.Value,node.Id,(BoolNode.BoolType)node.ExprType);
        }

        public object Visit(BodyNode node)
        {
            List<StatementNode> tempBodyNodes = new List<StatementNode>();
            foreach (var statementNode in node.StatementNodes)
            {
                tempBodyNodes.Add((StatementNode)statementNode.Accept(this));
            }

            BodyNode body = new BodyNode(tempBodyNodes);
            return body;
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
            throw new System.NotImplementedException();
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
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new AdditionNode(node);
        }

        public object Visit(DivisionNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new DivisionNode(node.RHS,node.LHS);
        }

        public object Visit(MathIdNode node)
        {
            node.AssignedValueId = (IdNode) node.AssignedValueId.Accept(this);
            return new MathIdNode(node);
        }

        public object Visit(MultiplicationNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new MultiplicationNode(node.RHS,node.LHS);
        }

        public object Visit(PowerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(SubtractionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointReferenceIdNode node)
        {
            return new PointReferenceIdNode(node.Value,node.AssignedValue);
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
            node.XValue = (MathNode) node.XValue.Accept(this);
            node.YValue = (MathNode) node.YValue.Accept(this);
            return new TuplePointNode(node.Value,node.XValue, node.YValue);
        }

        public object Visit(FalseNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IdNode node)
        {
            node.DeclaredValue = (AstNode) node.DeclaredValue.Accept(this);
            return new IdNode(node);
        }

        public object Visit(NumberNode node)
        {
            return new NumberNode(node.NumberValue);
        }

        public object Visit(TrueNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(SizePropertyNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(AstNode node)
        {
            return node;
        }

        public object Visit(DrawNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ProgramNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(CoordinateXyValueNode node)
        {
            return new CoordinateXyValueNode(node.Value,node.MathNodeType);
        }
    }
}