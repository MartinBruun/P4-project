using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (BoolNode) node.AssignedValue.Accept(this);
            return new BoolAssignmentNode(node);
        }

        public object Visit(FunctionCallAssignNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.FunctionName = (IdNode) node.FunctionName.Accept(this);
            List<ParameterNode> tempParamNodes = new List<ParameterNode>();
            foreach (var paramNode in node.Parameters)
            {
                tempParamNodes.Add((ParameterNode)paramNode.Accept(this));
            }

            node.Parameters = tempParamNodes;

            return new FunctionCallAssignNode(node);
        }

        public object Visit(IdAssignNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (IdNode) node.AssignedValue.Accept(this);
            return new IdAssignNode(node);
        }

        public object Visit(MathAssignmentNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (MathNode) node.AssignedValue.Accept(this);
            return new MathAssignmentNode(node);
        }

        public object Visit(PointAssignmentNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedValue = (PointReferenceNode) node.AssignedValue.Accept(this);
            return new PointAssignmentNode(node);
        }

        public object Visit(PropertyAssignmentNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.assignedValue = (MathNode) node.assignedValue.Accept(this);
            // TODO: Not implemented yet.
            //node.coordinateValueNode = (CoordinateXyValueNode) node.coordinateValueNode.Accept(this);
            return new PropertyAssignmentNode(node.coordinateValueNode, node.assignedValue);
        }

        public object Visit(ParameterTypeNode node)
        {
            node.IdNode = (IdNode) node.IdNode.Accept(this);
            node.Expression = (ExpressionNode) node.Expression.Accept(this);
            return new ParameterTypeNode(node);
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
            
            return new CurveCommandNode(node);
        }

        public object Visit(DrawCommandNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            // TODO: Not implemented yet!
            // node.From = (PointReferenceNode) node.From.Accept(this);
            return new DrawCommandNode(node);
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
            
            return new LineCommandNode(node);
        }

        public object Visit(NumberIterationNode node)
        {
            node.Iterations = (MathNode) node.Iterations.Accept(this);
            node.Body = (BodyNode) node.Body.Accept(this);
            return new NumberIterationNode(node);
        }

        public object Visit(UntilFunctionCallNode node)
        {
            node.Predicate = (FunctionCallNode) node.Predicate.Accept(this);
            node.Body = (BodyNode) node.Body.Accept(this);
            return new UntilFunctionCallNode(node);
        }

        public object Visit(UntilNode node)
        {
            node.Predicate = (BoolNode) node.Predicate.Accept(this);
            node.Body = (BodyNode) node.Body.Accept(this);
            return new UntilNode(node);
        }

        public object Visit(BoolDeclarationNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedExpression = (BoolNode) node.AssignedExpression.Accept(this);
            return new BoolDeclarationNode(node);
        }

        public object Visit(NumberDeclarationNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedExpression = (ExpressionNode) node.AssignedExpression.Accept(this);
            return new NumberDeclarationNode(node);
        }

        public object Visit(PointDeclarationNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.AssignedExpression = (ExpressionNode) node.AssignedExpression.Accept(this);
            return new PointDeclarationNode(node);
        }

        public object Visit(BoolExprIdNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            return new BoolExprIdNode(node);
        }

        public object Visit(BodyNode node)
        {
            List<StatementNode> tempBodyNodes = new List<StatementNode>();
            foreach (var statementNode in node.StatementNodes)
            {
                tempBodyNodes.Add((StatementNode)statementNode.Accept(this));
            }

            node.StatementNodes = tempBodyNodes;

            return new BodyNode(node);
        }

        public object Visit(AndComparerNode node)
        {
            node.LHS = (BoolNode) node.LHS.Accept(this);
            node.RHS = (BoolNode) node.RHS.Accept(this);
            return new AndComparerNode(node);
        }

        public object Visit(BoolNode node)
        {
            // TODO: Implement this when BoolNode is implemented, if at all :P
            return node;
        }

        public object Visit(EqualsComparerNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new EqualsComparerNode(node);
        }

        public object Visit(GreaterThanComparerNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new GreaterThanComparerNode(node);
        }

        public object Visit(LessThanComparerNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new LessThanComparerNode(node);
        }

        public object Visit(NegationNode node)
        {
            node.BoolExpression = (BoolNode) node.BoolExpression.Accept(this);
            return new NegationNode(node);
        }

        public object Visit(OrComparerNode node)
        {
            node.LHS = (BoolNode) node.LHS.Accept(this);
            node.RHS = (BoolNode) node.RHS.Accept(this);
            return new OrComparerNode(node);
        }

        public object Visit(BoolFunctionCallNode node)
        {
            node.FunctionName = (IdNode) node.FunctionName.Accept(this);
            List<ParameterNode> tempParamNodes = new List<ParameterNode>();
            foreach (var paramNode in node.Parameters)
            {
                tempParamNodes.Add((ParameterNode)paramNode.Accept(this));
            }

            node.Parameters = tempParamNodes;

            return new BoolFunctionCallNode(node);
        }

        public object Visit(FunctionCallNode node)
        {
            node.FunctionName = (IdNode) node.FunctionName.Accept(this);
            List<ParameterNode> tempParamNodes = new List<ParameterNode>();
            foreach (var paramNode in node.Parameters)
            {
                tempParamNodes.Add((ParameterNode)paramNode.Accept(this));
            }

            node.Parameters = tempParamNodes;

            return new FunctionCallNode(node);
        }

        public object Visit(FunctionCallParameterNode node)
        {
            node.ParameterId = (IdNode) node.ParameterId.Accept(this);
            node.FunctionCallNode = (FunctionCallNode) node.FunctionCallNode.Accept(this);
            node.Expression = (ExpressionNode) node.Expression.Accept(this);
            return new FunctionCallParameterNode(node);
        }

        public object Visit(MathFunctionCallNode node)
        {
            node.FunctionName = (IdNode) node.FunctionName.Accept(this);
            List<ParameterNode> tempParamNodes = new List<ParameterNode>();
            foreach (var paramNode in node.Parameters)
            {
                tempParamNodes.Add((ParameterNode)paramNode.Accept(this));
            }

            node.Parameters = tempParamNodes;

            return new MathFunctionCallNode(node);
        }

        public object Visit(ParameterNode node)
        {//TODO: add formal parameter id in typechecker.        node.ParameterId = (IdNode) node.ParameterId.Accept(this);
            node.ParameterId = (IdNode) node.ParameterId.Accept(this);
            node.Expression = (ExpressionNode) node.Expression.Accept(this);
            return new ParameterNode(node);
        }

        public object Visit(FunctionNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            // TODO: node.Type as ParameterNode sounds wrong...
            node.Type = (ParameterNode) node.Type.Accept(this);
            node.Body = (BodyNode) node.Body.Accept(this);
            
            List<ParameterTypeNode> tempParamNodes = new List<ParameterTypeNode>();
            foreach (var paramNode in node.Parameters)
            {
                tempParamNodes.Add((ParameterTypeNode)paramNode.Accept(this));
            }

            node.Parameters = tempParamNodes;
            node.ReturnValue = (ExpressionNode) node.ReturnValue.Accept(this);

            return new FunctionNode(node);
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
            return new DivisionNode(node);
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
            return new MultiplicationNode(node);
        }

        public object Visit(PowerNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new PowerNode(node);
        }

        public object Visit(SubtractionNode node)
        {
            node.LHS = (MathNode) node.LHS.Accept(this);
            node.RHS = (MathNode) node.RHS.Accept(this);
            return new SubtractionNode(node);
        }

        public object Visit(PointFunctionCallNode node)
        {
            node.FunctionName = (IdNode) node.FunctionName.Accept(this);

            List<ParameterNode> tempParamNodes = new List<ParameterNode>();
            foreach (var paramNode in node.Parameters)
            {
                tempParamNodes.Add((ParameterNode)paramNode.Accept(this));
            }

            node.Parameters = tempParamNodes;

            return new PointFunctionCallNode(node);
        }

        public object Visit(PointReferenceIdNode node)
        {
            node.AssignedValue = (IdNode) node.AssignedValue.Accept(this);
            return new PointReferenceIdNode(node);
        }

        public object Visit(ShapeEndPointNode node)
        {
            node.ShapeName = (IdNode) node.ShapeName.Accept(this);
            return new ShapeEndPointNode(node);
        }

        public object Visit(ShapePointRefNode node)
        {
            node.ShapeNameId = (IdNode) node.ShapeNameId.Accept(this);
            return new ShapePointRefNode(node);
        }

        public object Visit(ShapeStartPointNode node)
        {
            node.ShapeName = (IdNode) node.ShapeName.Accept(this);
            return new ShapeStartPointNode(node);
        }

        public object Visit(TuplePointNode node)
        {
            node.XValue = (MathNode) node.XValue.Accept(this);
            node.YValue = (MathNode) node.YValue.Accept(this);
            return new TuplePointNode(node);
        }

        public object Visit(FalseNode node)
        {
            return new FalseNode(node);
        }

        public object Visit(IdNode node)
        {
            return new IdNode(node);
        }

        public object Visit(NumberNode node)
        {
            return new NumberNode(node);
        }

        public object Visit(TrueNode node)
        {
            return new TrueNode(node);
        }

        public object Visit(SizePropertyNode node)
        {
            node.XMin = (MathNode) node.XMin.Accept(this);
            node.XMax = (MathNode) node.XMax.Accept(this);
            node.YMin = (MathNode) node.YMin.Accept(this);
            node.YMax = (MathNode) node.YMax.Accept(this);
            node.ZMin = (MathNode) node.ZMin.Accept(this);
            node.ZMax = (MathNode) node.ZMax.Accept(this);
            return new SizePropertyNode(node);
        }

        public object Visit(WorkAreaSettingNode node)
        {
            return new WorkAreaSettingNode(node);
        }

        public object Visit(AstNode node)
        {
            return node;
        }

        public object Visit(DrawNode node)
        {
            List<DrawCommandNode> tempDrawCommands = new List<DrawCommandNode>();
            foreach (var drawCommand in node.drawCommands)
            {
                tempDrawCommands.Add((DrawCommandNode) drawCommand.Accept(this));
            }

            node.drawCommands = tempDrawCommands;

            return new DrawNode(node);
        }

        public object Visit(ProgramNode node)
        {
            List<MachineSettingNode> tempMachineSettings = new List<MachineSettingNode>();
            foreach (var setting in node.MachineSettingNodes)
            {
                tempMachineSettings.Add((MachineSettingNode) setting.Accept(this));
            }

            node.MachineSettingNodes = tempMachineSettings;

            node.drawNode = (DrawNode) node.drawNode.Accept(this);
            
            List<FunctionNode> tempFunctionDcls = new List<FunctionNode>();
            foreach (var functionDcl in node.FunctionDcls)
            {
                tempFunctionDcls.Add((FunctionNode) functionDcl.Accept(this));
            }

            node.FunctionDcls = tempFunctionDcls;
            
            List<ShapeNode> tempShapeDcls = new List<ShapeNode>();
            foreach (var shapeDcl in node.ShapeDcls)
            {
                tempShapeDcls.Add((ShapeNode) shapeDcl.Accept(this));
            }

            node.ShapeDcls = tempShapeDcls;

            return new ProgramNode(node);
        }

        public object Visit(ShapeNode node)
        {
            node.Id = (IdNode) node.Id.Accept(this);
            node.Body = (BodyNode) node.Body.Accept(this);
            return new ShapeNode(node);
        }

        public object Visit(CoordinateXyValueNode node)
        {
            throw new NotImplementedException(
                $"point.x or point.y is NOT implemented yet!\n" +
                "Error discovered at Line: {node.Line} and Column: {node.Column}" + 
                "This error was made by ASTNodeCloner in CodeGeneration in the bottom of the visit methods!");
        }
    }
}