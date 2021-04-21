using System;
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

namespace OG.AstVisiting
{
    public interface IVisitor
    {
        public Object Visit(AssignmentNode node);
        public Object Visit(BoolAssignmentNode node);
        public Object Visit(FunctionCallAssignNode node);
        public Object Visit(IdAssignNode node);
        public Object Visit(MathAssignmentNode node);
        public Object Visit(PointAssignmentNode node);
        public Object Visit(PropertyAssignmentNode node);
        
        //
        public Object Visit(CommandNode node);
        public Object Visit(CurveCommandNode node);
        public Object Visit(DrawCommandNode node);
        public Object Visit(IterationNode node);
        public Object Visit(LineCommandNode node);
        public Object Visit(MovementCommandNode node);
        public Object Visit(NumberIterationNode node);
        public Object Visit(UntilFunctionCallNode node);
        public Object Visit(UntilNode node);
        
        
        //
        public Object Visit(BoolDeclarationNode node);
        public Object Visit(DeclarationNode node);
        public Object Visit(NumberDeclarationNode node);
        public Object Visit(PointDeclarationNode node);

        public Object visit(BoolExprIdNode node);
        
        //
        public Object Visit(StatementNode node);
        public Object Visit(BodyNode node);
        
        //Bool
        public Object Visit(AndComparerNode node);
        public Object Visit(BoolComparerNode node);
        public Object Visit(BoolNode node);
        public Object Visit(BoolTerminalNode node);
        public Object Visit(EqualsComparerNode node);
        public Object Visit(GreaterThanComparerNode node);
        public Object Visit(LessThanComparerNode node);
        public Object Visit(MathComparerNode node);
        public Object Visit(NegationNode node);
        public Object Visit(OrComparerNode node);
        
        //Func Cals
        public Object Visit(BoolFunctionCallNode node);
        public Object Visit(FunctionCallNode node);
        public Object Visit(FunctionCallParameterNode node);
        public Object Visit(IFunctionCallNode node);
        public Object Visit(MathFunctionCallNode node);
        public Object Visit(ParameterNode node);
        
        //
        public Object Visit(FunctionNode node);
        public Object Visit(IFunctionNode node);
        
        //Math
        public Object Visit(AdditionNode node);
        public Object Visit(DivisionNode node);
        public Object Visit(InfixMathNode node);
        public Object Visit(MathIdNode node);
        public Object Visit(MathNode node);
        public Object Visit(MultiplicationNode node);
        public Object Visit(PowerNode node);
        public Object Visit(SubtractionNode node);
        public Object Visit(TerminalMathNode node);
        
        //Point
        public Object Visit(PointFunctionCallNode node);
        public Object Visit(PointReferenceIdNode node);
        public Object Visit(PointReferenceNode node);
        public Object Visit(ShapeEndPointNode node);
        public Object Visit(ShapePointReference node);
        public Object Visit(ShapePointRefNode node);
        public Object Visit(ShapeStartPointNode node);
        public Object Visit(TuplePointNode node);
        
        //Terminal
        public Object Visit(FalseNode node);
        public Object Visit(IdNode node);
        public Object Visit(NumberNode node);
        public Object Visit(TrueNode node);
        
        //WorkArea
        public Object Visit(MachineSettingNode node);
        public Object Visit(ModificationPropertyNode node);
        public Object Visit(SizePropertyNode node);
        public Object Visit(WorkAreaSettingNode node);
        
        //
        public Object Visit(AstNode node);
        public Object Visit(DrawNode node);
        public Object Visit(ExpressionNode node);
        public Object Visit(ProgramNode node);
        public Object Visit(ShapeNode node);
        public Object Visit(CoordinateXyValueNode node);



            
    }
}