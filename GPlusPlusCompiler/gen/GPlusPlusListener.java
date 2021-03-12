// Generated from C:/Users/Rasmus/RiderProjects/GPlusPlusCompiler/GPlusPlusCompiler\GPlusPlus.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link GPlusPlusParser}.
 */
public interface GPlusPlusListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link GPlusPlusParser#r}.
	 * @param ctx the parse tree
	 */
	void enterR(GPlusPlusParser.RContext ctx);
	/**
	 * Exit a parse tree produced by {@link GPlusPlusParser#r}.
	 * @param ctx the parse tree
	 */
	void exitR(GPlusPlusParser.RContext ctx);
	/**
	 * Enter a parse tree produced by {@link GPlusPlusParser#p}.
	 * @param ctx the parse tree
	 */
	void enterP(GPlusPlusParser.PContext ctx);
	/**
	 * Exit a parse tree produced by {@link GPlusPlusParser#p}.
	 * @param ctx the parse tree
	 */
	void exitP(GPlusPlusParser.PContext ctx);
}