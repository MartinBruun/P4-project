// Generated from /Users/saxjax/developer/P4-project/OG/OG/OG.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link OGParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface OGVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link OGParser#program}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProgram(OGParser.ProgramContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#machineVariables}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMachineVariables(OGParser.MachineVariablesContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#machine}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMachine(OGParser.MachineContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#draw}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDraw(OGParser.DrawContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#shapeDefinition}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShapeDefinition(OGParser.ShapeDefinitionContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#body}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBody(OGParser.BodyContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeclaration(OGParser.DeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#booleanDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBooleanDeclaration(OGParser.BooleanDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#numberDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberDeclaration(OGParser.NumberDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointDeclaration(OGParser.PointDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#pointReference}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointReference(OGParser.PointReferenceContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#numberTuple}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberTuple(OGParser.NumberTupleContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#assignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAssignment(OGParser.AssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#propertyAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPropertyAssignment(OGParser.PropertyAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVariableAssignment(OGParser.VariableAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#idAssign}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIdAssign(OGParser.IdAssignContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#boolAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolAssignment(OGParser.BoolAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#numberAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberAssignment(OGParser.NumberAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#pointAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointAssignment(OGParser.PointAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#startPointAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStartPointAssignment(OGParser.StartPointAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#endPointAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEndPointAssignment(OGParser.EndPointAssignmentContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#expression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitExpression(OGParser.ExpressionContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMathExpression(OGParser.MathExpressionContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#term}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTerm(OGParser.TermContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#factor}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFactor(OGParser.FactorContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#atom}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAtom(OGParser.AtomContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExpression(OGParser.BoolExpressionContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#command}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCommand(OGParser.CommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#movementCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMovementCommand(OGParser.MovementCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#lineCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitLineCommand(OGParser.LineCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#curveCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCurveCommand(OGParser.CurveCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToCommand(OGParser.ToCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDrawCommand(OGParser.DrawCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#iterationCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIterationCommand(OGParser.IterationCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#numberIteration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberIteration(OGParser.NumberIterationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUntilIteration(OGParser.UntilIterationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#functionDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunctionDeclaration(OGParser.FunctionDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#returnFunctionDCL}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitReturnFunctionDCL(OGParser.ReturnFunctionDCLContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#typeWord}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTypeWord(OGParser.TypeWordContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#voidFunctionDCL}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitVoidFunctionDCL(OGParser.VoidFunctionDCLContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitParameterDeclarations(OGParser.ParameterDeclarationsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#parameters}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitParameters(OGParser.ParametersContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#functionCall}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunctionCall(OGParser.FunctionCallContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#parameterList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitParameterList(OGParser.ParameterListContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitReturnStatement(OGParser.ReturnStatementContext ctx);
}