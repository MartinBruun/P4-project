// Generated from /Users/saxjax/developer/P4-project/OG/OG/OG.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link OGParser}.
 */
public interface OGListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by the {@code prog}
	 * labeled alternative in {@link OGParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProg(OGParser.ProgContext ctx);
	/**
	 * Exit a parse tree produced by the {@code prog}
	 * labeled alternative in {@link OGParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProg(OGParser.ProgContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#machineSettings}.
	 * @param ctx the parse tree
	 */
	void enterMachineSettings(OGParser.MachineSettingsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#machineSettings}.
	 * @param ctx the parse tree
	 */
	void exitMachineSettings(OGParser.MachineSettingsContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#machineMods}.
	 * @param ctx the parse tree
	 */
	void enterMachineMods(OGParser.MachineModsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#machineMods}.
	 * @param ctx the parse tree
	 */
	void exitMachineMods(OGParser.MachineModsContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#workAreaMod}.
	 * @param ctx the parse tree
	 */
	void enterWorkAreaMod(OGParser.WorkAreaModContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#workAreaMod}.
	 * @param ctx the parse tree
	 */
	void exitWorkAreaMod(OGParser.WorkAreaModContext ctx);
	/**
	 * Enter a parse tree produced by the {@code workAreaModifierProperties}
	 * labeled alternative in {@link OGParser#workAreaModPrpts}.
	 * @param ctx the parse tree
	 */
	void enterWorkAreaModifierProperties(OGParser.WorkAreaModifierPropertiesContext ctx);
	/**
	 * Exit a parse tree produced by the {@code workAreaModifierProperties}
	 * labeled alternative in {@link OGParser#workAreaModPrpts}.
	 * @param ctx the parse tree
	 */
	void exitWorkAreaModifierProperties(OGParser.WorkAreaModifierPropertiesContext ctx);
	/**
	 * Enter a parse tree produced by the {@code endOfWorkAreaModifierProperties}
	 * labeled alternative in {@link OGParser#workAreaModPrpts}.
	 * @param ctx the parse tree
	 */
	void enterEndOfWorkAreaModifierProperties(OGParser.EndOfWorkAreaModifierPropertiesContext ctx);
	/**
	 * Exit a parse tree produced by the {@code endOfWorkAreaModifierProperties}
	 * labeled alternative in {@link OGParser#workAreaModPrpts}.
	 * @param ctx the parse tree
	 */
	void exitEndOfWorkAreaModifierProperties(OGParser.EndOfWorkAreaModifierPropertiesContext ctx);
	/**
	 * Enter a parse tree produced by the {@code sizeProperty}
	 * labeled alternative in {@link OGParser#sizePrpt}.
	 * @param ctx the parse tree
	 */
	void enterSizeProperty(OGParser.SizePropertyContext ctx);
	/**
	 * Exit a parse tree produced by the {@code sizeProperty}
	 * labeled alternative in {@link OGParser#sizePrpt}.
	 * @param ctx the parse tree
	 */
	void exitSizeProperty(OGParser.SizePropertyContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#workAreaVars}.
	 * @param ctx the parse tree
	 */
	void enterWorkAreaVars(OGParser.WorkAreaVarsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#workAreaVars}.
	 * @param ctx the parse tree
	 */
	void exitWorkAreaVars(OGParser.WorkAreaVarsContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#shapeDcls}.
	 * @param ctx the parse tree
	 */
	void enterShapeDcls(OGParser.ShapeDclsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#shapeDcls}.
	 * @param ctx the parse tree
	 */
	void exitShapeDcls(OGParser.ShapeDclsContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#functionDcls}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDcls(OGParser.FunctionDclsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#functionDcls}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDcls(OGParser.FunctionDclsContext ctx);
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
	 * Enter a parse tree produced by {@link OGParser#drawCommands}.
	 * @param ctx the parse tree
	 */
	void enterDrawCommands(OGParser.DrawCommandsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#drawCommands}.
	 * @param ctx the parse tree
	 */
	void exitDrawCommands(OGParser.DrawCommandsContext ctx);
	/**
	 * Enter a parse tree produced by the {@code drawCmd}
	 * labeled alternative in {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 */
	void enterDrawCmd(OGParser.DrawCmdContext ctx);
	/**
	 * Exit a parse tree produced by the {@code drawCmd}
	 * labeled alternative in {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 */
	void exitDrawCmd(OGParser.DrawCmdContext ctx);
	/**
	 * Enter a parse tree produced by the {@code drawFromCmd}
	 * labeled alternative in {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 */
	void enterDrawFromCmd(OGParser.DrawFromCmdContext ctx);
	/**
	 * Exit a parse tree produced by the {@code drawFromCmd}
	 * labeled alternative in {@link OGParser#drawCommand}.
	 * @param ctx the parse tree
	 */
	void exitDrawFromCmd(OGParser.DrawFromCmdContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#shapeDcl}.
	 * @param ctx the parse tree
	 */
	void enterShapeDcl(OGParser.ShapeDclContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#shapeDcl}.
	 * @param ctx the parse tree
	 */
	void exitShapeDcl(OGParser.ShapeDclContext ctx);
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
	 * Enter a parse tree produced by {@link OGParser#stmts}.
	 * @param ctx the parse tree
	 */
	void enterStmts(OGParser.StmtsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#stmts}.
	 * @param ctx the parse tree
	 */
	void exitStmts(OGParser.StmtsContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#stmt}.
	 * @param ctx the parse tree
	 */
	void enterStmt(OGParser.StmtContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#stmt}.
	 * @param ctx the parse tree
	 */
	void exitStmt(OGParser.StmtContext ctx);
	/**
	 * Enter a parse tree produced by the {@code assgnments}
	 * labeled alternative in {@link OGParser#assignments}.
	 * @param ctx the parse tree
	 */
	void enterAssgnments(OGParser.AssgnmentsContext ctx);
	/**
	 * Exit a parse tree produced by the {@code assgnments}
	 * labeled alternative in {@link OGParser#assignments}.
	 * @param ctx the parse tree
	 */
	void exitAssgnments(OGParser.AssgnmentsContext ctx);
	/**
	 * Enter a parse tree produced by the {@code noAssignmentsDefined}
	 * labeled alternative in {@link OGParser#assignments}.
	 * @param ctx the parse tree
	 */
	void enterNoAssignmentsDefined(OGParser.NoAssignmentsDefinedContext ctx);
	/**
	 * Exit a parse tree produced by the {@code noAssignmentsDefined}
	 * labeled alternative in {@link OGParser#assignments}.
	 * @param ctx the parse tree
	 */
	void exitNoAssignmentsDefined(OGParser.NoAssignmentsDefinedContext ctx);
	/**
	 * Enter a parse tree produced by the {@code dcls}
	 * labeled alternative in {@link OGParser#declarations}.
	 * @param ctx the parse tree
	 */
	void enterDcls(OGParser.DclsContext ctx);
	/**
	 * Exit a parse tree produced by the {@code dcls}
	 * labeled alternative in {@link OGParser#declarations}.
	 * @param ctx the parse tree
	 */
	void exitDcls(OGParser.DclsContext ctx);
	/**
	 * Enter a parse tree produced by the {@code noDeclarationsDefined}
	 * labeled alternative in {@link OGParser#declarations}.
	 * @param ctx the parse tree
	 */
	void enterNoDeclarationsDefined(OGParser.NoDeclarationsDefinedContext ctx);
	/**
	 * Exit a parse tree produced by the {@code noDeclarationsDefined}
	 * labeled alternative in {@link OGParser#declarations}.
	 * @param ctx the parse tree
	 */
	void exitNoDeclarationsDefined(OGParser.NoDeclarationsDefinedContext ctx);
	/**
	 * Enter a parse tree produced by the {@code cmds}
	 * labeled alternative in {@link OGParser#commands}.
	 * @param ctx the parse tree
	 */
	void enterCmds(OGParser.CmdsContext ctx);
	/**
	 * Exit a parse tree produced by the {@code cmds}
	 * labeled alternative in {@link OGParser#commands}.
	 * @param ctx the parse tree
	 */
	void exitCmds(OGParser.CmdsContext ctx);
	/**
	 * Enter a parse tree produced by the {@code noCmdsDeclared}
	 * labeled alternative in {@link OGParser#commands}.
	 * @param ctx the parse tree
	 */
	void enterNoCmdsDeclared(OGParser.NoCmdsDeclaredContext ctx);
	/**
	 * Exit a parse tree produced by the {@code noCmdsDeclared}
	 * labeled alternative in {@link OGParser#commands}.
	 * @param ctx the parse tree
	 */
	void exitNoCmdsDeclared(OGParser.NoCmdsDeclaredContext ctx);
	/**
	 * Enter a parse tree produced by the {@code numberDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterNumberDcl(OGParser.NumberDclContext ctx);
	/**
	 * Exit a parse tree produced by the {@code numberDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitNumberDcl(OGParser.NumberDclContext ctx);
	/**
	 * Enter a parse tree produced by the {@code pointDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterPointDcl(OGParser.PointDclContext ctx);
	/**
	 * Exit a parse tree produced by the {@code pointDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitPointDcl(OGParser.PointDclContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterBoolDcl(OGParser.BoolDclContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolDcl}
	 * labeled alternative in {@link OGParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitBoolDcl(OGParser.BoolDclContext ctx);
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
	 * Enter a parse tree produced by the {@code pointDclPointRefAssign}
	 * labeled alternative in {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterPointDclPointRefAssign(OGParser.PointDclPointRefAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code pointDclPointRefAssign}
	 * labeled alternative in {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitPointDclPointRefAssign(OGParser.PointDclPointRefAssignContext ctx);
	/**
	 * Enter a parse tree produced by the {@code pointDclIdAssign}
	 * labeled alternative in {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterPointDclIdAssign(OGParser.PointDclIdAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code pointDclIdAssign}
	 * labeled alternative in {@link OGParser#pointDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitPointDclIdAssign(OGParser.PointDclIdAssignContext ctx);
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
	 * Enter a parse tree produced by the {@code idAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void enterIdAssign(OGParser.IdAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code idAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void exitIdAssign(OGParser.IdAssignContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void enterBoolAssign(OGParser.BoolAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void exitBoolAssign(OGParser.BoolAssignContext ctx);
	/**
	 * Enter a parse tree produced by the {@code numberAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void enterNumberAssign(OGParser.NumberAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code numberAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void exitNumberAssign(OGParser.NumberAssignContext ctx);
	/**
	 * Enter a parse tree produced by the {@code pointAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void enterPointAssign(OGParser.PointAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code pointAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void exitPointAssign(OGParser.PointAssignContext ctx);
	/**
	 * Enter a parse tree produced by the {@code functionCallAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void enterFunctionCallAssign(OGParser.FunctionCallAssignContext ctx);
	/**
	 * Exit a parse tree produced by the {@code functionCallAssign}
	 * labeled alternative in {@link OGParser#variableAssignment}.
	 * @param ctx the parse tree
	 */
	void exitFunctionCallAssign(OGParser.FunctionCallAssignContext ctx);
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
	 * Enter a parse tree produced by the {@code infixAdditionExpr}
	 * labeled alternative in {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 */
	void enterInfixAdditionExpr(OGParser.InfixAdditionExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code infixAdditionExpr}
	 * labeled alternative in {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 */
	void exitInfixAdditionExpr(OGParser.InfixAdditionExprContext ctx);
	/**
	 * Enter a parse tree produced by the {@code singleTermExpr}
	 * labeled alternative in {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 */
	void enterSingleTermExpr(OGParser.SingleTermExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code singleTermExpr}
	 * labeled alternative in {@link OGParser#mathExpression}.
	 * @param ctx the parse tree
	 */
	void exitSingleTermExpr(OGParser.SingleTermExprContext ctx);
	/**
	 * Enter a parse tree produced by the {@code infixMultExpr}
	 * labeled alternative in {@link OGParser#term}.
	 * @param ctx the parse tree
	 */
	void enterInfixMultExpr(OGParser.InfixMultExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code infixMultExpr}
	 * labeled alternative in {@link OGParser#term}.
	 * @param ctx the parse tree
	 */
	void exitInfixMultExpr(OGParser.InfixMultExprContext ctx);
	/**
	 * Enter a parse tree produced by the {@code singleTermChild}
	 * labeled alternative in {@link OGParser#term}.
	 * @param ctx the parse tree
	 */
	void enterSingleTermChild(OGParser.SingleTermChildContext ctx);
	/**
	 * Exit a parse tree produced by the {@code singleTermChild}
	 * labeled alternative in {@link OGParser#term}.
	 * @param ctx the parse tree
	 */
	void exitSingleTermChild(OGParser.SingleTermChildContext ctx);
	/**
	 * Enter a parse tree produced by the {@code powerExpr}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void enterPowerExpr(OGParser.PowerExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code powerExpr}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void exitPowerExpr(OGParser.PowerExprContext ctx);
	/**
	 * Enter a parse tree produced by the {@code singleAtom}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void enterSingleAtom(OGParser.SingleAtomContext ctx);
	/**
	 * Exit a parse tree produced by the {@code singleAtom}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void exitSingleAtom(OGParser.SingleAtomContext ctx);
	/**
	 * Enter a parse tree produced by the {@code parenthesisMathExpr}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void enterParenthesisMathExpr(OGParser.ParenthesisMathExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code parenthesisMathExpr}
	 * labeled alternative in {@link OGParser#factor}.
	 * @param ctx the parse tree
	 */
	void exitParenthesisMathExpr(OGParser.ParenthesisMathExprContext ctx);
	/**
	 * Enter a parse tree produced by the {@code atomfuncCall}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void enterAtomfuncCall(OGParser.AtomfuncCallContext ctx);
	/**
	 * Exit a parse tree produced by the {@code atomfuncCall}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void exitAtomfuncCall(OGParser.AtomfuncCallContext ctx);
	/**
	 * Enter a parse tree produced by the {@code number}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void enterNumber(OGParser.NumberContext ctx);
	/**
	 * Exit a parse tree produced by the {@code number}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void exitNumber(OGParser.NumberContext ctx);
	/**
	 * Enter a parse tree produced by the {@code atomXYValue}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void enterAtomXYValue(OGParser.AtomXYValueContext ctx);
	/**
	 * Exit a parse tree produced by the {@code atomXYValue}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void exitAtomXYValue(OGParser.AtomXYValueContext ctx);
	/**
	 * Enter a parse tree produced by the {@code atomId}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void enterAtomId(OGParser.AtomIdContext ctx);
	/**
	 * Exit a parse tree produced by the {@code atomId}
	 * labeled alternative in {@link OGParser#atom}.
	 * @param ctx the parse tree
	 */
	void exitAtomId(OGParser.AtomIdContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolExprID}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExprID(OGParser.BoolExprIDContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolExprID}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExprID(OGParser.BoolExprIDContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolExprBoolComp}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExprBoolComp(OGParser.BoolExprBoolCompContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolExprBoolComp}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExprBoolComp(OGParser.BoolExprBoolCompContext ctx);
	/**
	 * Enter a parse tree produced by the {@code parenthesisBoolExpr}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterParenthesisBoolExpr(OGParser.ParenthesisBoolExprContext ctx);
	/**
	 * Exit a parse tree produced by the {@code parenthesisBoolExpr}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitParenthesisBoolExpr(OGParser.ParenthesisBoolExprContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolExprMathComp}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExprMathComp(OGParser.BoolExprMathCompContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolExprMathComp}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExprMathComp(OGParser.BoolExprMathCompContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolExprNotPrefix}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExprNotPrefix(OGParser.BoolExprNotPrefixContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolExprNotPrefix}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExprNotPrefix(OGParser.BoolExprNotPrefixContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolExprTrueFalse}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExprTrueFalse(OGParser.BoolExprTrueFalseContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolExprTrueFalse}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExprTrueFalse(OGParser.BoolExprTrueFalseContext ctx);
	/**
	 * Enter a parse tree produced by the {@code boolExprFuncCall}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void enterBoolExprFuncCall(OGParser.BoolExprFuncCallContext ctx);
	/**
	 * Exit a parse tree produced by the {@code boolExprFuncCall}
	 * labeled alternative in {@link OGParser#boolExpression}.
	 * @param ctx the parse tree
	 */
	void exitBoolExprFuncCall(OGParser.BoolExprFuncCallContext ctx);
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
	 * Enter a parse tree produced by {@link OGParser#toCommands}.
	 * @param ctx the parse tree
	 */
	void enterToCommands(OGParser.ToCommandsContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#toCommands}.
	 * @param ctx the parse tree
	 */
	void exitToCommands(OGParser.ToCommandsContext ctx);
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
	 * Enter a parse tree produced by the {@code toWithId}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToWithId(OGParser.ToWithIdContext ctx);
	/**
	 * Exit a parse tree produced by the {@code toWithId}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToWithId(OGParser.ToWithIdContext ctx);
	/**
	 * Enter a parse tree produced by the {@code toWithNumberTuple}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToWithNumberTuple(OGParser.ToWithNumberTupleContext ctx);
	/**
	 * Exit a parse tree produced by the {@code toWithNumberTuple}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToWithNumberTuple(OGParser.ToWithNumberTupleContext ctx);
	/**
	 * Enter a parse tree produced by the {@code toWithStartPointRef}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToWithStartPointRef(OGParser.ToWithStartPointRefContext ctx);
	/**
	 * Exit a parse tree produced by the {@code toWithStartPointRef}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToWithStartPointRef(OGParser.ToWithStartPointRefContext ctx);
	/**
	 * Enter a parse tree produced by the {@code toWithEndPointRef}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToWithEndPointRef(OGParser.ToWithEndPointRefContext ctx);
	/**
	 * Exit a parse tree produced by the {@code toWithEndPointRef}
	 * labeled alternative in {@link OGParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToWithEndPointRef(OGParser.ToWithEndPointRefContext ctx);
	/**
	 * Enter a parse tree produced by the {@code fromWithId}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void enterFromWithId(OGParser.FromWithIdContext ctx);
	/**
	 * Exit a parse tree produced by the {@code fromWithId}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void exitFromWithId(OGParser.FromWithIdContext ctx);
	/**
	 * Enter a parse tree produced by the {@code fromWithNumberTuple}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void enterFromWithNumberTuple(OGParser.FromWithNumberTupleContext ctx);
	/**
	 * Exit a parse tree produced by the {@code fromWithNumberTuple}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void exitFromWithNumberTuple(OGParser.FromWithNumberTupleContext ctx);
	/**
	 * Enter a parse tree produced by the {@code fromWithStartPointRef}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void enterFromWithStartPointRef(OGParser.FromWithStartPointRefContext ctx);
	/**
	 * Exit a parse tree produced by the {@code fromWithStartPointRef}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void exitFromWithStartPointRef(OGParser.FromWithStartPointRefContext ctx);
	/**
	 * Enter a parse tree produced by the {@code fromWithEndPointRef}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void enterFromWithEndPointRef(OGParser.FromWithEndPointRefContext ctx);
	/**
	 * Exit a parse tree produced by the {@code fromWithEndPointRef}
	 * labeled alternative in {@link OGParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void exitFromWithEndPointRef(OGParser.FromWithEndPointRefContext ctx);
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
	 * Enter a parse tree produced by the {@code untilFuncCall}
	 * labeled alternative in {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 */
	void enterUntilFuncCall(OGParser.UntilFuncCallContext ctx);
	/**
	 * Exit a parse tree produced by the {@code untilFuncCall}
	 * labeled alternative in {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 */
	void exitUntilFuncCall(OGParser.UntilFuncCallContext ctx);
	/**
	 * Enter a parse tree produced by the {@code untilCondition}
	 * labeled alternative in {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 */
	void enterUntilCondition(OGParser.UntilConditionContext ctx);
	/**
	 * Exit a parse tree produced by the {@code untilCondition}
	 * labeled alternative in {@link OGParser#untilIteration}.
	 * @param ctx the parse tree
	 */
	void exitUntilCondition(OGParser.UntilConditionContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#functionDcl}.
	 * @param ctx the parse tree
	 */
	void enterFunctionDcl(OGParser.FunctionDclContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#functionDcl}.
	 * @param ctx the parse tree
	 */
	void exitFunctionDcl(OGParser.FunctionDclContext ctx);
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
	 * Enter a parse tree produced by the {@code multiParamDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void enterMultiParamDcl(OGParser.MultiParamDclContext ctx);
	/**
	 * Exit a parse tree produced by the {@code multiParamDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void exitMultiParamDcl(OGParser.MultiParamDclContext ctx);
	/**
	 * Enter a parse tree produced by the {@code singleParamDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void enterSingleParamDcl(OGParser.SingleParamDclContext ctx);
	/**
	 * Exit a parse tree produced by the {@code singleParamDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void exitSingleParamDcl(OGParser.SingleParamDclContext ctx);
	/**
	 * Enter a parse tree produced by the {@code noParamsDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void enterNoParamsDcl(OGParser.NoParamsDclContext ctx);
	/**
	 * Exit a parse tree produced by the {@code noParamsDcl}
	 * labeled alternative in {@link OGParser#parameterDeclarations}.
	 * @param ctx the parse tree
	 */
	void exitNoParamsDcl(OGParser.NoParamsDclContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#parameterDcl}.
	 * @param ctx the parse tree
	 */
	void enterParameterDcl(OGParser.ParameterDclContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#parameterDcl}.
	 * @param ctx the parse tree
	 */
	void exitParameterDcl(OGParser.ParameterDclContext ctx);
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
	 * Enter a parse tree produced by the {@code multiParameters}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 */
	void enterMultiParameters(OGParser.MultiParametersContext ctx);
	/**
	 * Exit a parse tree produced by the {@code multiParameters}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 */
	void exitMultiParameters(OGParser.MultiParametersContext ctx);
	/**
	 * Enter a parse tree produced by the {@code singleParameter}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 */
	void enterSingleParameter(OGParser.SingleParameterContext ctx);
	/**
	 * Exit a parse tree produced by the {@code singleParameter}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 */
	void exitSingleParameter(OGParser.SingleParameterContext ctx);
	/**
	 * Enter a parse tree produced by the {@code noParameter}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 */
	void enterNoParameter(OGParser.NoParameterContext ctx);
	/**
	 * Exit a parse tree produced by the {@code noParameter}
	 * labeled alternative in {@link OGParser#passedParams}.
	 * @param ctx the parse tree
	 */
	void exitNoParameter(OGParser.NoParameterContext ctx);
	/**
	 * Enter a parse tree produced by the {@code passedID}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void enterPassedID(OGParser.PassedIDContext ctx);
	/**
	 * Exit a parse tree produced by the {@code passedID}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void exitPassedID(OGParser.PassedIDContext ctx);
	/**
	 * Enter a parse tree produced by the {@code passedFunctionCall}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void enterPassedFunctionCall(OGParser.PassedFunctionCallContext ctx);
	/**
	 * Exit a parse tree produced by the {@code passedFunctionCall}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void exitPassedFunctionCall(OGParser.PassedFunctionCallContext ctx);
	/**
	 * Enter a parse tree produced by the {@code passedDirectValue}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void enterPassedDirectValue(OGParser.PassedDirectValueContext ctx);
	/**
	 * Exit a parse tree produced by the {@code passedDirectValue}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void exitPassedDirectValue(OGParser.PassedDirectValueContext ctx);
	/**
	 * Enter a parse tree produced by the {@code passedEndPointReference}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void enterPassedEndPointReference(OGParser.PassedEndPointReferenceContext ctx);
	/**
	 * Exit a parse tree produced by the {@code passedEndPointReference}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void exitPassedEndPointReference(OGParser.PassedEndPointReferenceContext ctx);
	/**
	 * Enter a parse tree produced by the {@code passedStartPointReference}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void enterPassedStartPointReference(OGParser.PassedStartPointReferenceContext ctx);
	/**
	 * Exit a parse tree produced by the {@code passedStartPointReference}
	 * labeled alternative in {@link OGParser#passedParam}.
	 * @param ctx the parse tree
	 */
	void exitPassedStartPointReference(OGParser.PassedStartPointReferenceContext ctx);
	/**
	 * Enter a parse tree produced by the {@code returnValueReference}
	 * labeled alternative in {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 */
	void enterReturnValueReference(OGParser.ReturnValueReferenceContext ctx);
	/**
	 * Exit a parse tree produced by the {@code returnValueReference}
	 * labeled alternative in {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 */
	void exitReturnValueReference(OGParser.ReturnValueReferenceContext ctx);
	/**
	 * Enter a parse tree produced by the {@code returnDirectValue}
	 * labeled alternative in {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 */
	void enterReturnDirectValue(OGParser.ReturnDirectValueContext ctx);
	/**
	 * Exit a parse tree produced by the {@code returnDirectValue}
	 * labeled alternative in {@link OGParser#returnStatement}.
	 * @param ctx the parse tree
	 */
	void exitReturnDirectValue(OGParser.ReturnDirectValueContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#startPointReference}.
	 * @param ctx the parse tree
	 */
	void enterStartPointReference(OGParser.StartPointReferenceContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#startPointReference}.
	 * @param ctx the parse tree
	 */
	void exitStartPointReference(OGParser.StartPointReferenceContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#endPointReference}.
	 * @param ctx the parse tree
	 */
	void enterEndPointReference(OGParser.EndPointReferenceContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#endPointReference}.
	 * @param ctx the parse tree
	 */
	void exitEndPointReference(OGParser.EndPointReferenceContext ctx);
	/**
	 * Enter a parse tree produced by {@link OGParser#coordinateXYValue}.
	 * @param ctx the parse tree
	 */
	void enterCoordinateXYValue(OGParser.CoordinateXYValueContext ctx);
	/**
	 * Exit a parse tree produced by {@link OGParser#coordinateXYValue}.
	 * @param ctx the parse tree
	 */
	void exitCoordinateXYValue(OGParser.CoordinateXYValueContext ctx);
}