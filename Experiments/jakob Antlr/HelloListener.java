// Generated from Hello.g4 by ANTLR 4.9.1

testGrammar dk.saxjax

import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link HelloParser}.
 */
public interface HelloListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link HelloParser#shapeDeclSymbol}.
	 * @param ctx the parse tree
	 */
	void enterShapeDeclSymbol(HelloParser.ShapeDeclSymbolContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#shapeDeclSymbol}.
	 * @param ctx the parse tree
	 */
	void exitShapeDeclSymbol(HelloParser.ShapeDeclSymbolContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#start}.
	 * @param ctx the parse tree
	 */
	void enterStart(HelloParser.StartContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#start}.
	 * @param ctx the parse tree
	 */
	void exitStart(HelloParser.StartContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#shapes}.
	 * @param ctx the parse tree
	 */
	void enterShapes(HelloParser.ShapesContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#shapes}.
	 * @param ctx the parse tree
	 */
	void exitShapes(HelloParser.ShapesContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#shape}.
	 * @param ctx the parse tree
	 */
	void enterShape(HelloParser.ShapeContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#shape}.
	 * @param ctx the parse tree
	 */
	void exitShape(HelloParser.ShapeContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#drawType}.
	 * @param ctx the parse tree
	 */
	void enterDrawType(HelloParser.DrawTypeContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#drawType}.
	 * @param ctx the parse tree
	 */
	void exitDrawType(HelloParser.DrawTypeContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#commands}.
	 * @param ctx the parse tree
	 */
	void enterCommands(HelloParser.CommandsContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#commands}.
	 * @param ctx the parse tree
	 */
	void exitCommands(HelloParser.CommandsContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#lineCommand}.
	 * @param ctx the parse tree
	 */
	void enterLineCommand(HelloParser.LineCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#lineCommand}.
	 * @param ctx the parse tree
	 */
	void exitLineCommand(HelloParser.LineCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#curveCommand}.
	 * @param ctx the parse tree
	 */
	void enterCurveCommand(HelloParser.CurveCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#curveCommand}.
	 * @param ctx the parse tree
	 */
	void exitCurveCommand(HelloParser.CurveCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#startCommand}.
	 * @param ctx the parse tree
	 */
	void enterStartCommand(HelloParser.StartCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#startCommand}.
	 * @param ctx the parse tree
	 */
	void exitStartCommand(HelloParser.StartCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#followCommand}.
	 * @param ctx the parse tree
	 */
	void enterFollowCommand(HelloParser.FollowCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#followCommand}.
	 * @param ctx the parse tree
	 */
	void exitFollowCommand(HelloParser.FollowCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void enterToCommand(HelloParser.ToCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#toCommand}.
	 * @param ctx the parse tree
	 */
	void exitToCommand(HelloParser.ToCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#radiusCommand}.
	 * @param ctx the parse tree
	 */
	void enterRadiusCommand(HelloParser.RadiusCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#radiusCommand}.
	 * @param ctx the parse tree
	 */
	void exitRadiusCommand(HelloParser.RadiusCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#manipulateCommand}.
	 * @param ctx the parse tree
	 */
	void enterManipulateCommand(HelloParser.ManipulateCommandContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#manipulateCommand}.
	 * @param ctx the parse tree
	 */
	void exitManipulateCommand(HelloParser.ManipulateCommandContext ctx);
	/**
	 * Enter a parse tree produced by {@link HelloParser#point}.
	 * @param ctx the parse tree
	 */
	void enterPoint(HelloParser.PointContext ctx);
	/**
	 * Exit a parse tree produced by {@link HelloParser#point}.
	 * @param ctx the parse tree
	 */
	void exitPoint(HelloParser.PointContext ctx);
}