// Generated from /Users/saxjax/developer/P4-project/GPlusPlusCompiler/GPlusPlusCompiler/OG.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class OGParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, BooleanValue=6, Number=7, WS=8, 
		COMMENT=9, ShapeDCLWord=10, PointDCLWord=11, BoolDCLWord=12, NumberDCLWord=13, 
		DrawDCLWord=14, WithAngle=15, Curve=16, Line=17, To=18, From=19, RepeatStart=20, 
		RepeatEnd=21, Until=22, DOT=23, FunctionStartWord=24, FunctionReturnWord=25, 
		Void=26, LPAREN=27, RPAREN=28, PLUS=29, MINUS=30, TIMES=31, DIV=32, POW=33, 
		LogicOperator=34, BoolOperator=35, GT=36, LT=37, EQ=38, AND=39, OR=40, 
		Assign=41, OpenScope=42, CloseScope=43, Terminator=44, Seperator=45, CoordinatePropRef=46, 
		ID=47;
	public static final int
		RULE_program = 0, RULE_machineVariables = 1, RULE_machine = 2, RULE_draw = 3, 
		RULE_shapeDefinition = 4, RULE_body = 5, RULE_assignment = 6, RULE_declaration = 7, 
		RULE_booleanDeclaration = 8, RULE_numberDeclaration = 9, RULE_pointDeclaration = 10, 
		RULE_coordinateReference = 11, RULE_numberTuple = 12, RULE_expression = 13, 
		RULE_boolExpression = 14, RULE_mathExpression = 15, RULE_term = 16, RULE_factor = 17, 
		RULE_signedAtom = 18, RULE_atom = 19, RULE_command = 20, RULE_movementCommand = 21, 
		RULE_lineCommand = 22, RULE_curveCommand = 23, RULE_toCommand = 24, RULE_iterationCommand = 25, 
		RULE_numberIteration = 26, RULE_untilIteration = 27, RULE_functionDeclaration = 28, 
		RULE_returnFunctionDCL = 29, RULE_typeWord = 30, RULE_voidFunctionDCL = 31, 
		RULE_parameterDeclarations = 32, RULE_parameters = 33, RULE_functionCall = 34, 
		RULE_parameterList = 35, RULE_returnStatement = 36, RULE_numberRefence = 37, 
		RULE_valueReference = 38;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "machineVariables", "machine", "draw", "shapeDefinition", 
			"body", "assignment", "declaration", "booleanDeclaration", "numberDeclaration", 
			"pointDeclaration", "coordinateReference", "numberTuple", "expression", 
			"boolExpression", "mathExpression", "term", "factor", "signedAtom", "atom", 
			"command", "movementCommand", "lineCommand", "curveCommand", "toCommand", 
			"iterationCommand", "numberIteration", "untilIteration", "functionDeclaration", 
			"returnFunctionDCL", "typeWord", "voidFunctionDCL", "parameterDeclarations", 
			"parameters", "functionCall", "parameterList", "returnStatement", "numberRefence", 
			"valueReference"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'Xmin:'", "'Machine'", "'WorkArea'", "'size'", "'.to'", null, 
			null, null, null, "'shape'", "'point'", "'bool'", "'number'", "'draw'", 
			"'withAngle'", "'curve'", "'line'", "'to'", "'from'", "'repeat'", "'repeat.end'", 
			"'until'", "'.'", "'function'", "'return'", "'void'", "'('", "')'", "'+'", 
			"'-'", "'*'", "'/'", "'^'", null, null, "'>'", "'<'", "'=='", "'&&'", 
			"'||'", "'='", "'{'", "'}'", "';'", "','"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, "BooleanValue", "Number", "WS", "COMMENT", 
			"ShapeDCLWord", "PointDCLWord", "BoolDCLWord", "NumberDCLWord", "DrawDCLWord", 
			"WithAngle", "Curve", "Line", "To", "From", "RepeatStart", "RepeatEnd", 
			"Until", "DOT", "FunctionStartWord", "FunctionReturnWord", "Void", "LPAREN", 
			"RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "POW", "LogicOperator", "BoolOperator", 
			"GT", "LT", "EQ", "AND", "OR", "Assign", "OpenScope", "CloseScope", "Terminator", 
			"Seperator", "CoordinatePropRef", "ID"
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
	public String getGrammarFileName() { return "OG.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public OGParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ProgramContext extends ParserRuleContext {
		public MachineContext machine() {
			return getRuleContext(MachineContext.class,0);
		}
		public DrawContext draw() {
			return getRuleContext(DrawContext.class,0);
		}
		public List<FunctionDeclarationContext> functionDeclaration() {
			return getRuleContexts(FunctionDeclarationContext.class);
		}
		public FunctionDeclarationContext functionDeclaration(int i) {
			return getRuleContext(FunctionDeclarationContext.class,i);
		}
		public List<ShapeDefinitionContext> shapeDefinition() {
			return getRuleContexts(ShapeDefinitionContext.class);
		}
		public ShapeDefinitionContext shapeDefinition(int i) {
			return getRuleContext(ShapeDefinitionContext.class,i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterProgram(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitProgram(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitProgram(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(78);
			machine();
			setState(79);
			draw();
			setState(83);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==FunctionStartWord) {
				{
				{
				setState(80);
				functionDeclaration();
				}
				}
				setState(85);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(89);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ShapeDCLWord) {
				{
				{
				setState(86);
				shapeDefinition();
				}
				}
				setState(91);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
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

	public static class MachineVariablesContext extends ParserRuleContext {
		public List<TerminalNode> Number() { return getTokens(OGParser.Number); }
		public TerminalNode Number(int i) {
			return getToken(OGParser.Number, i);
		}
		public List<TerminalNode> Seperator() { return getTokens(OGParser.Seperator); }
		public TerminalNode Seperator(int i) {
			return getToken(OGParser.Seperator, i);
		}
		public MachineVariablesContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_machineVariables; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMachineVariables(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMachineVariables(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMachineVariables(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MachineVariablesContext machineVariables() throws RecognitionException {
		MachineVariablesContext _localctx = new MachineVariablesContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_machineVariables);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(92);
			match(T__0);
			setState(93);
			match(Number);
			setState(94);
			match(Seperator);
			setState(95);
			match(Number);
			setState(96);
			match(Seperator);
			setState(97);
			match(Number);
			setState(98);
			match(Seperator);
			setState(99);
			match(Number);
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

	public static class MachineContext extends ParserRuleContext {
		public List<TerminalNode> DOT() { return getTokens(OGParser.DOT); }
		public TerminalNode DOT(int i) {
			return getToken(OGParser.DOT, i);
		}
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public MachineVariablesContext machineVariables() {
			return getRuleContext(MachineVariablesContext.class,0);
		}
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public MachineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_machine; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMachine(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMachine(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMachine(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MachineContext machine() throws RecognitionException {
		MachineContext _localctx = new MachineContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_machine);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(101);
			match(T__1);
			setState(102);
			match(DOT);
			setState(103);
			match(T__2);
			setState(104);
			match(DOT);
			setState(105);
			match(T__3);
			setState(106);
			match(LPAREN);
			setState(107);
			machineVariables();
			setState(108);
			match(RPAREN);
			setState(109);
			match(Terminator);
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
		public TerminalNode DrawDCLWord() { return getToken(OGParser.DrawDCLWord, 0); }
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public List<TerminalNode> Terminator() { return getTokens(OGParser.Terminator); }
		public TerminalNode Terminator(int i) {
			return getToken(OGParser.Terminator, i);
		}
		public DrawContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_draw; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDraw(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDraw(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDraw(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawContext draw() throws RecognitionException {
		DrawContext _localctx = new DrawContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_draw);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(111);
			match(DrawDCLWord);
			setState(112);
			match(OpenScope);
			setState(117);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ID) {
				{
				{
				setState(113);
				match(ID);
				setState(114);
				match(Terminator);
				}
				}
				setState(119);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(120);
			match(CloseScope);
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

	public static class ShapeDefinitionContext extends ParserRuleContext {
		public TerminalNode ShapeDCLWord() { return getToken(OGParser.ShapeDCLWord, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public ShapeDefinitionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapeDefinition; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterShapeDefinition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitShapeDefinition(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitShapeDefinition(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ShapeDefinitionContext shapeDefinition() throws RecognitionException {
		ShapeDefinitionContext _localctx = new ShapeDefinitionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_shapeDefinition);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(122);
			match(ShapeDCLWord);
			setState(123);
			match(ID);
			setState(124);
			match(OpenScope);
			setState(125);
			body();
			setState(126);
			match(CloseScope);
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

	public static class BodyContext extends ParserRuleContext {
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public List<DeclarationContext> declaration() {
			return getRuleContexts(DeclarationContext.class);
		}
		public DeclarationContext declaration(int i) {
			return getRuleContext(DeclarationContext.class,i);
		}
		public List<AssignmentContext> assignment() {
			return getRuleContexts(AssignmentContext.class);
		}
		public AssignmentContext assignment(int i) {
			return getRuleContext(AssignmentContext.class,i);
		}
		public List<FunctionCallContext> functionCall() {
			return getRuleContexts(FunctionCallContext.class);
		}
		public FunctionCallContext functionCall(int i) {
			return getRuleContext(FunctionCallContext.class,i);
		}
		public List<CommandContext> command() {
			return getRuleContexts(CommandContext.class);
		}
		public CommandContext command(int i) {
			return getRuleContext(CommandContext.class,i);
		}
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public BodyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_body; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBody(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBody(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBody(this);
			else return visitor.visitChildren(this);
		}
	}

	public final BodyContext body() throws RecognitionException {
		BodyContext _localctx = new BodyContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_body);
		int _la;
		try {
			setState(145);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,5,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(128);
				match(OpenScope);
				setState(136);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BooleanValue) | (1L << Number) | (1L << PointDCLWord) | (1L << BoolDCLWord) | (1L << NumberDCLWord) | (1L << Curve) | (1L << Line) | (1L << RepeatStart) | (1L << LPAREN) | (1L << ID))) != 0)) {
					{
					setState(134);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
					case 1:
						{
						setState(129);
						expression();
						}
						break;
					case 2:
						{
						setState(130);
						declaration();
						}
						break;
					case 3:
						{
						setState(131);
						assignment();
						}
						break;
					case 4:
						{
						setState(132);
						functionCall();
						}
						break;
					case 5:
						{
						setState(133);
						command();
						}
						break;
					}
					}
					setState(138);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(139);
				match(CloseScope);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(140);
				match(OpenScope);
				setState(141);
				body();
				setState(142);
				match(CloseScope);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
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

	public static class AssignmentContext extends ParserRuleContext {
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final AssignmentContext assignment() throws RecognitionException {
		AssignmentContext _localctx = new AssignmentContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_assignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(147);
			match(ID);
			setState(148);
			match(Assign);
			setState(151);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				{
				setState(149);
				match(ID);
				}
				break;
			case 2:
				{
				setState(150);
				expression();
				}
				break;
			}
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

	public static class DeclarationContext extends ParserRuleContext {
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public NumberDeclarationContext numberDeclaration() {
			return getRuleContext(NumberDeclarationContext.class,0);
		}
		public PointDeclarationContext pointDeclaration() {
			return getRuleContext(PointDeclarationContext.class,0);
		}
		public BooleanDeclarationContext booleanDeclaration() {
			return getRuleContext(BooleanDeclarationContext.class,0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(156);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NumberDCLWord:
				{
				setState(153);
				numberDeclaration();
				}
				break;
			case PointDCLWord:
				{
				setState(154);
				pointDeclaration();
				}
				break;
			case BoolDCLWord:
				{
				setState(155);
				booleanDeclaration();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(158);
			match(Terminator);
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

	public static class BooleanDeclarationContext extends ParserRuleContext {
		public TerminalNode BoolDCLWord() { return getToken(OGParser.BoolDCLWord, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public BooleanDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_booleanDeclaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBooleanDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBooleanDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBooleanDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final BooleanDeclarationContext booleanDeclaration() throws RecognitionException {
		BooleanDeclarationContext _localctx = new BooleanDeclarationContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_booleanDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(160);
			match(BoolDCLWord);
			setState(161);
			match(ID);
			setState(162);
			match(Assign);
			setState(163);
			boolExpression(0);
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
		public TerminalNode NumberDCLWord() { return getToken(OGParser.NumberDCLWord, 0); }
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public ValueReferenceContext valueReference() {
			return getRuleContext(ValueReferenceContext.class,0);
		}
		public NumberDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberDeclaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NumberDeclarationContext numberDeclaration() throws RecognitionException {
		NumberDeclarationContext _localctx = new NumberDeclarationContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_numberDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(165);
			match(NumberDCLWord);
			setState(166);
			match(ID);
			setState(167);
			match(Assign);
			setState(171);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				{
				setState(168);
				match(ID);
				}
				break;
			case 2:
				{
				setState(169);
				mathExpression();
				}
				break;
			case 3:
				{
				setState(170);
				valueReference();
				}
				break;
			}
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

	public static class PointDeclarationContext extends ParserRuleContext {
		public TerminalNode PointDCLWord() { return getToken(OGParser.PointDCLWord, 0); }
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public CoordinateReferenceContext coordinateReference() {
			return getRuleContext(CoordinateReferenceContext.class,0);
		}
		public PointDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pointDeclaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PointDeclarationContext pointDeclaration() throws RecognitionException {
		PointDeclarationContext _localctx = new PointDeclarationContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_pointDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(173);
			match(PointDCLWord);
			setState(174);
			match(ID);
			setState(175);
			match(Assign);
			setState(178);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case LPAREN:
				{
				setState(176);
				coordinateReference();
				}
				break;
			case ID:
				{
				setState(177);
				match(ID);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
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

	public static class CoordinateReferenceContext extends ParserRuleContext {
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public CoordinateReferenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_coordinateReference; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterCoordinateReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitCoordinateReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitCoordinateReference(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CoordinateReferenceContext coordinateReference() throws RecognitionException {
		CoordinateReferenceContext _localctx = new CoordinateReferenceContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_coordinateReference);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(180);
			match(LPAREN);
			setState(181);
			numberTuple();
			setState(182);
			match(RPAREN);
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

	public static class NumberTupleContext extends ParserRuleContext {
		public TerminalNode Seperator() { return getToken(OGParser.Seperator, 0); }
		public List<TerminalNode> Number() { return getTokens(OGParser.Number); }
		public TerminalNode Number(int i) {
			return getToken(OGParser.Number, i);
		}
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public List<NumberRefenceContext> numberRefence() {
			return getRuleContexts(NumberRefenceContext.class);
		}
		public NumberRefenceContext numberRefence(int i) {
			return getRuleContext(NumberRefenceContext.class,i);
		}
		public NumberTupleContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberTuple; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberTuple(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberTuple(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberTuple(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NumberTupleContext numberTuple() throws RecognitionException {
		NumberTupleContext _localctx = new NumberTupleContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_numberTuple);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(187);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				{
				setState(184);
				match(Number);
				}
				break;
			case 2:
				{
				setState(185);
				mathExpression();
				}
				break;
			case 3:
				{
				setState(186);
				numberRefence();
				}
				break;
			}
			setState(189);
			match(Seperator);
			setState(193);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				{
				setState(190);
				match(Number);
				}
				break;
			case 2:
				{
				setState(191);
				mathExpression();
				}
				break;
			case 3:
				{
				setState(192);
				numberRefence();
				}
				break;
			}
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

	public static class ExpressionContext extends ParserRuleContext {
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitExpression(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitExpression(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_expression);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(197);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
			case 1:
				{
				setState(195);
				mathExpression();
				}
				break;
			case 2:
				{
				setState(196);
				boolExpression(0);
				}
				break;
			}
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

	public static class BoolExpressionContext extends ParserRuleContext {
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public TerminalNode BoolOperator() { return getToken(OGParser.BoolOperator, 0); }
		public TerminalNode BooleanValue() { return getToken(OGParser.BooleanValue, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public List<BoolExpressionContext> boolExpression() {
			return getRuleContexts(BoolExpressionContext.class);
		}
		public BoolExpressionContext boolExpression(int i) {
			return getRuleContext(BoolExpressionContext.class,i);
		}
		public TerminalNode LogicOperator() { return getToken(OGParser.LogicOperator, 0); }
		public BoolExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_boolExpression; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExpression(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExpression(this);
			else return visitor.visitChildren(this);
		}
	}

	public final BoolExpressionContext boolExpression() throws RecognitionException {
		return boolExpression(0);
	}

	private BoolExpressionContext boolExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		BoolExpressionContext _localctx = new BoolExpressionContext(_ctx, _parentState);
		BoolExpressionContext _prevctx = _localctx;
		int _startState = 28;
		enterRecursionRule(_localctx, 28, RULE_boolExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(206);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				{
				{
				setState(200);
				mathExpression();
				setState(201);
				match(BoolOperator);
				setState(202);
				mathExpression();
				}
				}
				break;
			case 2:
				{
				setState(204);
				match(BooleanValue);
				}
				break;
			case 3:
				{
				setState(205);
				functionCall();
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(213);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,14,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new BoolExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_boolExpression);
					setState(208);
					if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
					setState(209);
					match(LogicOperator);
					setState(210);
					boolExpression(3);
					}
					} 
				}
				setState(215);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,14,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class MathExpressionContext extends ParserRuleContext {
		public List<TermContext> term() {
			return getRuleContexts(TermContext.class);
		}
		public TermContext term(int i) {
			return getRuleContext(TermContext.class,i);
		}
		public List<TerminalNode> PLUS() { return getTokens(OGParser.PLUS); }
		public TerminalNode PLUS(int i) {
			return getToken(OGParser.PLUS, i);
		}
		public List<TerminalNode> MINUS() { return getTokens(OGParser.MINUS); }
		public TerminalNode MINUS(int i) {
			return getToken(OGParser.MINUS, i);
		}
		public MathExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_mathExpression; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMathExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMathExpression(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMathExpression(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MathExpressionContext mathExpression() throws RecognitionException {
		MathExpressionContext _localctx = new MathExpressionContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_mathExpression);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(216);
			term();
			setState(221);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,15,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(217);
					_la = _input.LA(1);
					if ( !(_la==PLUS || _la==MINUS) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					setState(218);
					term();
					}
					} 
				}
				setState(223);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,15,_ctx);
			}
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

	public static class TermContext extends ParserRuleContext {
		public List<FactorContext> factor() {
			return getRuleContexts(FactorContext.class);
		}
		public FactorContext factor(int i) {
			return getRuleContext(FactorContext.class,i);
		}
		public List<TerminalNode> TIMES() { return getTokens(OGParser.TIMES); }
		public TerminalNode TIMES(int i) {
			return getToken(OGParser.TIMES, i);
		}
		public List<TerminalNode> DIV() { return getTokens(OGParser.DIV); }
		public TerminalNode DIV(int i) {
			return getToken(OGParser.DIV, i);
		}
		public TermContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_term; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterTerm(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitTerm(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitTerm(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TermContext term() throws RecognitionException {
		TermContext _localctx = new TermContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_term);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(224);
			factor();
			setState(229);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,16,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(225);
					_la = _input.LA(1);
					if ( !(_la==TIMES || _la==DIV) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					setState(226);
					factor();
					}
					} 
				}
				setState(231);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,16,_ctx);
			}
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

	public static class FactorContext extends ParserRuleContext {
		public List<SignedAtomContext> signedAtom() {
			return getRuleContexts(SignedAtomContext.class);
		}
		public SignedAtomContext signedAtom(int i) {
			return getRuleContext(SignedAtomContext.class,i);
		}
		public List<TerminalNode> POW() { return getTokens(OGParser.POW); }
		public TerminalNode POW(int i) {
			return getToken(OGParser.POW, i);
		}
		public FactorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_factor; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFactor(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFactor(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFactor(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FactorContext factor() throws RecognitionException {
		FactorContext _localctx = new FactorContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_factor);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(232);
			signedAtom();
			setState(237);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(233);
					match(POW);
					setState(234);
					signedAtom();
					}
					} 
				}
				setState(239);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,17,_ctx);
			}
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

	public static class SignedAtomContext extends ParserRuleContext {
		public AtomContext atom() {
			return getRuleContext(AtomContext.class,0);
		}
		public SignedAtomContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_signedAtom; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSignedAtom(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSignedAtom(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSignedAtom(this);
			else return visitor.visitChildren(this);
		}
	}

	public final SignedAtomContext signedAtom() throws RecognitionException {
		SignedAtomContext _localctx = new SignedAtomContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_signedAtom);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(240);
			atom();
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

	public static class AtomContext extends ParserRuleContext {
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public AtomContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_atom; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterAtom(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitAtom(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitAtom(this);
			else return visitor.visitChildren(this);
		}
	}

	public final AtomContext atom() throws RecognitionException {
		AtomContext _localctx = new AtomContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_atom);
		try {
			setState(249);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,18,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(242);
				match(Number);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(243);
				match(ID);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(244);
				match(LPAREN);
				setState(245);
				mathExpression();
				setState(246);
				match(RPAREN);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(248);
				functionCall();
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

	public static class CommandContext extends ParserRuleContext {
		public IterationCommandContext iterationCommand() {
			return getRuleContext(IterationCommandContext.class,0);
		}
		public MovementCommandContext movementCommand() {
			return getRuleContext(MovementCommandContext.class,0);
		}
		public CommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_command; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CommandContext command() throws RecognitionException {
		CommandContext _localctx = new CommandContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_command);
		try {
			setState(253);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case RepeatStart:
				enterOuterAlt(_localctx, 1);
				{
				setState(251);
				iterationCommand();
				}
				break;
			case Curve:
			case Line:
				enterOuterAlt(_localctx, 2);
				{
				setState(252);
				movementCommand();
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

	public static class MovementCommandContext extends ParserRuleContext {
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public LineCommandContext lineCommand() {
			return getRuleContext(LineCommandContext.class,0);
		}
		public CurveCommandContext curveCommand() {
			return getRuleContext(CurveCommandContext.class,0);
		}
		public MovementCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_movementCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMovementCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMovementCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMovementCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MovementCommandContext movementCommand() throws RecognitionException {
		MovementCommandContext _localctx = new MovementCommandContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_movementCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(257);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Line:
				{
				setState(255);
				lineCommand();
				}
				break;
			case Curve:
				{
				setState(256);
				curveCommand();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(259);
			match(Terminator);
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
		public TerminalNode Line() { return getToken(OGParser.Line, 0); }
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode From() { return getToken(OGParser.From, 0); }
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public List<ToCommandContext> toCommand() {
			return getRuleContexts(ToCommandContext.class);
		}
		public ToCommandContext toCommand(int i) {
			return getRuleContext(ToCommandContext.class,i);
		}
		public LineCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_lineCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterLineCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitLineCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitLineCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final LineCommandContext lineCommand() throws RecognitionException {
		LineCommandContext _localctx = new LineCommandContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_lineCommand);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(261);
			match(Line);
			setState(262);
			match(DOT);
			setState(263);
			match(From);
			setState(264);
			match(LPAREN);
			setState(267);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
			case 1:
				{
				setState(265);
				numberTuple();
				}
				break;
			case 2:
				{
				setState(266);
				match(ID);
				}
				break;
			}
			setState(269);
			match(RPAREN);
			setState(271); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(270);
				toCommand();
				}
				}
				setState(273); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==T__4 );
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
		public TerminalNode Curve() { return getToken(OGParser.Curve, 0); }
		public List<TerminalNode> DOT() { return getTokens(OGParser.DOT); }
		public TerminalNode DOT(int i) {
			return getToken(OGParser.DOT, i);
		}
		public TerminalNode WithAngle() { return getToken(OGParser.WithAngle, 0); }
		public List<TerminalNode> LPAREN() { return getTokens(OGParser.LPAREN); }
		public TerminalNode LPAREN(int i) {
			return getToken(OGParser.LPAREN, i);
		}
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public List<TerminalNode> RPAREN() { return getTokens(OGParser.RPAREN); }
		public TerminalNode RPAREN(int i) {
			return getToken(OGParser.RPAREN, i);
		}
		public TerminalNode From() { return getToken(OGParser.From, 0); }
		public ToCommandContext toCommand() {
			return getRuleContext(ToCommandContext.class,0);
		}
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public CurveCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_curveCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterCurveCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitCurveCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitCurveCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CurveCommandContext curveCommand() throws RecognitionException {
		CurveCommandContext _localctx = new CurveCommandContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_curveCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(275);
			match(Curve);
			setState(276);
			match(DOT);
			setState(277);
			match(WithAngle);
			setState(278);
			match(LPAREN);
			setState(279);
			match(Number);
			setState(280);
			match(RPAREN);
			setState(281);
			match(DOT);
			setState(282);
			match(From);
			setState(283);
			match(LPAREN);
			setState(286);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,23,_ctx) ) {
			case 1:
				{
				setState(284);
				numberTuple();
				}
				break;
			case 2:
				{
				setState(285);
				match(ID);
				}
				break;
			}
			setState(288);
			match(RPAREN);
			setState(289);
			toCommand();
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
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ToCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_toCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterToCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitToCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitToCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ToCommandContext toCommand() throws RecognitionException {
		ToCommandContext _localctx = new ToCommandContext(_ctx, getState());
		enterRule(_localctx, 48, RULE_toCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(291);
			match(T__4);
			setState(292);
			match(LPAREN);
			setState(295);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,24,_ctx) ) {
			case 1:
				{
				setState(293);
				numberTuple();
				}
				break;
			case 2:
				{
				setState(294);
				match(ID);
				}
				break;
			}
			setState(297);
			match(RPAREN);
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

	public static class IterationCommandContext extends ParserRuleContext {
		public NumberIterationContext numberIteration() {
			return getRuleContext(NumberIterationContext.class,0);
		}
		public UntilIterationContext untilIteration() {
			return getRuleContext(UntilIterationContext.class,0);
		}
		public IterationCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_iterationCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterIterationCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitIterationCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitIterationCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IterationCommandContext iterationCommand() throws RecognitionException {
		IterationCommandContext _localctx = new IterationCommandContext(_ctx, getState());
		enterRule(_localctx, 50, RULE_iterationCommand);
		try {
			setState(301);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,25,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(299);
				numberIteration();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(300);
				untilIteration();
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

	public static class NumberIterationContext extends ParserRuleContext {
		public TerminalNode RepeatStart() { return getToken(OGParser.RepeatStart, 0); }
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public TerminalNode RepeatEnd() { return getToken(OGParser.RepeatEnd, 0); }
		public NumberIterationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberIteration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberIteration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberIteration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberIteration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NumberIterationContext numberIteration() throws RecognitionException {
		NumberIterationContext _localctx = new NumberIterationContext(_ctx, getState());
		enterRule(_localctx, 52, RULE_numberIteration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(303);
			match(RepeatStart);
			setState(304);
			match(LPAREN);
			setState(305);
			match(Number);
			setState(306);
			match(RPAREN);
			setState(307);
			body();
			setState(308);
			match(RepeatEnd);
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

	public static class UntilIterationContext extends ParserRuleContext {
		public TerminalNode RepeatStart() { return getToken(OGParser.RepeatStart, 0); }
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode Until() { return getToken(OGParser.Until, 0); }
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public TerminalNode RepeatEnd() { return getToken(OGParser.RepeatEnd, 0); }
		public UntilIterationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_untilIteration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterUntilIteration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitUntilIteration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitUntilIteration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UntilIterationContext untilIteration() throws RecognitionException {
		UntilIterationContext _localctx = new UntilIterationContext(_ctx, getState());
		enterRule(_localctx, 54, RULE_untilIteration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(310);
			match(RepeatStart);
			setState(311);
			match(DOT);
			setState(312);
			match(Until);
			setState(313);
			match(LPAREN);
			setState(314);
			boolExpression(0);
			setState(315);
			match(RPAREN);
			setState(316);
			body();
			setState(317);
			match(RepeatEnd);
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

	public static class FunctionDeclarationContext extends ParserRuleContext {
		public ReturnFunctionDCLContext returnFunctionDCL() {
			return getRuleContext(ReturnFunctionDCLContext.class,0);
		}
		public VoidFunctionDCLContext voidFunctionDCL() {
			return getRuleContext(VoidFunctionDCLContext.class,0);
		}
		public FunctionDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDeclaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFunctionDeclaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFunctionDeclaration(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFunctionDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FunctionDeclarationContext functionDeclaration() throws RecognitionException {
		FunctionDeclarationContext _localctx = new FunctionDeclarationContext(_ctx, getState());
		enterRule(_localctx, 56, RULE_functionDeclaration);
		try {
			setState(321);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,26,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(319);
				returnFunctionDCL();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(320);
				voidFunctionDCL();
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

	public static class ReturnFunctionDCLContext extends ParserRuleContext {
		public TerminalNode FunctionStartWord() { return getToken(OGParser.FunctionStartWord, 0); }
		public TypeWordContext typeWord() {
			return getRuleContext(TypeWordContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ParameterDeclarationsContext parameterDeclarations() {
			return getRuleContext(ParameterDeclarationsContext.class,0);
		}
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public ReturnStatementContext returnStatement() {
			return getRuleContext(ReturnStatementContext.class,0);
		}
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public ReturnFunctionDCLContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_returnFunctionDCL; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterReturnFunctionDCL(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitReturnFunctionDCL(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitReturnFunctionDCL(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ReturnFunctionDCLContext returnFunctionDCL() throws RecognitionException {
		ReturnFunctionDCLContext _localctx = new ReturnFunctionDCLContext(_ctx, getState());
		enterRule(_localctx, 58, RULE_returnFunctionDCL);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(323);
			match(FunctionStartWord);
			setState(324);
			typeWord();
			setState(325);
			match(ID);
			setState(326);
			parameterDeclarations();
			setState(327);
			match(OpenScope);
			setState(328);
			body();
			setState(329);
			returnStatement();
			setState(330);
			match(CloseScope);
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

	public static class TypeWordContext extends ParserRuleContext {
		public TerminalNode PointDCLWord() { return getToken(OGParser.PointDCLWord, 0); }
		public TerminalNode BoolDCLWord() { return getToken(OGParser.BoolDCLWord, 0); }
		public TerminalNode NumberDCLWord() { return getToken(OGParser.NumberDCLWord, 0); }
		public TypeWordContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_typeWord; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterTypeWord(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitTypeWord(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitTypeWord(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TypeWordContext typeWord() throws RecognitionException {
		TypeWordContext _localctx = new TypeWordContext(_ctx, getState());
		enterRule(_localctx, 60, RULE_typeWord);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(332);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PointDCLWord) | (1L << BoolDCLWord) | (1L << NumberDCLWord))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
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

	public static class VoidFunctionDCLContext extends ParserRuleContext {
		public TerminalNode FunctionStartWord() { return getToken(OGParser.FunctionStartWord, 0); }
		public TerminalNode Void() { return getToken(OGParser.Void, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ParameterDeclarationsContext parameterDeclarations() {
			return getRuleContext(ParameterDeclarationsContext.class,0);
		}
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public VoidFunctionDCLContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_voidFunctionDCL; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterVoidFunctionDCL(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitVoidFunctionDCL(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitVoidFunctionDCL(this);
			else return visitor.visitChildren(this);
		}
	}

	public final VoidFunctionDCLContext voidFunctionDCL() throws RecognitionException {
		VoidFunctionDCLContext _localctx = new VoidFunctionDCLContext(_ctx, getState());
		enterRule(_localctx, 62, RULE_voidFunctionDCL);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(334);
			match(FunctionStartWord);
			setState(335);
			match(Void);
			setState(336);
			match(ID);
			setState(337);
			parameterDeclarations();
			setState(338);
			match(OpenScope);
			setState(339);
			body();
			setState(340);
			match(CloseScope);
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

	public static class ParameterDeclarationsContext extends ParserRuleContext {
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public ParametersContext parameters() {
			return getRuleContext(ParametersContext.class,0);
		}
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public ParameterDeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterDeclarations; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterParameterDeclarations(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitParameterDeclarations(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitParameterDeclarations(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ParameterDeclarationsContext parameterDeclarations() throws RecognitionException {
		ParameterDeclarationsContext _localctx = new ParameterDeclarationsContext(_ctx, getState());
		enterRule(_localctx, 64, RULE_parameterDeclarations);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(342);
			match(LPAREN);
			setState(343);
			parameters();
			setState(344);
			match(RPAREN);
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

	public static class ParametersContext extends ParserRuleContext {
		public List<TypeWordContext> typeWord() {
			return getRuleContexts(TypeWordContext.class);
		}
		public TypeWordContext typeWord(int i) {
			return getRuleContext(TypeWordContext.class,i);
		}
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public List<TerminalNode> Seperator() { return getTokens(OGParser.Seperator); }
		public TerminalNode Seperator(int i) {
			return getToken(OGParser.Seperator, i);
		}
		public ParametersContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameters; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterParameters(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitParameters(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitParameters(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ParametersContext parameters() throws RecognitionException {
		ParametersContext _localctx = new ParametersContext(_ctx, getState());
		enterRule(_localctx, 66, RULE_parameters);
		try {
			int _alt;
			setState(359);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case PointDCLWord:
			case BoolDCLWord:
			case NumberDCLWord:
				enterOuterAlt(_localctx, 1);
				{
				setState(352);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,27,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(346);
						typeWord();
						setState(347);
						match(ID);
						setState(348);
						match(Seperator);
						}
						} 
					}
					setState(354);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,27,_ctx);
				}
				setState(355);
				typeWord();
				setState(356);
				match(ID);
				}
				break;
			case RPAREN:
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

	public static class FunctionCallContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode LPAREN() { return getToken(OGParser.LPAREN, 0); }
		public ParameterListContext parameterList() {
			return getRuleContext(ParameterListContext.class,0);
		}
		public TerminalNode RPAREN() { return getToken(OGParser.RPAREN, 0); }
		public FunctionCallContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionCall; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFunctionCall(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFunctionCall(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFunctionCall(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FunctionCallContext functionCall() throws RecognitionException {
		FunctionCallContext _localctx = new FunctionCallContext(_ctx, getState());
		enterRule(_localctx, 68, RULE_functionCall);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(361);
			match(ID);
			setState(362);
			match(LPAREN);
			setState(363);
			parameterList();
			setState(364);
			match(RPAREN);
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

	public static class ParameterListContext extends ParserRuleContext {
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public List<TerminalNode> Seperator() { return getTokens(OGParser.Seperator); }
		public TerminalNode Seperator(int i) {
			return getToken(OGParser.Seperator, i);
		}
		public ParameterListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterList; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterParameterList(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitParameterList(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitParameterList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ParameterListContext parameterList() throws RecognitionException {
		ParameterListContext _localctx = new ParameterListContext(_ctx, getState());
		enterRule(_localctx, 70, RULE_parameterList);
		try {
			int _alt;
			setState(381);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case BooleanValue:
			case Number:
			case LPAREN:
			case ID:
				enterOuterAlt(_localctx, 1);
				{
				setState(373);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,30,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(368);
						_errHandler.sync(this);
						switch ( getInterpreter().adaptivePredict(_input,29,_ctx) ) {
						case 1:
							{
							setState(366);
							match(ID);
							}
							break;
						case 2:
							{
							setState(367);
							expression();
							}
							break;
						}
						setState(370);
						match(Seperator);
						}
						} 
					}
					setState(375);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,30,_ctx);
				}
				setState(378);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,31,_ctx) ) {
				case 1:
					{
					setState(376);
					match(ID);
					}
					break;
				case 2:
					{
					setState(377);
					expression();
					}
					break;
				}
				}
				break;
			case RPAREN:
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

	public static class ReturnStatementContext extends ParserRuleContext {
		public TerminalNode FunctionReturnWord() { return getToken(OGParser.FunctionReturnWord, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public ReturnStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_returnStatement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterReturnStatement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitReturnStatement(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitReturnStatement(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ReturnStatementContext returnStatement() throws RecognitionException {
		ReturnStatementContext _localctx = new ReturnStatementContext(_ctx, getState());
		enterRule(_localctx, 72, RULE_returnStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(383);
			match(FunctionReturnWord);
			setState(386);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,33,_ctx) ) {
			case 1:
				{
				setState(384);
				match(ID);
				}
				break;
			case 2:
				{
				setState(385);
				expression();
				}
				break;
			}
			setState(388);
			match(Terminator);
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

	public static class NumberRefenceContext extends ParserRuleContext {
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public TerminalNode CoordinatePropRef() { return getToken(OGParser.CoordinatePropRef, 0); }
		public NumberRefenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberRefence; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberRefence(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberRefence(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberRefence(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NumberRefenceContext numberRefence() throws RecognitionException {
		NumberRefenceContext _localctx = new NumberRefenceContext(_ctx, getState());
		enterRule(_localctx, 74, RULE_numberRefence);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(390);
			_la = _input.LA(1);
			if ( !(_la==Number || _la==CoordinatePropRef) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
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

	public static class ValueReferenceContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public TerminalNode BooleanValue() { return getToken(OGParser.BooleanValue, 0); }
		public TerminalNode CoordinatePropRef() { return getToken(OGParser.CoordinatePropRef, 0); }
		public ValueReferenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_valueReference; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterValueReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitValueReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitValueReference(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ValueReferenceContext valueReference() throws RecognitionException {
		ValueReferenceContext _localctx = new ValueReferenceContext(_ctx, getState());
		enterRule(_localctx, 76, RULE_valueReference);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(392);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BooleanValue) | (1L << Number) | (1L << CoordinatePropRef) | (1L << ID))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
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

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 14:
			return boolExpression_sempred((BoolExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean boolExpression_sempred(BoolExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 2);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\61\u018d\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\3\2\3\2\3\2\7\2T\n\2"+
		"\f\2\16\2W\13\2\3\2\7\2Z\n\2\f\2\16\2]\13\2\3\3\3\3\3\3\3\3\3\3\3\3\3"+
		"\3\3\3\3\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\5\3\5\3\5\3\5\7\5"+
		"v\n\5\f\5\16\5y\13\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\7\7\u0089\n\7\f\7\16\7\u008c\13\7\3\7\3\7\3\7\3\7\3\7\3\7\5\7\u0094"+
		"\n\7\3\b\3\b\3\b\3\b\5\b\u009a\n\b\3\t\3\t\3\t\5\t\u009f\n\t\3\t\3\t\3"+
		"\n\3\n\3\n\3\n\3\n\3\13\3\13\3\13\3\13\3\13\3\13\5\13\u00ae\n\13\3\f\3"+
		"\f\3\f\3\f\3\f\5\f\u00b5\n\f\3\r\3\r\3\r\3\r\3\16\3\16\3\16\5\16\u00be"+
		"\n\16\3\16\3\16\3\16\3\16\5\16\u00c4\n\16\3\17\3\17\5\17\u00c8\n\17\3"+
		"\20\3\20\3\20\3\20\3\20\3\20\3\20\5\20\u00d1\n\20\3\20\3\20\3\20\7\20"+
		"\u00d6\n\20\f\20\16\20\u00d9\13\20\3\21\3\21\3\21\7\21\u00de\n\21\f\21"+
		"\16\21\u00e1\13\21\3\22\3\22\3\22\7\22\u00e6\n\22\f\22\16\22\u00e9\13"+
		"\22\3\23\3\23\3\23\7\23\u00ee\n\23\f\23\16\23\u00f1\13\23\3\24\3\24\3"+
		"\25\3\25\3\25\3\25\3\25\3\25\3\25\5\25\u00fc\n\25\3\26\3\26\5\26\u0100"+
		"\n\26\3\27\3\27\5\27\u0104\n\27\3\27\3\27\3\30\3\30\3\30\3\30\3\30\3\30"+
		"\5\30\u010e\n\30\3\30\3\30\6\30\u0112\n\30\r\30\16\30\u0113\3\31\3\31"+
		"\3\31\3\31\3\31\3\31\3\31\3\31\3\31\3\31\3\31\5\31\u0121\n\31\3\31\3\31"+
		"\3\31\3\32\3\32\3\32\3\32\5\32\u012a\n\32\3\32\3\32\3\33\3\33\5\33\u0130"+
		"\n\33\3\34\3\34\3\34\3\34\3\34\3\34\3\34\3\35\3\35\3\35\3\35\3\35\3\35"+
		"\3\35\3\35\3\35\3\36\3\36\5\36\u0144\n\36\3\37\3\37\3\37\3\37\3\37\3\37"+
		"\3\37\3\37\3\37\3 \3 \3!\3!\3!\3!\3!\3!\3!\3!\3\"\3\"\3\"\3\"\3#\3#\3"+
		"#\3#\7#\u0161\n#\f#\16#\u0164\13#\3#\3#\3#\3#\5#\u016a\n#\3$\3$\3$\3$"+
		"\3$\3%\3%\5%\u0173\n%\3%\7%\u0176\n%\f%\16%\u0179\13%\3%\3%\5%\u017d\n"+
		"%\3%\5%\u0180\n%\3&\3&\3&\5&\u0185\n&\3&\3&\3\'\3\'\3(\3(\3(\2\3\36)\2"+
		"\4\6\b\n\f\16\20\22\24\26\30\32\34\36 \"$&(*,.\60\62\64\668:<>@BDFHJL"+
		"N\2\7\3\2\37 \3\2!\"\3\2\r\17\4\2\t\t\60\60\4\2\b\t\60\61\2\u0192\2P\3"+
		"\2\2\2\4^\3\2\2\2\6g\3\2\2\2\bq\3\2\2\2\n|\3\2\2\2\f\u0093\3\2\2\2\16"+
		"\u0095\3\2\2\2\20\u009e\3\2\2\2\22\u00a2\3\2\2\2\24\u00a7\3\2\2\2\26\u00af"+
		"\3\2\2\2\30\u00b6\3\2\2\2\32\u00bd\3\2\2\2\34\u00c7\3\2\2\2\36\u00d0\3"+
		"\2\2\2 \u00da\3\2\2\2\"\u00e2\3\2\2\2$\u00ea\3\2\2\2&\u00f2\3\2\2\2(\u00fb"+
		"\3\2\2\2*\u00ff\3\2\2\2,\u0103\3\2\2\2.\u0107\3\2\2\2\60\u0115\3\2\2\2"+
		"\62\u0125\3\2\2\2\64\u012f\3\2\2\2\66\u0131\3\2\2\28\u0138\3\2\2\2:\u0143"+
		"\3\2\2\2<\u0145\3\2\2\2>\u014e\3\2\2\2@\u0150\3\2\2\2B\u0158\3\2\2\2D"+
		"\u0169\3\2\2\2F\u016b\3\2\2\2H\u017f\3\2\2\2J\u0181\3\2\2\2L\u0188\3\2"+
		"\2\2N\u018a\3\2\2\2PQ\5\6\4\2QU\5\b\5\2RT\5:\36\2SR\3\2\2\2TW\3\2\2\2"+
		"US\3\2\2\2UV\3\2\2\2V[\3\2\2\2WU\3\2\2\2XZ\5\n\6\2YX\3\2\2\2Z]\3\2\2\2"+
		"[Y\3\2\2\2[\\\3\2\2\2\\\3\3\2\2\2][\3\2\2\2^_\7\3\2\2_`\7\t\2\2`a\7/\2"+
		"\2ab\7\t\2\2bc\7/\2\2cd\7\t\2\2de\7/\2\2ef\7\t\2\2f\5\3\2\2\2gh\7\4\2"+
		"\2hi\7\31\2\2ij\7\5\2\2jk\7\31\2\2kl\7\6\2\2lm\7\35\2\2mn\5\4\3\2no\7"+
		"\36\2\2op\7.\2\2p\7\3\2\2\2qr\7\20\2\2rw\7,\2\2st\7\61\2\2tv\7.\2\2us"+
		"\3\2\2\2vy\3\2\2\2wu\3\2\2\2wx\3\2\2\2xz\3\2\2\2yw\3\2\2\2z{\7-\2\2{\t"+
		"\3\2\2\2|}\7\f\2\2}~\7\61\2\2~\177\7,\2\2\177\u0080\5\f\7\2\u0080\u0081"+
		"\7-\2\2\u0081\13\3\2\2\2\u0082\u008a\7,\2\2\u0083\u0089\5\34\17\2\u0084"+
		"\u0089\5\20\t\2\u0085\u0089\5\16\b\2\u0086\u0089\5F$\2\u0087\u0089\5*"+
		"\26\2\u0088\u0083\3\2\2\2\u0088\u0084\3\2\2\2\u0088\u0085\3\2\2\2\u0088"+
		"\u0086\3\2\2\2\u0088\u0087\3\2\2\2\u0089\u008c\3\2\2\2\u008a\u0088\3\2"+
		"\2\2\u008a\u008b\3\2\2\2\u008b\u008d\3\2\2\2\u008c\u008a\3\2\2\2\u008d"+
		"\u0094\7-\2\2\u008e\u008f\7,\2\2\u008f\u0090\5\f\7\2\u0090\u0091\7-\2"+
		"\2\u0091\u0094\3\2\2\2\u0092\u0094\3\2\2\2\u0093\u0082\3\2\2\2\u0093\u008e"+
		"\3\2\2\2\u0093\u0092\3\2\2\2\u0094\r\3\2\2\2\u0095\u0096\7\61\2\2\u0096"+
		"\u0099\7+\2\2\u0097\u009a\7\61\2\2\u0098\u009a\5\34\17\2\u0099\u0097\3"+
		"\2\2\2\u0099\u0098\3\2\2\2\u009a\17\3\2\2\2\u009b\u009f\5\24\13\2\u009c"+
		"\u009f\5\26\f\2\u009d\u009f\5\22\n\2\u009e\u009b\3\2\2\2\u009e\u009c\3"+
		"\2\2\2\u009e\u009d\3\2\2\2\u009f\u00a0\3\2\2\2\u00a0\u00a1\7.\2\2\u00a1"+
		"\21\3\2\2\2\u00a2\u00a3\7\16\2\2\u00a3\u00a4\7\61\2\2\u00a4\u00a5\7+\2"+
		"\2\u00a5\u00a6\5\36\20\2\u00a6\23\3\2\2\2\u00a7\u00a8\7\17\2\2\u00a8\u00a9"+
		"\7\61\2\2\u00a9\u00ad\7+\2\2\u00aa\u00ae\7\61\2\2\u00ab\u00ae\5 \21\2"+
		"\u00ac\u00ae\5N(\2\u00ad\u00aa\3\2\2\2\u00ad\u00ab\3\2\2\2\u00ad\u00ac"+
		"\3\2\2\2\u00ae\25\3\2\2\2\u00af\u00b0\7\r\2\2\u00b0\u00b1\7\61\2\2\u00b1"+
		"\u00b4\7+\2\2\u00b2\u00b5\5\30\r\2\u00b3\u00b5\7\61\2\2\u00b4\u00b2\3"+
		"\2\2\2\u00b4\u00b3\3\2\2\2\u00b5\27\3\2\2\2\u00b6\u00b7\7\35\2\2\u00b7"+
		"\u00b8\5\32\16\2\u00b8\u00b9\7\36\2\2\u00b9\31\3\2\2\2\u00ba\u00be\7\t"+
		"\2\2\u00bb\u00be\5 \21\2\u00bc\u00be\5L\'\2\u00bd\u00ba\3\2\2\2\u00bd"+
		"\u00bb\3\2\2\2\u00bd\u00bc\3\2\2\2\u00be\u00bf\3\2\2\2\u00bf\u00c3\7/"+
		"\2\2\u00c0\u00c4\7\t\2\2\u00c1\u00c4\5 \21\2\u00c2\u00c4\5L\'\2\u00c3"+
		"\u00c0\3\2\2\2\u00c3\u00c1\3\2\2\2\u00c3\u00c2\3\2\2\2\u00c4\33\3\2\2"+
		"\2\u00c5\u00c8\5 \21\2\u00c6\u00c8\5\36\20\2\u00c7\u00c5\3\2\2\2\u00c7"+
		"\u00c6\3\2\2\2\u00c8\35\3\2\2\2\u00c9\u00ca\b\20\1\2\u00ca\u00cb\5 \21"+
		"\2\u00cb\u00cc\7%\2\2\u00cc\u00cd\5 \21\2\u00cd\u00d1\3\2\2\2\u00ce\u00d1"+
		"\7\b\2\2\u00cf\u00d1\5F$\2\u00d0\u00c9\3\2\2\2\u00d0\u00ce\3\2\2\2\u00d0"+
		"\u00cf\3\2\2\2\u00d1\u00d7\3\2\2\2\u00d2\u00d3\f\4\2\2\u00d3\u00d4\7$"+
		"\2\2\u00d4\u00d6\5\36\20\5\u00d5\u00d2\3\2\2\2\u00d6\u00d9\3\2\2\2\u00d7"+
		"\u00d5\3\2\2\2\u00d7\u00d8\3\2\2\2\u00d8\37\3\2\2\2\u00d9\u00d7\3\2\2"+
		"\2\u00da\u00df\5\"\22\2\u00db\u00dc\t\2\2\2\u00dc\u00de\5\"\22\2\u00dd"+
		"\u00db\3\2\2\2\u00de\u00e1\3\2\2\2\u00df\u00dd\3\2\2\2\u00df\u00e0\3\2"+
		"\2\2\u00e0!\3\2\2\2\u00e1\u00df\3\2\2\2\u00e2\u00e7\5$\23\2\u00e3\u00e4"+
		"\t\3\2\2\u00e4\u00e6\5$\23\2\u00e5\u00e3\3\2\2\2\u00e6\u00e9\3\2\2\2\u00e7"+
		"\u00e5\3\2\2\2\u00e7\u00e8\3\2\2\2\u00e8#\3\2\2\2\u00e9\u00e7\3\2\2\2"+
		"\u00ea\u00ef\5&\24\2\u00eb\u00ec\7#\2\2\u00ec\u00ee\5&\24\2\u00ed\u00eb"+
		"\3\2\2\2\u00ee\u00f1\3\2\2\2\u00ef\u00ed\3\2\2\2\u00ef\u00f0\3\2\2\2\u00f0"+
		"%\3\2\2\2\u00f1\u00ef\3\2\2\2\u00f2\u00f3\5(\25\2\u00f3\'\3\2\2\2\u00f4"+
		"\u00fc\7\t\2\2\u00f5\u00fc\7\61\2\2\u00f6\u00f7\7\35\2\2\u00f7\u00f8\5"+
		" \21\2\u00f8\u00f9\7\36\2\2\u00f9\u00fc\3\2\2\2\u00fa\u00fc\5F$\2\u00fb"+
		"\u00f4\3\2\2\2\u00fb\u00f5\3\2\2\2\u00fb\u00f6\3\2\2\2\u00fb\u00fa\3\2"+
		"\2\2\u00fc)\3\2\2\2\u00fd\u0100\5\64\33\2\u00fe\u0100\5,\27\2\u00ff\u00fd"+
		"\3\2\2\2\u00ff\u00fe\3\2\2\2\u0100+\3\2\2\2\u0101\u0104\5.\30\2\u0102"+
		"\u0104\5\60\31\2\u0103\u0101\3\2\2\2\u0103\u0102\3\2\2\2\u0104\u0105\3"+
		"\2\2\2\u0105\u0106\7.\2\2\u0106-\3\2\2\2\u0107\u0108\7\23\2\2\u0108\u0109"+
		"\7\31\2\2\u0109\u010a\7\25\2\2\u010a\u010d\7\35\2\2\u010b\u010e\5\32\16"+
		"\2\u010c\u010e\7\61\2\2\u010d\u010b\3\2\2\2\u010d\u010c\3\2\2\2\u010e"+
		"\u010f\3\2\2\2\u010f\u0111\7\36\2\2\u0110\u0112\5\62\32\2\u0111\u0110"+
		"\3\2\2\2\u0112\u0113\3\2\2\2\u0113\u0111\3\2\2\2\u0113\u0114\3\2\2\2\u0114"+
		"/\3\2\2\2\u0115\u0116\7\22\2\2\u0116\u0117\7\31\2\2\u0117\u0118\7\21\2"+
		"\2\u0118\u0119\7\35\2\2\u0119\u011a\7\t\2\2\u011a\u011b\7\36\2\2\u011b"+
		"\u011c\7\31\2\2\u011c\u011d\7\25\2\2\u011d\u0120\7\35\2\2\u011e\u0121"+
		"\5\32\16\2\u011f\u0121\7\61\2\2\u0120\u011e\3\2\2\2\u0120\u011f\3\2\2"+
		"\2\u0121\u0122\3\2\2\2\u0122\u0123\7\36\2\2\u0123\u0124\5\62\32\2\u0124"+
		"\61\3\2\2\2\u0125\u0126\7\7\2\2\u0126\u0129\7\35\2\2\u0127\u012a\5\32"+
		"\16\2\u0128\u012a\7\61\2\2\u0129\u0127\3\2\2\2\u0129\u0128\3\2\2\2\u012a"+
		"\u012b\3\2\2\2\u012b\u012c\7\36\2\2\u012c\63\3\2\2\2\u012d\u0130\5\66"+
		"\34\2\u012e\u0130\58\35\2\u012f\u012d\3\2\2\2\u012f\u012e\3\2\2\2\u0130"+
		"\65\3\2\2\2\u0131\u0132\7\26\2\2\u0132\u0133\7\35\2\2\u0133\u0134\7\t"+
		"\2\2\u0134\u0135\7\36\2\2\u0135\u0136\5\f\7\2\u0136\u0137\7\27\2\2\u0137"+
		"\67\3\2\2\2\u0138\u0139\7\26\2\2\u0139\u013a\7\31\2\2\u013a\u013b\7\30"+
		"\2\2\u013b\u013c\7\35\2\2\u013c\u013d\5\36\20\2\u013d\u013e\7\36\2\2\u013e"+
		"\u013f\5\f\7\2\u013f\u0140\7\27\2\2\u01409\3\2\2\2\u0141\u0144\5<\37\2"+
		"\u0142\u0144\5@!\2\u0143\u0141\3\2\2\2\u0143\u0142\3\2\2\2\u0144;\3\2"+
		"\2\2\u0145\u0146\7\32\2\2\u0146\u0147\5> \2\u0147\u0148\7\61\2\2\u0148"+
		"\u0149\5B\"\2\u0149\u014a\7,\2\2\u014a\u014b\5\f\7\2\u014b\u014c\5J&\2"+
		"\u014c\u014d\7-\2\2\u014d=\3\2\2\2\u014e\u014f\t\4\2\2\u014f?\3\2\2\2"+
		"\u0150\u0151\7\32\2\2\u0151\u0152\7\34\2\2\u0152\u0153\7\61\2\2\u0153"+
		"\u0154\5B\"\2\u0154\u0155\7,\2\2\u0155\u0156\5\f\7\2\u0156\u0157\7-\2"+
		"\2\u0157A\3\2\2\2\u0158\u0159\7\35\2\2\u0159\u015a\5D#\2\u015a\u015b\7"+
		"\36\2\2\u015bC\3\2\2\2\u015c\u015d\5> \2\u015d\u015e\7\61\2\2\u015e\u015f"+
		"\7/\2\2\u015f\u0161\3\2\2\2\u0160\u015c\3\2\2\2\u0161\u0164\3\2\2\2\u0162"+
		"\u0160\3\2\2\2\u0162\u0163\3\2\2\2\u0163\u0165\3\2\2\2\u0164\u0162\3\2"+
		"\2\2\u0165\u0166\5> \2\u0166\u0167\7\61\2\2\u0167\u016a\3\2\2\2\u0168"+
		"\u016a\3\2\2\2\u0169\u0162\3\2\2\2\u0169\u0168\3\2\2\2\u016aE\3\2\2\2"+
		"\u016b\u016c\7\61\2\2\u016c\u016d\7\35\2\2\u016d\u016e\5H%\2\u016e\u016f"+
		"\7\36\2\2\u016fG\3\2\2\2\u0170\u0173\7\61\2\2\u0171\u0173\5\34\17\2\u0172"+
		"\u0170\3\2\2\2\u0172\u0171\3\2\2\2\u0173\u0174\3\2\2\2\u0174\u0176\7/"+
		"\2\2\u0175\u0172\3\2\2\2\u0176\u0179\3\2\2\2\u0177\u0175\3\2\2\2\u0177"+
		"\u0178\3\2\2\2\u0178\u017c\3\2\2\2\u0179\u0177\3\2\2\2\u017a\u017d\7\61"+
		"\2\2\u017b\u017d\5\34\17\2\u017c\u017a\3\2\2\2\u017c\u017b\3\2\2\2\u017d"+
		"\u0180\3\2\2\2\u017e\u0180\3\2\2\2\u017f\u0177\3\2\2\2\u017f\u017e\3\2"+
		"\2\2\u0180I\3\2\2\2\u0181\u0184\7\33\2\2\u0182\u0185\7\61\2\2\u0183\u0185"+
		"\5\34\17\2\u0184\u0182\3\2\2\2\u0184\u0183\3\2\2\2\u0185\u0186\3\2\2\2"+
		"\u0186\u0187\7.\2\2\u0187K\3\2\2\2\u0188\u0189\t\5\2\2\u0189M\3\2\2\2"+
		"\u018a\u018b\t\6\2\2\u018bO\3\2\2\2$U[w\u0088\u008a\u0093\u0099\u009e"+
		"\u00ad\u00b4\u00bd\u00c3\u00c7\u00d0\u00d7\u00df\u00e7\u00ef\u00fb\u00ff"+
		"\u0103\u010d\u0113\u0120\u0129\u012f\u0143\u0162\u0169\u0172\u0177\u017c"+
		"\u017f\u0184";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}