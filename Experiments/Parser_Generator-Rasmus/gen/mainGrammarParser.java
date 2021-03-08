// Generated from C:/Users/Rasmus/IntelliJProjects/P4/Parser_Generator/src\mainGrammar.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class mainGrammarParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		ID=18, Number=19, CHAR=20, StatementTerminator=21;
	public static final int
		RULE_program = 0, RULE_shapes = 1, RULE_shape = 2, RULE_shapeBody = 3, 
		RULE_motions = 4, RULE_motion = 5, RULE_curve = 6, RULE_clockwiseOrNot = 7, 
		RULE_line = 8, RULE_initiateMotions = 9, RULE_fromCommand = 10, RULE_pointReference = 11, 
		RULE_declarations = 12, RULE_pointDeclarations = 13, RULE_numberDeclaration = 14, 
		RULE_toCommands = 15, RULE_toCommand = 16, RULE_draw = 17, RULE_drawShapes = 18, 
		RULE_drawShape = 19;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "shapes", "shape", "shapeBody", "motions", "motion", "curve", 
			"clockwiseOrNot", "line", "initiateMotions", "fromCommand", "pointReference", 
			"declarations", "pointDeclarations", "numberDeclaration", "toCommands", 
			"toCommand", "draw", "drawShapes", "drawShape"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'shape'", "'{'", "'}'", "'curve'", "'with radius'", "'counterclockwise'", 
			"'line'", "'.from'", "'('", "','", "')'", "'point'", "'='", "'number'", 
			"'.'", "'to'", "'draw'", null, null, null, "';'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, "ID", "Number", "CHAR", "StatementTerminator"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "mainGrammar.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public mainGrammarParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ProgramContext extends ParserRuleContext {
		public ShapesContext shapes() {
			return getRuleContext(ShapesContext.class,0);
		}
		public DrawContext draw() {
			return getRuleContext(DrawContext.class,0);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterProgram(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitProgram(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitProgram(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(40);
			shapes();
			setState(41);
			draw();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ShapesContext extends ParserRuleContext {
		public ShapeContext shape() {
			return getRuleContext(ShapeContext.class,0);
		}
		public ShapesContext shapes() {
			return getRuleContext(ShapesContext.class,0);
		}
		public ShapesContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapes; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterShapes(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitShapes(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitShapes(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ShapesContext shapes() throws RecognitionException {
		ShapesContext _localctx = new ShapesContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_shapes);
		try {
			setState(47);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__0:
				enterOuterAlt(_localctx, 1);
				{
				setState(43);
				shape();
				setState(44);
				shapes();
				}
				break;
			case T__16:
				enterOuterAlt(_localctx, 2);
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ShapeContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(mainGrammarParser.ID, 0); }
		public ShapeBodyContext shapeBody() {
			return getRuleContext(ShapeBodyContext.class,0);
		}
		public ShapeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shape; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterShape(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitShape(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitShape(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ShapeContext shape() throws RecognitionException {
		ShapeContext _localctx = new ShapeContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_shape);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(49);
			match(T__0);
			setState(50);
			match(ID);
			setState(51);
			match(T__1);
			setState(52);
			shapeBody();
			setState(53);
			match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ShapeBodyContext extends ParserRuleContext {
		public DeclarationsContext declarations() {
			return getRuleContext(DeclarationsContext.class,0);
		}
		public MotionsContext motions() {
			return getRuleContext(MotionsContext.class,0);
		}
		public ShapeBodyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapeBody; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterShapeBody(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitShapeBody(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitShapeBody(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ShapeBodyContext shapeBody() throws RecognitionException {
		ShapeBodyContext _localctx = new ShapeBodyContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_shapeBody);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(55);
			declarations();
			setState(56);
			motions();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MotionsContext extends ParserRuleContext {
		public MotionContext motion() {
			return getRuleContext(MotionContext.class,0);
		}
		public MotionsContext motions() {
			return getRuleContext(MotionsContext.class,0);
		}
		public MotionsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_motions; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterMotions(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitMotions(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitMotions(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MotionsContext motions() throws RecognitionException {
		MotionsContext _localctx = new MotionsContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_motions);
		try {
			setState(62);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__3:
			case T__6:
				enterOuterAlt(_localctx, 1);
				{
				setState(58);
				motion();
				setState(59);
				motions();
				}
				break;
			case T__2:
				enterOuterAlt(_localctx, 2);
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MotionContext extends ParserRuleContext {
		public LineContext line() {
			return getRuleContext(LineContext.class,0);
		}
		public TerminalNode StatementTerminator() { return getToken(mainGrammarParser.StatementTerminator, 0); }
		public CurveContext curve() {
			return getRuleContext(CurveContext.class,0);
		}
		public MotionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_motion; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterMotion(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitMotion(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitMotion(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MotionContext motion() throws RecognitionException {
		MotionContext _localctx = new MotionContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_motion);
		try {
			setState(68);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__6:
				enterOuterAlt(_localctx, 1);
				{
				setState(64);
				line();
				setState(65);
				match(StatementTerminator);
				}
				break;
			case T__3:
				enterOuterAlt(_localctx, 2);
				{
				setState(67);
				curve();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class CurveContext extends ParserRuleContext {
		public FromCommandContext fromCommand() {
			return getRuleContext(FromCommandContext.class,0);
		}
		public ToCommandContext toCommand() {
			return getRuleContext(ToCommandContext.class,0);
		}
		public TerminalNode Number() { return getToken(mainGrammarParser.Number, 0); }
		public ClockwiseOrNotContext clockwiseOrNot() {
			return getRuleContext(ClockwiseOrNotContext.class,0);
		}
		public CurveContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_curve; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterCurve(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitCurve(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitCurve(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CurveContext curve() throws RecognitionException {
		CurveContext _localctx = new CurveContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_curve);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(70);
			match(T__3);
			setState(71);
			fromCommand();
			setState(72);
			toCommand();
			setState(73);
			match(T__4);
			setState(74);
			match(Number);
			setState(75);
			clockwiseOrNot();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClockwiseOrNotContext extends ParserRuleContext {
		public ClockwiseOrNotContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_clockwiseOrNot; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterClockwiseOrNot(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitClockwiseOrNot(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitClockwiseOrNot(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClockwiseOrNotContext clockwiseOrNot() throws RecognitionException {
		ClockwiseOrNotContext _localctx = new ClockwiseOrNotContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_clockwiseOrNot);
		try {
			setState(79);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__5:
				enterOuterAlt(_localctx, 1);
				{
				setState(77);
				match(T__5);
				}
				break;
			case T__2:
			case T__3:
			case T__6:
				enterOuterAlt(_localctx, 2);
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LineContext extends ParserRuleContext {
		public InitiateMotionsContext initiateMotions() {
			return getRuleContext(InitiateMotionsContext.class,0);
		}
		public LineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_line; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterLine(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitLine(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitLine(this);
			else return visitor.visitChildren(this);
		}
	}

	public final LineContext line() throws RecognitionException {
		LineContext _localctx = new LineContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_line);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(81);
			match(T__6);
			setState(82);
			initiateMotions();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class InitiateMotionsContext extends ParserRuleContext {
		public FromCommandContext fromCommand() {
			return getRuleContext(FromCommandContext.class,0);
		}
		public ToCommandContext toCommand() {
			return getRuleContext(ToCommandContext.class,0);
		}
		public ToCommandsContext toCommands() {
			return getRuleContext(ToCommandsContext.class,0);
		}
		public InitiateMotionsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_initiateMotions; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterInitiateMotions(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitInitiateMotions(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitInitiateMotions(this);
			else return visitor.visitChildren(this);
		}
	}

	public final InitiateMotionsContext initiateMotions() throws RecognitionException {
		InitiateMotionsContext _localctx = new InitiateMotionsContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_initiateMotions);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(84);
			fromCommand();
			setState(85);
			toCommand();
			setState(86);
			toCommands();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FromCommandContext extends ParserRuleContext {
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public FromCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_fromCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterFromCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitFromCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitFromCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FromCommandContext fromCommand() throws RecognitionException {
		FromCommandContext _localctx = new FromCommandContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_fromCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(88);
			match(T__7);
			setState(89);
			pointReference();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PointReferenceContext extends ParserRuleContext {
		public List<TerminalNode> Number() { return getTokens(mainGrammarParser.Number); }
		public TerminalNode Number(int i) {
			return getToken(mainGrammarParser.Number, i);
		}
		public TerminalNode ID() { return getToken(mainGrammarParser.ID, 0); }
		public PointReferenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pointReference; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterPointReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitPointReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitPointReference(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PointReferenceContext pointReference() throws RecognitionException {
		PointReferenceContext _localctx = new PointReferenceContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_pointReference);
		try {
			setState(99);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(91);
				match(T__8);
				setState(92);
				match(Number);
				setState(93);
				match(T__9);
				setState(94);
				match(Number);
				setState(95);
				match(T__10);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(96);
				match(T__8);
				setState(97);
				match(ID);
				setState(98);
				match(T__10);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DeclarationsContext extends ParserRuleContext {
		public PointDeclarationsContext pointDeclarations() {
			return getRuleContext(PointDeclarationsContext.class,0);
		}
		public DeclarationsContext declarations() {
			return getRuleContext(DeclarationsContext.class,0);
		}
		public NumberDeclarationContext numberDeclaration() {
			return getRuleContext(NumberDeclarationContext.class,0);
		}
		public DeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declarations; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterDeclarations(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitDeclarations(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitDeclarations(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DeclarationsContext declarations() throws RecognitionException {
		DeclarationsContext _localctx = new DeclarationsContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_declarations);
		try {
			setState(107);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__11:
				enterOuterAlt(_localctx, 1);
				{
				setState(101);
				pointDeclarations();
				setState(102);
				declarations();
				}
				break;
			case T__13:
				enterOuterAlt(_localctx, 2);
				{
				setState(104);
				numberDeclaration();
				setState(105);
				declarations();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PointDeclarationsContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(mainGrammarParser.ID, 0); }
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public TerminalNode StatementTerminator() { return getToken(mainGrammarParser.StatementTerminator, 0); }
		public PointDeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pointDeclarations; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterPointDeclarations(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitPointDeclarations(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitPointDeclarations(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PointDeclarationsContext pointDeclarations() throws RecognitionException {
		PointDeclarationsContext _localctx = new PointDeclarationsContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_pointDeclarations);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(109);
			match(T__11);
			setState(110);
			match(ID);
			setState(111);
			match(T__12);
			setState(112);
			pointReference();
			setState(113);
			match(StatementTerminator);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class NumberDeclarationContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(mainGrammarParser.ID, 0); }
		public TerminalNode Number() { return getToken(mainGrammarParser.Number, 0); }
		public TerminalNode StatementTerminator() { return getToken(mainGrammarParser.StatementTerminator, 0); }
		public NumberDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberDeclaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterNumberDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitNumberDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitNumberDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NumberDeclarationContext numberDeclaration() throws RecognitionException {
		NumberDeclarationContext _localctx = new NumberDeclarationContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_numberDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(115);
			match(T__13);
			setState(116);
			match(ID);
			setState(117);
			match(T__12);
			setState(118);
			match(Number);
			setState(119);
			match(StatementTerminator);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ToCommandsContext extends ParserRuleContext {
		public ToCommandContext toCommand() {
			return getRuleContext(ToCommandContext.class,0);
		}
		public ToCommandsContext toCommands() {
			return getRuleContext(ToCommandsContext.class,0);
		}
		public ToCommandsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_toCommands; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterToCommands(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitToCommands(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitToCommands(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ToCommandsContext toCommands() throws RecognitionException {
		ToCommandsContext _localctx = new ToCommandsContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_toCommands);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(121);
			toCommand();
			setState(122);
			toCommands();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ToCommandContext extends ParserRuleContext {
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public ToCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_toCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterToCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitToCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitToCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ToCommandContext toCommand() throws RecognitionException {
		ToCommandContext _localctx = new ToCommandContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_toCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(124);
			match(T__14);
			setState(125);
			match(T__15);
			setState(126);
			pointReference();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DrawContext extends ParserRuleContext {
		public DrawShapesContext drawShapes() {
			return getRuleContext(DrawShapesContext.class,0);
		}
		public DrawContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_draw; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterDraw(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitDraw(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitDraw(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawContext draw() throws RecognitionException {
		DrawContext _localctx = new DrawContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_draw);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(128);
			match(T__16);
			setState(129);
			match(T__1);
			setState(130);
			drawShapes();
			setState(131);
			match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DrawShapesContext extends ParserRuleContext {
		public DrawShapeContext drawShape() {
			return getRuleContext(DrawShapeContext.class,0);
		}
		public DrawShapesContext drawShapes() {
			return getRuleContext(DrawShapesContext.class,0);
		}
		public DrawShapesContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_drawShapes; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterDrawShapes(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitDrawShapes(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitDrawShapes(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawShapesContext drawShapes() throws RecognitionException {
		DrawShapesContext _localctx = new DrawShapesContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_drawShapes);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(133);
			drawShape();
			setState(134);
			drawShapes();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DrawShapeContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(mainGrammarParser.ID, 0); }
		public TerminalNode StatementTerminator() { return getToken(mainGrammarParser.StatementTerminator, 0); }
		public DrawShapeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_drawShape; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).enterDrawShape(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mainGrammarListener ) ((mainGrammarListener)listener).exitDrawShape(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof mainGrammarVisitor ) return ((mainGrammarVisitor<? extends T>)visitor).visitDrawShape(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawShapeContext drawShape() throws RecognitionException {
		DrawShapeContext _localctx = new DrawShapeContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_drawShape);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(136);
			match(ID);
			setState(137);
			match(StatementTerminator);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\27\u008e\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\3\2\3\2\3\2\3\3\3\3\3\3\3\3\5\3\62\n\3"+
		"\3\4\3\4\3\4\3\4\3\4\3\4\3\5\3\5\3\5\3\6\3\6\3\6\3\6\5\6A\n\6\3\7\3\7"+
		"\3\7\3\7\5\7G\n\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\t\3\t\5\tR\n\t\3\n\3\n"+
		"\3\n\3\13\3\13\3\13\3\13\3\f\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\5"+
		"\rf\n\r\3\16\3\16\3\16\3\16\3\16\3\16\5\16n\n\16\3\17\3\17\3\17\3\17\3"+
		"\17\3\17\3\20\3\20\3\20\3\20\3\20\3\20\3\21\3\21\3\21\3\22\3\22\3\22\3"+
		"\22\3\23\3\23\3\23\3\23\3\23\3\24\3\24\3\24\3\25\3\25\3\25\3\25\2\2\26"+
		"\2\4\6\b\n\f\16\20\22\24\26\30\32\34\36 \"$&(\2\2\2\177\2*\3\2\2\2\4\61"+
		"\3\2\2\2\6\63\3\2\2\2\b9\3\2\2\2\n@\3\2\2\2\fF\3\2\2\2\16H\3\2\2\2\20"+
		"Q\3\2\2\2\22S\3\2\2\2\24V\3\2\2\2\26Z\3\2\2\2\30e\3\2\2\2\32m\3\2\2\2"+
		"\34o\3\2\2\2\36u\3\2\2\2 {\3\2\2\2\"~\3\2\2\2$\u0082\3\2\2\2&\u0087\3"+
		"\2\2\2(\u008a\3\2\2\2*+\5\4\3\2+,\5$\23\2,\3\3\2\2\2-.\5\6\4\2./\5\4\3"+
		"\2/\62\3\2\2\2\60\62\3\2\2\2\61-\3\2\2\2\61\60\3\2\2\2\62\5\3\2\2\2\63"+
		"\64\7\3\2\2\64\65\7\24\2\2\65\66\7\4\2\2\66\67\5\b\5\2\678\7\5\2\28\7"+
		"\3\2\2\29:\5\32\16\2:;\5\n\6\2;\t\3\2\2\2<=\5\f\7\2=>\5\n\6\2>A\3\2\2"+
		"\2?A\3\2\2\2@<\3\2\2\2@?\3\2\2\2A\13\3\2\2\2BC\5\22\n\2CD\7\27\2\2DG\3"+
		"\2\2\2EG\5\16\b\2FB\3\2\2\2FE\3\2\2\2G\r\3\2\2\2HI\7\6\2\2IJ\5\26\f\2"+
		"JK\5\"\22\2KL\7\7\2\2LM\7\25\2\2MN\5\20\t\2N\17\3\2\2\2OR\7\b\2\2PR\3"+
		"\2\2\2QO\3\2\2\2QP\3\2\2\2R\21\3\2\2\2ST\7\t\2\2TU\5\24\13\2U\23\3\2\2"+
		"\2VW\5\26\f\2WX\5\"\22\2XY\5 \21\2Y\25\3\2\2\2Z[\7\n\2\2[\\\5\30\r\2\\"+
		"\27\3\2\2\2]^\7\13\2\2^_\7\25\2\2_`\7\f\2\2`a\7\25\2\2af\7\r\2\2bc\7\13"+
		"\2\2cd\7\24\2\2df\7\r\2\2e]\3\2\2\2eb\3\2\2\2f\31\3\2\2\2gh\5\34\17\2"+
		"hi\5\32\16\2in\3\2\2\2jk\5\36\20\2kl\5\32\16\2ln\3\2\2\2mg\3\2\2\2mj\3"+
		"\2\2\2n\33\3\2\2\2op\7\16\2\2pq\7\24\2\2qr\7\17\2\2rs\5\30\r\2st\7\27"+
		"\2\2t\35\3\2\2\2uv\7\20\2\2vw\7\24\2\2wx\7\17\2\2xy\7\25\2\2yz\7\27\2"+
		"\2z\37\3\2\2\2{|\5\"\22\2|}\5 \21\2}!\3\2\2\2~\177\7\21\2\2\177\u0080"+
		"\7\22\2\2\u0080\u0081\5\30\r\2\u0081#\3\2\2\2\u0082\u0083\7\23\2\2\u0083"+
		"\u0084\7\4\2\2\u0084\u0085\5&\24\2\u0085\u0086\7\5\2\2\u0086%\3\2\2\2"+
		"\u0087\u0088\5(\25\2\u0088\u0089\5&\24\2\u0089\'\3\2\2\2\u008a\u008b\7"+
		"\24\2\2\u008b\u008c\7\27\2\2\u008c)\3\2\2\2\b\61@FQem";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}