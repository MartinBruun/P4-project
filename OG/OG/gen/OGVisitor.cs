//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Martin/projects/P4/P4-project/OG/OG\OG.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="OGParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface IOGVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>prog</c>
	/// labeled alternative in <see cref="OGParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] OGParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.machineSettings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMachineSettings([NotNull] OGParser.MachineSettingsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.machineMods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMachineMods([NotNull] OGParser.MachineModsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.workAreaMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWorkAreaMod([NotNull] OGParser.WorkAreaModContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.workAreaModPrpts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWorkAreaModPrpts([NotNull] OGParser.WorkAreaModPrptsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.sizePrpt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSizePrpt([NotNull] OGParser.SizePrptContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.workAreaVars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWorkAreaVars([NotNull] OGParser.WorkAreaVarsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.shapeDcls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShapeDcls([NotNull] OGParser.ShapeDclsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.functionDcls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDcls([NotNull] OGParser.FunctionDclsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.draw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDraw([NotNull] OGParser.DrawContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.drawCommands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrawCommands([NotNull] OGParser.DrawCommandsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>drawCmd</c>
	/// labeled alternative in <see cref="OGParser.drawCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrawCmd([NotNull] OGParser.DrawCmdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>drawFromCmd</c>
	/// labeled alternative in <see cref="OGParser.drawCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrawFromCmd([NotNull] OGParser.DrawFromCmdContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.shapeDcl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShapeDcl([NotNull] OGParser.ShapeDclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBody([NotNull] OGParser.BodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmts([NotNull] OGParser.StmtsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmt([NotNull] OGParser.StmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>assgnments</c>
	/// labeled alternative in <see cref="OGParser.assignments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssgnments([NotNull] OGParser.AssgnmentsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noAssignmentsDefined</c>
	/// labeled alternative in <see cref="OGParser.assignments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoAssignmentsDefined([NotNull] OGParser.NoAssignmentsDefinedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>dcls</c>
	/// labeled alternative in <see cref="OGParser.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDcls([NotNull] OGParser.DclsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noDeclarationsDefined</c>
	/// labeled alternative in <see cref="OGParser.declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoDeclarationsDefined([NotNull] OGParser.NoDeclarationsDefinedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmds</c>
	/// labeled alternative in <see cref="OGParser.commands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmds([NotNull] OGParser.CmdsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noCmdsDeclared</c>
	/// labeled alternative in <see cref="OGParser.commands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoCmdsDeclared([NotNull] OGParser.NoCmdsDeclaredContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>numberDcl</c>
	/// labeled alternative in <see cref="OGParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberDcl([NotNull] OGParser.NumberDclContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pointDcl</c>
	/// labeled alternative in <see cref="OGParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointDcl([NotNull] OGParser.PointDclContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolDcl</c>
	/// labeled alternative in <see cref="OGParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolDcl([NotNull] OGParser.BoolDclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.booleanDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanDeclaration([NotNull] OGParser.BooleanDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.numberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberDeclaration([NotNull] OGParser.NumberDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pointDclPointRefAssign</c>
	/// labeled alternative in <see cref="OGParser.pointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointDclPointRefAssign([NotNull] OGParser.PointDclPointRefAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pointDclIdAssign</c>
	/// labeled alternative in <see cref="OGParser.pointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointDclIdAssign([NotNull] OGParser.PointDclIdAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.pointReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointReference([NotNull] OGParser.PointReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.numberTuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberTuple([NotNull] OGParser.NumberTupleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] OGParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropertyAssignment([NotNull] OGParser.PropertyAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>idAssign</c>
	/// labeled alternative in <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdAssign([NotNull] OGParser.IdAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>functionCallAssign</c>
	/// labeled alternative in <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallAssign([NotNull] OGParser.FunctionCallAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolAssign</c>
	/// labeled alternative in <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAssign([NotNull] OGParser.BoolAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>numberAssign</c>
	/// labeled alternative in <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberAssign([NotNull] OGParser.NumberAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pointAssign</c>
	/// labeled alternative in <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointAssign([NotNull] OGParser.PointAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.pointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointAssignment([NotNull] OGParser.PointAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.startPointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStartPointAssignment([NotNull] OGParser.StartPointAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.endPointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndPointAssignment([NotNull] OGParser.EndPointAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] OGParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>infixAdditionExpr</c>
	/// labeled alternative in <see cref="OGParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInfixAdditionExpr([NotNull] OGParser.InfixAdditionExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>singleTermExpr</c>
	/// labeled alternative in <see cref="OGParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleTermExpr([NotNull] OGParser.SingleTermExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>infixMultExpr</c>
	/// labeled alternative in <see cref="OGParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInfixMultExpr([NotNull] OGParser.InfixMultExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>singleTermChild</c>
	/// labeled alternative in <see cref="OGParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleTermChild([NotNull] OGParser.SingleTermChildContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>powerExpr</c>
	/// labeled alternative in <see cref="OGParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPowerExpr([NotNull] OGParser.PowerExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>singleAtom</c>
	/// labeled alternative in <see cref="OGParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleAtom([NotNull] OGParser.SingleAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesisMathExpr</c>
	/// labeled alternative in <see cref="OGParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesisMathExpr([NotNull] OGParser.ParenthesisMathExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atomfuncCall</c>
	/// labeled alternative in <see cref="OGParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomfuncCall([NotNull] OGParser.AtomfuncCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="OGParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] OGParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atomXYValue</c>
	/// labeled alternative in <see cref="OGParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomXYValue([NotNull] OGParser.AtomXYValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atomId</c>
	/// labeled alternative in <see cref="OGParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomId([NotNull] OGParser.AtomIdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolExprID</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExprID([NotNull] OGParser.BoolExprIDContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolExprBoolComp</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExprBoolComp([NotNull] OGParser.BoolExprBoolCompContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesisBoolExpr</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesisBoolExpr([NotNull] OGParser.ParenthesisBoolExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolExprMathComp</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExprMathComp([NotNull] OGParser.BoolExprMathCompContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolExprNotPrefix</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExprNotPrefix([NotNull] OGParser.BoolExprNotPrefixContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolExprTrueFalse</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExprTrueFalse([NotNull] OGParser.BoolExprTrueFalseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolExprFuncCall</c>
	/// labeled alternative in <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExprFuncCall([NotNull] OGParser.BoolExprFuncCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] OGParser.CommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.movementCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMovementCommand([NotNull] OGParser.MovementCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.lineCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineCommand([NotNull] OGParser.LineCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.toCommands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToCommands([NotNull] OGParser.ToCommandsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.curveCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCurveCommand([NotNull] OGParser.CurveCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>toWithId</c>
	/// labeled alternative in <see cref="OGParser.toCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToWithId([NotNull] OGParser.ToWithIdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>toWithNumberTuple</c>
	/// labeled alternative in <see cref="OGParser.toCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToWithNumberTuple([NotNull] OGParser.ToWithNumberTupleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>toWithStartPointRef</c>
	/// labeled alternative in <see cref="OGParser.toCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToWithStartPointRef([NotNull] OGParser.ToWithStartPointRefContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>toWithEndPointRef</c>
	/// labeled alternative in <see cref="OGParser.toCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToWithEndPointRef([NotNull] OGParser.ToWithEndPointRefContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fromWithId</c>
	/// labeled alternative in <see cref="OGParser.fromCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFromWithId([NotNull] OGParser.FromWithIdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fromWithNumberTuple</c>
	/// labeled alternative in <see cref="OGParser.fromCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFromWithNumberTuple([NotNull] OGParser.FromWithNumberTupleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fromWithStartPointRef</c>
	/// labeled alternative in <see cref="OGParser.fromCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFromWithStartPointRef([NotNull] OGParser.FromWithStartPointRefContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fromWithEndPointRef</c>
	/// labeled alternative in <see cref="OGParser.fromCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFromWithEndPointRef([NotNull] OGParser.FromWithEndPointRefContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.iterationCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIterationCommand([NotNull] OGParser.IterationCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.numberIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberIteration([NotNull] OGParser.NumberIterationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>untilFuncCall</c>
	/// labeled alternative in <see cref="OGParser.untilIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUntilFuncCall([NotNull] OGParser.UntilFuncCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>untilCondition</c>
	/// labeled alternative in <see cref="OGParser.untilIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUntilCondition([NotNull] OGParser.UntilConditionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.functionDcl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDcl([NotNull] OGParser.FunctionDclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.returnFunctionDCL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnFunctionDCL([NotNull] OGParser.ReturnFunctionDCLContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.typeWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeWord([NotNull] OGParser.TypeWordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.voidFunctionDCL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVoidFunctionDCL([NotNull] OGParser.VoidFunctionDCLContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiParamDcl</c>
	/// labeled alternative in <see cref="OGParser.parameterDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiParamDcl([NotNull] OGParser.MultiParamDclContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>singleParamDcl</c>
	/// labeled alternative in <see cref="OGParser.parameterDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleParamDcl([NotNull] OGParser.SingleParamDclContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noParamsDcl</c>
	/// labeled alternative in <see cref="OGParser.parameterDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoParamsDcl([NotNull] OGParser.NoParamsDclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.parameterDcl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterDcl([NotNull] OGParser.ParameterDclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] OGParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiParameters</c>
	/// labeled alternative in <see cref="OGParser.passedParams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiParameters([NotNull] OGParser.MultiParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>singleParameter</c>
	/// labeled alternative in <see cref="OGParser.passedParams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleParameter([NotNull] OGParser.SingleParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>noParameter</c>
	/// labeled alternative in <see cref="OGParser.passedParams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoParameter([NotNull] OGParser.NoParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>passedID</c>
	/// labeled alternative in <see cref="OGParser.passedParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassedID([NotNull] OGParser.PassedIDContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>passedFunctionCall</c>
	/// labeled alternative in <see cref="OGParser.passedParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassedFunctionCall([NotNull] OGParser.PassedFunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>passedDirectValue</c>
	/// labeled alternative in <see cref="OGParser.passedParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassedDirectValue([NotNull] OGParser.PassedDirectValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>passedEndPointReference</c>
	/// labeled alternative in <see cref="OGParser.passedParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassedEndPointReference([NotNull] OGParser.PassedEndPointReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>passedStartPointReference</c>
	/// labeled alternative in <see cref="OGParser.passedParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPassedStartPointReference([NotNull] OGParser.PassedStartPointReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] OGParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.startPointReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStartPointReference([NotNull] OGParser.StartPointReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.endPointReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndPointReference([NotNull] OGParser.EndPointReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="OGParser.coordinateXYValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCoordinateXYValue([NotNull] OGParser.CoordinateXYValueContext context);
}
