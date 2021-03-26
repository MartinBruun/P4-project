// Generated from /Users/saxjax/developer/P4-project/OG/OG/OG.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link OGParser}.
 */
public interface OGListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link OGParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(OGParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(OGParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#machineVariables}.
	 * @param ctx the parse tree
	 */
	void enterMachineVariables(OGParser.MachineVariablesContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#machineVariables}.
	 * @param ctx the parse tree
	 */
	void exitMachineVariables(OGParser.MachineVariablesContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#machine}.
	 * @param ctx the parse tree
	 */
	void enterMachine(OGParser.MachineContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#machine}.
	 * @param ctx the parse tree
	 */
	void exitMachine(OGParser.MachineContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#draw}.
	 * @param ctx the parse tree
	 */
	void enterDraw(OGParser.DrawContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#draw}.
	 * @param ctx the parse tree
	 */
	void exitDraw(OGParser.DrawContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#shapeDefinition}.
	 * @param ctx the parse tree
	 */
	void enterShapeDefinition(OGParser.ShapeDefinitionContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#shapeDefinition}.
	 * @param ctx the parse tree
	 */
	void exitShapeDefinition(OGParser.ShapeDefinitionContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#body}.
	 * @param ctx the parse tree
	 */
	void enterBody(OGParser.BodyContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#body}.
	 * @param ctx the parse tree
	 */
	void exitBody(OGParser.BodyContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration(OGParser.DeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration(OGParser.DeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#booleanDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterBooleanDeclaration(OGParser.BooleanDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#booleanDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitBooleanDeclaration(OGParser.BooleanDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#numberDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterNumberDeclaration(OGParser.NumberDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#numberDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitNumberDeclaration(OGParser.NumberDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterPointDeclaration(OGParser.PointDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitPointDeclaration(OGParser.PointDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#pointReference}.
	 * @param ctx the parse tree
	 */
	void enterPointReference(OGParser.PointReferenceContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#pointReference}.
	 * @param ctx the parse tree
	 */
	void exitPointReference(OGParser.PointReferenceContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#numberTuple}.
	 * @param ctx the parse tree
	 */
	void enterNumberTuple(OGParser.NumberTupleContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#numberTuple}.
	 * @param ctx the parse tree
	 */
	void exitNumberTuple(OGParser.NumberTupleContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#assignment}.
	 * @param ctx the parse tree
	 */
	void enterAssignment(OGParser.AssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#assignment}.
	 * @param ctx the parse tree
	 */
	void exitAssignment(OGParser.AssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#propertyAssignment}.
	 * @param ctx the parse tree
	 */
	void enterPropertyAssignment(OGParser.PropertyAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#propertyAssignment}.
	 * @param ctx the parse tree
	 */
	void exitPropertyAssignment(OGParser.PropertyAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void enterVariableAssignment(OGParser.VariableAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void exitVariableAssignment(OGParser.VariableAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#idAssign}.
	 * @param ctx the parse tree
	 */
	void enterIdAssign(OGParser.IdAssignContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#idAssign}.
	 * @param ctx the parse tree
	 */
	void exitIdAssign(OGParser.IdAssignContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#boolAssignment}.
	 * @param ctx the parse tree
	 */
	void enterBoolAssignment(OGParser.BoolAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#boolAssignment}.
	 * @param ctx the parse tree
	 */
	void exitBoolAssignment(OGParser.BoolAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#numberAssignment}.
	 * @param ctx the parse tree
	 */
	void enterNumberAssignment(OGParser.NumberAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#numberAssignment}.
	 * @param ctx the parse tree
	 */
	void exitNumberAssignment(OGParser.NumberAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#pointAssignment}.
	 * @param ctx the parse tree
	 */
	void enterPointAssignment(OGParser.PointAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#pointAssignment}.
	 * @param ctx the parse tree
	 */
	void exitPointAssignment(OGParser.PointAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#startPointAssignment}.
	 * @param ctx the parse tree
	 */
	void enterStartPointAssignment(OGParser.StartPointAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#startPointAssignment}.
	 * @param ctx the parse tree
	 */
	void exitStartPointAssignment(OGParser.StartPointAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#endPointAssignment}.
	 * @param ctx the parse tree
	 */
	void enterEndPointAssignment(OGParser.EndPointAssignmentContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#endPointAssignment}.
	 * @param ctx the parse tree
	 */
	void exitEndPointAssignment(OGParser.EndPointAssignmentContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterExpression(OGParser.ExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitExpression(OGParser.ExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 */
	void enterMathExpression(OGParser.MathExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 */
	void exitMathExpression(OGParser.MathExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#term}.
	 * @param ctx the parse tree
	 */
	void enterTerm(OGParser.TermContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#term}.
	 * @param ctx the parse tree
	 */
	void exitTerm(OGParser.TermContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void enterFactor(OGParser.FactorContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void exitFactor(OGParser.FactorContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void enterAtom(OGParser.AtomContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void exitAtom(OGParser.AtomContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExpression(OGParser.BoolExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExpression(OGParser.BoolExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#command}.
	 * @param ctx the parse tree
	 */
	void enterCommand(OGParser.CommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#command}.
	 * @param ctx the parse tree
	 */
	void exitCommand(OGParser.CommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#movementCommand}.
	 * @param ctx the parse tree
	 */
	void enterMovementCommand(OGParser.MovementCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#movementCommand}.
	 * @param ctx the parse tree
	 */
	void exitMovementCommand(OGParser.MovementCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#lineCommand}.
	 * @param ctx the parse tree
	 */
	void enterLineCommand(OGParser.LineCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#lineCommand}.
	 * @param ctx the parse tree
	 */
	void exitLineCommand(OGParser.LineCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#curveCommand}.
	 * @param ctx the parse tree
	 */
	void enterCurveCommand(OGParser.CurveCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#curveCommand}.
	 * @param ctx the parse tree
	 */
	void exitCurveCommand(OGParser.CurveCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToCommand(OGParser.ToCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToCommand(OGParser.ToCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 */
	void enterDrawCommand(OGParser.DrawCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 */
	void exitDrawCommand(OGParser.DrawCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#iterationCommand}.
	 * @param ctx the parse tree
	 */
	void enterIterationCommand(OGParser.IterationCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#iterationCommand}.
	 * @param ctx the parse tree
	 */
	void exitIterationCommand(OGParser.IterationCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#numberIteration}.
	 * @param ctx the parse tree
	 */
	void enterNumberIteration(OGParser.NumberIterationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#numberIteration}.
	 * @param ctx the parse tree
	 */
	void exitNumberIteration(OGParser.NumberIterationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 */
	void enterUntilIteration(OGParser.UntilIterationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 */
	void exitUntilIteration(OGParser.UntilIterationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#functionDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDeclaration(OGParser.FunctionDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#functionDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDeclaration(OGParser.FunctionDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#returnFunctionDCL}.
	 * @param ctx the parse tree
	 */
	void enterReturnFunctionDCL(OGParser.ReturnFunctionDCLContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#returnFunctionDCL}.
	 * @param ctx the parse tree
	 */
	void exitReturnFunctionDCL(OGParser.ReturnFunctionDCLContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#typeWord}.
	 * @param ctx the parse tree
	 */
	void enterTypeWord(OGParser.TypeWordContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#typeWord}.
	 * @param ctx the parse tree
	 */
	void exitTypeWord(OGParser.TypeWordContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#voidFunctionDCL}.
	 * @param ctx the parse tree
	 */
	void enterVoidFunctionDCL(OGParser.VoidFunctionDCLContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#voidFunctionDCL}.
	 * @param ctx the parse tree
	 */
	void exitVoidFunctionDCL(OGParser.VoidFunctionDCLContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void enterParameterDeclarations(OGParser.ParameterDeclarationsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void exitParameterDeclarations(OGParser.ParameterDeclarationsContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#parameters}.
	 * @param ctx the parse tree
	 */
	void enterParameters(OGParser.ParametersContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#parameters}.
	 * @param ctx the parse tree
	 */
	void exitParameters(OGParser.ParametersContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void enterFunctionCall(OGParser.FunctionCallContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#functionCall}.
	 * @param ctx the parse tree
	 */
	void exitFunctionCall(OGParser.FunctionCallContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#parameterList}.
	 * @param ctx the parse tree
	 */
	void enterParameterList(OGParser.ParameterListContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#parameterList}.
	 * @param ctx the parse tree
	 */
	void exitParameterList(OGParser.ParameterListContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 */
	void enterReturnStatement(OGParser.ReturnStatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 */
	void exitReturnStatement(OGParser.ReturnStatementContext ctx);
}