// Generated from C:/Users/Rasmus/IntelliJProjects/P4/Parser_Generator/src\mainGrammar.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link mainGrammarParser}.
 */
public interface mainGrammarListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(mainGrammarParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(mainGrammarParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#shapes}.
	 * @param ctx the parse tree
	 */
	void enterShapes(mainGrammarParser.ShapesContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#shapes}.
	 * @param ctx the parse tree
	 */
	void exitShapes(mainGrammarParser.ShapesContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#shape}.
	 * @param ctx the parse tree
	 */
	void enterShape(mainGrammarParser.ShapeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#shape}.
	 * @param ctx the parse tree
	 */
	void exitShape(mainGrammarParser.ShapeContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#shapeBody}.
	 * @param ctx the parse tree
	 */
	void enterShapeBody(mainGrammarParser.ShapeBodyContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#shapeBody}.
	 * @param ctx the parse tree
	 */
	void exitShapeBody(mainGrammarParser.ShapeBodyContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#motions}.
	 * @param ctx the parse tree
	 */
	void enterMotions(mainGrammarParser.MotionsContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#motions}.
	 * @param ctx the parse tree
	 */
	void exitMotions(mainGrammarParser.MotionsContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#motion}.
	 * @param ctx the parse tree
	 */
	void enterMotion(mainGrammarParser.MotionContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#motion}.
	 * @param ctx the parse tree
	 */
	void exitMotion(mainGrammarParser.MotionContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#curve}.
	 * @param ctx the parse tree
	 */
	void enterCurve(mainGrammarParser.CurveContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#curve}.
	 * @param ctx the parse tree
	 */
	void exitCurve(mainGrammarParser.CurveContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#clockwiseOrNot}.
	 * @param ctx the parse tree
	 */
	void enterClockwiseOrNot(mainGrammarParser.ClockwiseOrNotContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#clockwiseOrNot}.
	 * @param ctx the parse tree
	 */
	void exitClockwiseOrNot(mainGrammarParser.ClockwiseOrNotContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#line}.
	 * @param ctx the parse tree
	 */
	void enterLine(mainGrammarParser.LineContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#line}.
	 * @param ctx the parse tree
	 */
	void exitLine(mainGrammarParser.LineContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#initiateMotions}.
	 * @param ctx the parse tree
	 */
	void enterInitiateMotions(mainGrammarParser.InitiateMotionsContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#initiateMotions}.
	 * @param ctx the parse tree
	 */
	void exitInitiateMotions(mainGrammarParser.InitiateMotionsContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void enterFromCommand(mainGrammarParser.FromCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#fromCommand}.
	 * @param ctx the parse tree
	 */
	void exitFromCommand(mainGrammarParser.FromCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#pointReference}.
	 * @param ctx the parse tree
	 */
	void enterPointReference(mainGrammarParser.PointReferenceContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#pointReference}.
	 * @param ctx the parse tree
	 */
	void exitPointReference(mainGrammarParser.PointReferenceContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#declarations}.
	 * @param ctx the parse tree
	 */
	void enterDeclarations(mainGrammarParser.DeclarationsContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#declarations}.
	 * @param ctx the parse tree
	 */
	void exitDeclarations(mainGrammarParser.DeclarationsContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#pointDeclarations}.
	 * @param ctx the parse tree
	 */
	void enterPointDeclarations(mainGrammarParser.PointDeclarationsContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#pointDeclarations}.
	 * @param ctx the parse tree
	 */
	void exitPointDeclarations(mainGrammarParser.PointDeclarationsContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#numberDeclaration}.
	 * @param ctx the parse tree
	 */
	void enterNumberDeclaration(mainGrammarParser.NumberDeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#numberDeclaration}.
	 * @param ctx the parse tree
	 */
	void exitNumberDeclaration(mainGrammarParser.NumberDeclarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#toCommands}.
	 * @param ctx the parse tree
	 */
	void enterToCommands(mainGrammarParser.ToCommandsContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#toCommands}.
	 * @param ctx the parse tree
	 */
	void exitToCommands(mainGrammarParser.ToCommandsContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToCommand(mainGrammarParser.ToCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToCommand(mainGrammarParser.ToCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#draw}.
	 * @param ctx the parse tree
	 */
	void enterDraw(mainGrammarParser.DrawContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#draw}.
	 * @param ctx the parse tree
	 */
	void exitDraw(mainGrammarParser.DrawContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#drawShapes}.
	 * @param ctx the parse tree
	 */
	void enterDrawShapes(mainGrammarParser.DrawShapesContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#drawShapes}.
	 * @param ctx the parse tree
	 */
	void exitDrawShapes(mainGrammarParser.DrawShapesContext ctx);
	/**
	 * Enter a parse tree produced by {@link mainGrammarParser#drawShape}.
	 * @param ctx the parse tree
	 */
	void enterDrawShape(mainGrammarParser.DrawShapeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mainGrammarParser#drawShape}.
	 * @param ctx the parse tree
	 */
	void exitDrawShape(mainGrammarParser.DrawShapeContext ctx);
}