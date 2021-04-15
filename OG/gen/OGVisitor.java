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
	 * Visit a parse tree produced by the {@code prog}
	 * labeled alternative in {@link OGParser#program}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProg(OGParser.ProgContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#machineSettings}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMachineSettings(OGParser.MachineSettingsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#machineMods}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMachineMods(OGParser.MachineModsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#workAreaMod}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitWorkAreaMod(OGParser.WorkAreaModContext ctx);
	/**
	 * Visit a parse tree produced by the {@code workAreaModifierProperties}
	 * labeled alternative in {@link OGParser#workAreaModPrpts}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitWorkAreaModifierProperties(OGParser.WorkAreaModifierPropertiesContext ctx);
	/**
	 * Visit a parse tree produced by the {@code endOfWorkAreaModifierProperties}
	 * labeled alternative in {@link OGParser#workAreaModPrpts}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEndOfWorkAreaModifierProperties(OGParser.EndOfWorkAreaModifierPropertiesContext ctx);
	/**
	 * Visit a parse tree produced by the {@code sizeProperty}
	 * labeled alternative in {@link OGParser#sizePrpt}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSizeProperty(OGParser.SizePropertyContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#workAreaVars}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitWorkAreaVars(OGParser.WorkAreaVarsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#shapeDcls}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShapeDcls(OGParser.ShapeDclsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#functionDcls}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunctionDcls(OGParser.FunctionDclsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#draw}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDraw(OGParser.DrawContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#drawCommands}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDrawCommands(OGParser.DrawCommandsContext ctx);
	/**
	 * Visit a parse tree produced by the {@code drawCmd}
	 * labeled alternative in {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDrawCmd(OGParser.DrawCmdContext ctx);
	/**
	 * Visit a parse tree produced by the {@code drawFromCmd}
	 * labeled alternative in {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDrawFromCmd(OGParser.DrawFromCmdContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#shapeDcl}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShapeDcl(OGParser.ShapeDclContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#body}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBody(OGParser.BodyContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#stmts}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStmts(OGParser.StmtsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#stmt}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStmt(OGParser.StmtContext ctx);
	/**
	 * Visit a parse tree produced by the {@code assgnments}
	 * labeled alternative in {@link OGParser#assignments}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAssgnments(OGParser.AssgnmentsContext ctx);
	/**
	 * Visit a parse tree produced by the {@code noAssignmentsDefined}
	 * labeled alternative in {@link OGParser#assignments}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNoAssignmentsDefined(OGParser.NoAssignmentsDefinedContext ctx);
	/**
	 * Visit a parse tree produced by the {@code dcls}
	 * labeled alternative in {@link OGParser#declarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDcls(OGParser.DclsContext ctx);
	/**
	 * Visit a parse tree produced by the {@code noDeclarationsDefined}
	 * labeled alternative in {@link OGParser#declarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNoDeclarationsDefined(OGParser.NoDeclarationsDefinedContext ctx);
	/**
	 * Visit a parse tree produced by the {@code cmds}
	 * labeled alternative in {@link OGParser#commands}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCmds(OGParser.CmdsContext ctx);
	/**
	 * Visit a parse tree produced by the {@code noCmdsDeclared}
	 * labeled alternative in {@link OGParser#commands}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNoCmdsDeclared(OGParser.NoCmdsDeclaredContext ctx);
	/**
	 * Visit a parse tree produced by the {@code numberDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberDcl(OGParser.NumberDclContext ctx);
	/**
	 * Visit a parse tree produced by the {@code pointDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointDcl(OGParser.PointDclContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolDcl(OGParser.BoolDclContext ctx);
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
	 * Visit a parse tree produced by the {@code pointDclPointRefAssign}
	 * labeled alternative in {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointDclPointRefAssign(OGParser.PointDclPointRefAssignContext ctx);
	/**
	 * Visit a parse tree produced by the {@code pointDclIdAssign}
	 * labeled alternative in {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointDclIdAssign(OGParser.PointDclIdAssignContext ctx);
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
	 * Visit a parse tree produced by the {@code idAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIdAssign(OGParser.IdAssignContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolAssign(OGParser.BoolAssignContext ctx);
	/**
	 * Visit a parse tree produced by the {@code numberAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberAssign(OGParser.NumberAssignContext ctx);
	/**
	 * Visit a parse tree produced by the {@code pointAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointAssign(OGParser.PointAssignContext ctx);
	/**
	 * Visit a parse tree produced by the {@code functionCallAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunctionCallAssign(OGParser.FunctionCallAssignContext ctx);
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
	 * Visit a parse tree produced by the {@code infixAdditionExpr}
	 * labeled alternative in {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitInfixAdditionExpr(OGParser.InfixAdditionExprContext ctx);
	/**
	 * Visit a parse tree produced by the {@code singleTermExpr}
	 * labeled alternative in {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSingleTermExpr(OGParser.SingleTermExprContext ctx);
	/**
	 * Visit a parse tree produced by the {@code infixMultExpr}
	 * labeled alternative in {@link OGParser#term}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitInfixMultExpr(OGParser.InfixMultExprContext ctx);
	/**
	 * Visit a parse tree produced by the {@code singleTermChild}
	 * labeled alternative in {@link OGParser#term}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSingleTermChild(OGParser.SingleTermChildContext ctx);
	/**
	 * Visit a parse tree produced by the {@code powerExpr}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPowerExpr(OGParser.PowerExprContext ctx);
	/**
	 * Visit a parse tree produced by the {@code singleAtom}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSingleAtom(OGParser.SingleAtomContext ctx);
	/**
	 * Visit a parse tree produced by the {@code parenthesisMathExpr}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitParenthesisMathExpr(OGParser.ParenthesisMathExprContext ctx);
	/**
	 * Visit a parse tree produced by the {@code atomfuncCall}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAtomfuncCall(OGParser.AtomfuncCallContext ctx);
	/**
	 * Visit a parse tree produced by the {@code number}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumber(OGParser.NumberContext ctx);
	/**
	 * Visit a parse tree produced by the {@code atomXYValue}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAtomXYValue(OGParser.AtomXYValueContext ctx);
	/**
	 * Visit a parse tree produced by the {@code atomId}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAtomId(OGParser.AtomIdContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolExprID}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExprID(OGParser.BoolExprIDContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolExprBoolComp}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExprBoolComp(OGParser.BoolExprBoolCompContext ctx);
	/**
	 * Visit a parse tree produced by the {@code parenthesisBoolExpr}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitParenthesisBoolExpr(OGParser.ParenthesisBoolExprContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolExprMathComp}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExprMathComp(OGParser.BoolExprMathCompContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolExprNotPrefix}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExprNotPrefix(OGParser.BoolExprNotPrefixContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolExprTrueFalse}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExprTrueFalse(OGParser.BoolExprTrueFalseContext ctx);
	/**
	 * Visit a parse tree produced by the {@code boolExprFuncCall}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitBoolExprFuncCall(OGParser.BoolExprFuncCallContext ctx);
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
	 * Visit a parse tree produced by {@link OGParser#toCommands}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToCommands(OGParser.ToCommandsContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#curveCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCurveCommand(OGParser.CurveCommandContext ctx);
	/**
	 * Visit a parse tree produced by the {@code toWithId}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToWithId(OGParser.ToWithIdContext ctx);
	/**
	 * Visit a parse tree produced by the {@code toWithNumberTuple}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToWithNumberTuple(OGParser.ToWithNumberTupleContext ctx);
	/**
	 * Visit a parse tree produced by the {@code toWithStartPointRef}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToWithStartPointRef(OGParser.ToWithStartPointRefContext ctx);
	/**
	 * Visit a parse tree produced by the {@code toWithEndPointRef}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToWithEndPointRef(OGParser.ToWithEndPointRefContext ctx);
	/**
	 * Visit a parse tree produced by the {@code fromWithId}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFromWithId(OGParser.FromWithIdContext ctx);
	/**
	 * Visit a parse tree produced by the {@code fromWithNumberTuple}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFromWithNumberTuple(OGParser.FromWithNumberTupleContext ctx);
	/**
	 * Visit a parse tree produced by the {@code fromWithStartPointRef}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFromWithStartPointRef(OGParser.FromWithStartPointRefContext ctx);
	/**
	 * Visit a parse tree produced by the {@code fromWithEndPointRef}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFromWithEndPointRef(OGParser.FromWithEndPointRefContext ctx);
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
	 * Visit a parse tree produced by the {@code untilFuncCall}
	 * labeled alternative in {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUntilFuncCall(OGParser.UntilFuncCallContext ctx);
	/**
	 * Visit a parse tree produced by the {@code untilCondition}
	 * labeled alternative in {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUntilCondition(OGParser.UntilConditionContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#functionDcl}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunctionDcl(OGParser.FunctionDclContext ctx);
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
	 * Visit a parse tree produced by the {@code multiParamDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMultiParamDcl(OGParser.MultiParamDclContext ctx);
	/**
	 * Visit a parse tree produced by the {@code singleParamDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSingleParamDcl(OGParser.SingleParamDclContext ctx);
	/**
	 * Visit a parse tree produced by the {@code noParamsDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNoParamsDcl(OGParser.NoParamsDclContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#parameterDcl}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitParameterDcl(OGParser.ParameterDclContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#functionCall}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFunctionCall(OGParser.FunctionCallContext ctx);
	/**
	 * Visit a parse tree produced by the {@code multiParameters}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMultiParameters(OGParser.MultiParametersContext ctx);
	/**
	 * Visit a parse tree produced by the {@code singleParameter}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitSingleParameter(OGParser.SingleParameterContext ctx);
	/**
	 * Visit a parse tree produced by the {@code noParameter}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNoParameter(OGParser.NoParameterContext ctx);
	/**
	 * Visit a parse tree produced by the {@code passedID}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPassedID(OGParser.PassedIDContext ctx);
	/**
	 * Visit a parse tree produced by the {@code passedFunctionCall}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPassedFunctionCall(OGParser.PassedFunctionCallContext ctx);
	/**
	 * Visit a parse tree produced by the {@code passedDirectValue}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPassedDirectValue(OGParser.PassedDirectValueContext ctx);
	/**
	 * Visit a parse tree produced by the {@code passedEndPointReference}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPassedEndPointReference(OGParser.PassedEndPointReferenceContext ctx);
	/**
	 * Visit a parse tree produced by the {@code passedStartPointReference}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPassedStartPointReference(OGParser.PassedStartPointReferenceContext ctx);
	/**
	 * Visit a parse tree produced by the {@code returnValueReference}
	 * labeled alternative in {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitReturnValueReference(OGParser.ReturnValueReferenceContext ctx);
	/**
	 * Visit a parse tree produced by the {@code returnDirectValue}
	 * labeled alternative in {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitReturnDirectValue(OGParser.ReturnDirectValueContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#startPointReference}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStartPointReference(OGParser.StartPointReferenceContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#endPointReference}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEndPointReference(OGParser.EndPointReferenceContext ctx);
	/**
	 * Visit a parse tree produced by {@link OGParser#coordinateXYValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCoordinateXYValue(OGParser.CoordinateXYValueContext ctx);
}