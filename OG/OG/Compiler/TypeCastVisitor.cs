using System;
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

namespace OG.Compiler
{
    public class TypeCastVisitor : IVisitor
    {
        public object Visit(BoolAssignmentNode node)
        {
            return node;
        }

        public object Visit(FunctionCallAssignNode node)
        {
            return node;
        }

        public object Visit(IdAssignNode node)
        {
            return node;
        }

        public object Visit(MathAssignmentNode node)
        {
            return node;
        }

        public object Visit(PointAssignmentNode node)
        {
            return node;
        }

        public object Visit(PropertyAssignmentNode node)
        {
            return node;
        }

        public object Visit(ParameterTypeNode node)
        {
            return node;
        }

        public object Visit(CurveCommandNode node)
        {
            return node;
        }

        public object Visit(DrawCommandNode node)
        {
            return node;
        }

        public object Visit(LineCommandNode node)
        {
            return node;
        }

        public object Visit(NumberIterationNode node)
        {
            return node;
        }

        public object Visit(UntilFunctionCallNode node)
        {
            return node;
        }

        public object Visit(UntilNode node)
        {
            return node;
        }

        public object Visit(BoolDeclarationNode node)
        {
            return node;
        }

        public object Visit(NumberDeclarationNode node)
        {
            return node;
        }

        public object Visit(PointDeclarationNode node)
        {
            return node;
        }

        public object Visit(BoolExprIdNode node)
        {
            return node;
        }

        public object Visit(BodyNode node)
        {
            return node;
        }

        public object Visit(AndComparerNode node)
        {
            return node;
        }

        public object Visit(BoolNode node)
        {
            return node;
        }

        public object Visit(EqualsComparerNode node)
        {
            return node;
        }

        public object Visit(GreaterThanComparerNode node)
        {
            return node;
        }

        public object Visit(LessThanComparerNode node)
        {
            return node;
        }

        public object Visit(NegationNode node)
        {
            return node;
        }

        public object Visit(OrComparerNode node)
        {
            return node;
        }

        public object Visit(BoolFunctionCallNode node)
        {
            return node;
        }

        public object Visit(FunctionCallNode node)
        {
            return node;
        }

        public object Visit(FunctionCallParameterNode node)
        {
            return node;
        }

        public object Visit(MathFunctionCallNode node)
        {
            return node;
        }

        public object Visit(ParameterNode node)
        {
            return node;
        }

        public object Visit(FunctionNode node)
        {
            return node;
        }

        public object Visit(AdditionNode node)
        {
            return node;
        }

        public object Visit(DivisionNode node)
        {
            return node;
        }

        public object Visit(MathIdNode node)
        {
            return node;
        }

        public object Visit(MultiplicationNode node)
        {
            return node;
        }

        public object Visit(PowerNode node)
        {
            return node;
        }

        public object Visit(SubtractionNode node)
        {
            return node;
        }

        public object Visit(PointFunctionCallNode node)
        {
            return node;
        }

        public object Visit(PointReferenceIdNode node)
        {
            return node;
        }

        public object Visit(ShapeEndPointNode node)
        {
            return node;
        }

        public object Visit(ShapePointRefNode node)
        {
            return node;
        }

        public object Visit(ShapeStartPointNode node)
        {
            return node;
        }

        public object Visit(TuplePointNode node)
        {
            return node;
        }

        public object Visit(FalseNode node)
        {
            return node;
        }

        public object Visit(IdNode node)
        {
            return node;
        }

        public object Visit(NumberNode node)
        {
            return node;
        }

        public object Visit(TrueNode node)
        {
            return node;
        }

        public object Visit(SizePropertyNode node)
        {
            return node;
        }

        public object Visit(WorkAreaSettingNode node)
        {
            return node;
        }

        public object Visit(AstNode node)
        {
            return node;
        }

        public object Visit(DrawNode node)
        {
            return node;
        }

        public object Visit(ProgramNode node)
        {
            return node;
        }

        public object Visit(ShapeNode node)
        {
            return node;
        }

        public object Visit(CoordinateXyValueNode node)
        {
            return node;
        }
    }
}