// Generated from /Users/saxjax/developer/P4/OUR_ANTLR/Hello.g4 by ANTLR 4.8

testGrammar dk.saxjax

import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class HelloParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, WS=16, IDENTIFIER=17, 
		NUMBER=18;
	public static final int
		RULE_shapeDeclSymbol = 0, RULE_start = 1, RULE_shapes = 2, RULE_shape = 3, 
		RULE_drawType = 4, RULE_commands = 5, RULE_lineCommand = 6, RULE_curveCommand = 7, 
		RULE_startCommand = 8, RULE_followCommand = 9, RULE_toCommand = 10, RULE_radiusCommand = 11, 
		RULE_manipulateCommand = 12, RULE_point = 13;
	private static String[] makeRuleNames() {
		return new String[] {
			"shapeDeclSymbol", "start", "shapes", "shape", "drawType", "commands", 
			"lineCommand", "curveCommand", "startCommand", "followCommand", "toCommand", 
			"radiusCommand", "manipulateCommand", "point"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'shape'", "'draw'", "'{'", "'}'", "'line'", "'curve'", "'.'", 
			"';'", "'from'", "'('", "')'", "'to'", "'radius'", "'rotate'", "','"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, "WS", "IDENTIFIER", "NUMBER"
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
	public String getGrammarFileName() { return "Hello.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public HelloParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ShapeDeclSymbolContext extends ParserRuleContext {
		public ShapeDeclSymbolContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapeDeclSymbol; }
	}

	public final ShapeDeclSymbolContext shapeDeclSymbol() throws RecognitionException {
		ShapeDeclSymbolContext _localctx = new ShapeDeclSymbolContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_shapeDeclSymbol);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(28);
			match(T__0);
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

	public static class StartContext extends ParserRuleContext {
		public ShapesContext shapes() {
			return getRuleContext(ShapesContext.class,0);
		}
		public StartContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_start; }
	}

	public final StartContext start() throws RecognitionException {
		StartContext _localctx = new StartContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_start);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(30);
			shapes();
			setState(31);
			match(T__1);
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
		public List<ShapeContext> shape() {
			return getRuleContexts(ShapeContext.class);
		}
		public ShapeContext shape(int i) {
			return getRuleContext(ShapeContext.class,i);
		}
		public ShapesContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapes; }
	}

	public final ShapesContext shapes() throws RecognitionException {
		ShapesContext _localctx = new ShapesContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_shapes);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(34); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(33);
				shape();
				}
				}
				setState(36); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==T__0 );
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
		public ShapeDeclSymbolContext shapeDeclSymbol() {
			return getRuleContext(ShapeDeclSymbolContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(HelloParser.IDENTIFIER, 0); }
		public List<ShapesContext> shapes() {
			return getRuleContexts(ShapesContext.class);
		}
		public ShapesContext shapes(int i) {
			return getRuleContext(ShapesContext.class,i);
		}
		public List<DrawTypeContext> drawType() {
			return getRuleContexts(DrawTypeContext.class);
		}
		public DrawTypeContext drawType(int i) {
			return getRuleContext(DrawTypeContext.class,i);
		}
		public ShapeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shape; }
	}

	public final ShapeContext shape() throws RecognitionException {
		ShapeContext _localctx = new ShapeContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_shape);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(38);
			shapeDeclSymbol();
			setState(39);
			match(IDENTIFIER);
			setState(40);
			match(T__2);
			setState(51);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__4) | (1L << T__5) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				{
				setState(42); 
				_errHandler.sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						setState(41);
						drawType();
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					setState(44); 
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,1,_ctx);
				} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
				}
				setState(47);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__0) {
					{
					setState(46);
					shapes();
					}
				}

				}
				}
				setState(53);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(54);
			match(T__3);
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

	public static class DrawTypeContext extends ParserRuleContext {
		public LineCommandContext lineCommand() {
			return getRuleContext(LineCommandContext.class,0);
		}
		public CurveCommandContext curveCommand() {
			return getRuleContext(CurveCommandContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(HelloParser.IDENTIFIER, 0); }
		public DrawTypeContext drawType() {
			return getRuleContext(DrawTypeContext.class,0);
		}
		public List<ManipulateCommandContext> manipulateCommand() {
			return getRuleContexts(ManipulateCommandContext.class);
		}
		public ManipulateCommandContext manipulateCommand(int i) {
			return getRuleContext(ManipulateCommandContext.class,i);
		}
		public DrawTypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_drawType; }
	}

	public final DrawTypeContext drawType() throws RecognitionException {
		DrawTypeContext _localctx = new DrawTypeContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_drawType);
		int _la;
		try {
			setState(71);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,5,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(56);
				match(T__4);
				setState(57);
				lineCommand();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(58);
				match(T__5);
				setState(59);
				curveCommand();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(60);
				match(IDENTIFIER);
				setState(61);
				match(T__6);
				setState(62);
				drawType();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(63);
				match(IDENTIFIER);
				setState(65); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(64);
					manipulateCommand();
					}
					}
					setState(67); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==T__6 );
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(69);
				match(IDENTIFIER);
				setState(70);
				match(T__7);
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

	public static class CommandsContext extends ParserRuleContext {
		public LineCommandContext lineCommand() {
			return getRuleContext(LineCommandContext.class,0);
		}
		public CurveCommandContext curveCommand() {
			return getRuleContext(CurveCommandContext.class,0);
		}
		public CommandsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_commands; }
	}

	public final CommandsContext commands() throws RecognitionException {
		CommandsContext _localctx = new CommandsContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_commands);
		try {
			setState(75);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(73);
				lineCommand();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(74);
				curveCommand();
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

	public static class LineCommandContext extends ParserRuleContext {
		public StartCommandContext startCommand() {
			return getRuleContext(StartCommandContext.class,0);
		}
		public List<FollowCommandContext> followCommand() {
			return getRuleContexts(FollowCommandContext.class);
		}
		public FollowCommandContext followCommand(int i) {
			return getRuleContext(FollowCommandContext.class,i);
		}
		public LineCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_lineCommand; }
	}

	public final LineCommandContext lineCommand() throws RecognitionException {
		LineCommandContext _localctx = new LineCommandContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_lineCommand);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(77);
			startCommand();
			setState(81);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T__6) {
				{
				{
				setState(78);
				followCommand();
				}
				}
				setState(83);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(84);
			match(T__7);
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

	public static class CurveCommandContext extends ParserRuleContext {
		public LineCommandContext lineCommand() {
			return getRuleContext(LineCommandContext.class,0);
		}
		public RadiusCommandContext radiusCommand() {
			return getRuleContext(RadiusCommandContext.class,0);
		}
		public CurveCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_curveCommand; }
	}

	public final CurveCommandContext curveCommand() throws RecognitionException {
		CurveCommandContext _localctx = new CurveCommandContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_curveCommand);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(86);
			lineCommand();
			setState(88);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__6) {
				{
				setState(87);
				radiusCommand();
				}
			}

			setState(90);
			match(T__7);
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

	public static class StartCommandContext extends ParserRuleContext {
		public PointContext point() {
			return getRuleContext(PointContext.class,0);
		}
		public FollowCommandContext followCommand() {
			return getRuleContext(FollowCommandContext.class,0);
		}
		public StartCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_startCommand; }
	}

	public final StartCommandContext startCommand() throws RecognitionException {
		StartCommandContext _localctx = new StartCommandContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_startCommand);
		try {
			setState(99);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(92);
				match(T__6);
				setState(93);
				match(T__8);
				setState(94);
				match(T__9);
				setState(95);
				point();
				setState(96);
				match(T__10);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(98);
				followCommand();
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

	public static class FollowCommandContext extends ParserRuleContext {
		public ToCommandContext toCommand() {
			return getRuleContext(ToCommandContext.class,0);
		}
		public RadiusCommandContext radiusCommand() {
			return getRuleContext(RadiusCommandContext.class,0);
		}
		public FollowCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_followCommand; }
	}

	public final FollowCommandContext followCommand() throws RecognitionException {
		FollowCommandContext _localctx = new FollowCommandContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_followCommand);
		try {
			setState(103);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(101);
				toCommand();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(102);
				radiusCommand();
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

	public static class ToCommandContext extends ParserRuleContext {
		public PointContext point() {
			return getRuleContext(PointContext.class,0);
		}
		public ToCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_toCommand; }
	}

	public final ToCommandContext toCommand() throws RecognitionException {
		ToCommandContext _localctx = new ToCommandContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_toCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(105);
			match(T__6);
			setState(106);
			match(T__11);
			setState(107);
			match(T__9);
			setState(108);
			point();
			setState(109);
			match(T__10);
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

	public static class RadiusCommandContext extends ParserRuleContext {
		public TerminalNode NUMBER() { return getToken(HelloParser.NUMBER, 0); }
		public TerminalNode IDENTIFIER() { return getToken(HelloParser.IDENTIFIER, 0); }
		public RadiusCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_radiusCommand; }
	}

	public final RadiusCommandContext radiusCommand() throws RecognitionException {
		RadiusCommandContext _localctx = new RadiusCommandContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_radiusCommand);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(111);
			match(T__6);
			setState(112);
			match(T__12);
			setState(113);
			match(T__9);
			setState(114);
			_la = _input.LA(1);
			if ( !(_la==IDENTIFIER || _la==NUMBER) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			setState(115);
			match(T__10);
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

	public static class ManipulateCommandContext extends ParserRuleContext {
		public TerminalNode NUMBER() { return getToken(HelloParser.NUMBER, 0); }
		public TerminalNode IDENTIFIER() { return getToken(HelloParser.IDENTIFIER, 0); }
		public ManipulateCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_manipulateCommand; }
	}

	public final ManipulateCommandContext manipulateCommand() throws RecognitionException {
		ManipulateCommandContext _localctx = new ManipulateCommandContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_manipulateCommand);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(117);
			match(T__6);
			setState(118);
			match(T__13);
			setState(119);
			match(T__9);
			setState(120);
			_la = _input.LA(1);
			if ( !(_la==IDENTIFIER || _la==NUMBER) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			setState(121);
			match(T__10);
			setState(122);
			match(T__7);
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

	public static class PointContext extends ParserRuleContext {
		public List<TerminalNode> NUMBER() { return getTokens(HelloParser.NUMBER); }
		public TerminalNode NUMBER(int i) {
			return getToken(HelloParser.NUMBER, i);
		}
		public TerminalNode IDENTIFIER() { return getToken(HelloParser.IDENTIFIER, 0); }
		public PointContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_point; }
	}

	public final PointContext point() throws RecognitionException {
		PointContext _localctx = new PointContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_point);
		try {
			setState(128);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NUMBER:
				enterOuterAlt(_localctx, 1);
				{
				setState(124);
				match(NUMBER);
				setState(125);
				match(T__14);
				setState(126);
				match(NUMBER);
				}
				break;
			case IDENTIFIER:
				enterOuterAlt(_localctx, 2);
				{
				setState(127);
				match(IDENTIFIER);
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

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\24\u0085\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\3\2\3\2\3\3\3\3\3\3\3\4\6\4"+
		"%\n\4\r\4\16\4&\3\5\3\5\3\5\3\5\6\5-\n\5\r\5\16\5.\3\5\5\5\62\n\5\7\5"+
		"\64\n\5\f\5\16\5\67\13\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\6"+
		"\6D\n\6\r\6\16\6E\3\6\3\6\5\6J\n\6\3\7\3\7\5\7N\n\7\3\b\3\b\7\bR\n\b\f"+
		"\b\16\bU\13\b\3\b\3\b\3\t\3\t\5\t[\n\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n"+
		"\3\n\5\nf\n\n\3\13\3\13\5\13j\n\13\3\f\3\f\3\f\3\f\3\f\3\f\3\r\3\r\3\r"+
		"\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\17\3\17\3\17\3\17\5"+
		"\17\u0083\n\17\3\17\2\2\20\2\4\6\b\n\f\16\20\22\24\26\30\32\34\2\3\3\2"+
		"\23\24\2\u0085\2\36\3\2\2\2\4 \3\2\2\2\6$\3\2\2\2\b(\3\2\2\2\nI\3\2\2"+
		"\2\fM\3\2\2\2\16O\3\2\2\2\20X\3\2\2\2\22e\3\2\2\2\24i\3\2\2\2\26k\3\2"+
		"\2\2\30q\3\2\2\2\32w\3\2\2\2\34\u0082\3\2\2\2\36\37\7\3\2\2\37\3\3\2\2"+
		"\2 !\5\6\4\2!\"\7\4\2\2\"\5\3\2\2\2#%\5\b\5\2$#\3\2\2\2%&\3\2\2\2&$\3"+
		"\2\2\2&\'\3\2\2\2\'\7\3\2\2\2()\5\2\2\2)*\7\23\2\2*\65\7\5\2\2+-\5\n\6"+
		"\2,+\3\2\2\2-.\3\2\2\2.,\3\2\2\2./\3\2\2\2/\61\3\2\2\2\60\62\5\6\4\2\61"+
		"\60\3\2\2\2\61\62\3\2\2\2\62\64\3\2\2\2\63,\3\2\2\2\64\67\3\2\2\2\65\63"+
		"\3\2\2\2\65\66\3\2\2\2\668\3\2\2\2\67\65\3\2\2\289\7\6\2\29\t\3\2\2\2"+
		":;\7\7\2\2;J\5\16\b\2<=\7\b\2\2=J\5\20\t\2>?\7\23\2\2?@\7\t\2\2@J\5\n"+
		"\6\2AC\7\23\2\2BD\5\32\16\2CB\3\2\2\2DE\3\2\2\2EC\3\2\2\2EF\3\2\2\2FJ"+
		"\3\2\2\2GH\7\23\2\2HJ\7\n\2\2I:\3\2\2\2I<\3\2\2\2I>\3\2\2\2IA\3\2\2\2"+
		"IG\3\2\2\2J\13\3\2\2\2KN\5\16\b\2LN\5\20\t\2MK\3\2\2\2ML\3\2\2\2N\r\3"+
		"\2\2\2OS\5\22\n\2PR\5\24\13\2QP\3\2\2\2RU\3\2\2\2SQ\3\2\2\2ST\3\2\2\2"+
		"TV\3\2\2\2US\3\2\2\2VW\7\n\2\2W\17\3\2\2\2XZ\5\16\b\2Y[\5\30\r\2ZY\3\2"+
		"\2\2Z[\3\2\2\2[\\\3\2\2\2\\]\7\n\2\2]\21\3\2\2\2^_\7\t\2\2_`\7\13\2\2"+
		"`a\7\f\2\2ab\5\34\17\2bc\7\r\2\2cf\3\2\2\2df\5\24\13\2e^\3\2\2\2ed\3\2"+
		"\2\2f\23\3\2\2\2gj\5\26\f\2hj\5\30\r\2ig\3\2\2\2ih\3\2\2\2j\25\3\2\2\2"+
		"kl\7\t\2\2lm\7\16\2\2mn\7\f\2\2no\5\34\17\2op\7\r\2\2p\27\3\2\2\2qr\7"+
		"\t\2\2rs\7\17\2\2st\7\f\2\2tu\t\2\2\2uv\7\r\2\2v\31\3\2\2\2wx\7\t\2\2"+
		"xy\7\20\2\2yz\7\f\2\2z{\t\2\2\2{|\7\r\2\2|}\7\n\2\2}\33\3\2\2\2~\177\7"+
		"\24\2\2\177\u0080\7\21\2\2\u0080\u0083\7\24\2\2\u0081\u0083\7\23\2\2\u0082"+
		"~\3\2\2\2\u0082\u0081\3\2\2\2\u0083\35\3\2\2\2\16&.\61\65EIMSZei\u0082";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}