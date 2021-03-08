// Generated from C:/Users/Rasmus/IntelliJProjects/P4/Parser_Generator/src\mainGrammar.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link mainGrammarParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface mainGrammarVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#program}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProgram(mainGrammarParser.ProgramContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#shapes}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShapes(mainGrammarParser.ShapesContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#shape}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShape(mainGrammarParser.ShapeContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#shapeBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitShapeBody(mainGrammarParser.ShapeBodyContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#motions}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMotions(mainGrammarParser.MotionsContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#motion}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMotion(mainGrammarParser.MotionContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#curve}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitCurve(mainGrammarParser.CurveContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#clockwiseOrNot}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClockwiseOrNot(mainGrammarParser.ClockwiseOrNotContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#line}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitLine(mainGrammarParser.LineContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#initiateMotions}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitInitiateMotions(mainGrammarParser.InitiateMotionsContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#fromCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFromCommand(mainGrammarParser.FromCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#pointReference}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointReference(mainGrammarParser.PointReferenceContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#declarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeclarations(mainGrammarParser.DeclarationsContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#pointDeclarations}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPointDeclarations(mainGrammarParser.PointDeclarationsContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#numberDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNumberDeclaration(mainGrammarParser.NumberDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#toCommands}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToCommands(mainGrammarParser.ToCommandsContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#toCommand}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitToCommand(mainGrammarParser.ToCommandContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#draw}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDraw(mainGrammarParser.DrawContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#drawShapes}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDrawShapes(mainGrammarParser.DrawShapesContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#drawShape}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDrawShape(mainGrammarParser.DrawShapeContext ctx);
	/**
	 * Visit a parse tree produced by {@link mainGrammarParser#prule}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPrule(mainGrammarParser.PruleContext ctx);
}