// Generated from /Users/saxjax/developer/P4-project/OG/OG/OG.g4 by ANTLR 4.9.1
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
		T__0=1, Number=2, BooleanValue=3, WS=4, COMMENT=5, ShapeDCLWord=6, PointDCLWord=7, 
		BoolDCLWord=8, NumberDCLWord=9, DrawDCLWord=10, WithAngle=11, Curve=12, 
		Line=13, To=14, From=15, RepeatStart=16, RepeatEnd=17, Until=18, DOT=19, 
		FunctionStartWord=20, FunctionReturnWord=21, Void=22, LParen=23, RParen=24, 
		Plus_Minus=25, Plus=26, Minus=27, Mul_Div=28, Times=29, Div=30, Pow=31, 
		LogicOperator=32, BoolOperator=33, NOT=34, Assign=35, OpenScope=36, CloseScope=37, 
		Terminator=38, Seperator=39, XMIN=40, XMAX=41, YMAX=42, YMIN=43, Machine=44, 
		WorkArea=45, Size=46, StartPointReference=47, EndPointReference=48, If=49, 
		Then=50, CoordinateXYValue=51, ID=52;
	public static final int
		RULE_program = 0, RULE_machineVariables = 1, RULE_machine = 2, RULE_draw = 3, 
		RULE_shapeDefinition = 4, RULE_body = 5, RULE_declaration = 6, RULE_booleanDeclaration = 7, 
		RULE_numberDeclaration = 8, RULE_pointDeclaration = 9, RULE_pointReference = 10, 
		RULE_numberTuple = 11, RULE_assignment = 12, RULE_propertyAssignment = 13, 
		RULE_variableAssignment = 14, RULE_idAssign = 15, RULE_boolAssignment = 16, 
		RULE_numberAssignment = 17, RULE_pointAssignment = 18, RULE_startPointAssignment = 19, 
		RULE_endPointAssignment = 20, RULE_expression = 21, RULE_mathExpression = 22, 
		RULE_term = 23, RULE_factor = 24, RULE_atom = 25, RULE_boolExpression = 26, 
		RULE_command = 27, RULE_movementCommand = 28, RULE_lineCommand = 29, RULE_curveCommand = 30, 
		RULE_toCommand = 31, RULE_drawCommand = 32, RULE_iterationCommand = 33, 
		RULE_numberIteration = 34, RULE_untilIteration = 35, RULE_functionDeclaration = 36, 
		RULE_returnFunctionDCL = 37, RULE_typeWord = 38, RULE_voidFunctionDCL = 39, 
		RULE_parameterDeclarations = 40, RULE_parameters = 41, RULE_functionCall = 42, 
		RULE_parameterList = 43, RULE_returnStatement = 44;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "machineVariables", "machine", "draw", "shapeDefinition", 
			"body", "declaration", "booleanDeclaration", "numberDeclaration", "pointDeclaration", 
			"pointReference", "numberTuple", "assignment", "propertyAssignment", 
			"variableAssignment", "idAssign", "boolAssignment", "numberAssignment", 
			"pointAssignment", "startPointAssignment", "endPointAssignment", "expression", 
			"mathExpression", "term", "factor", "atom", "boolExpression", "command", 
			"movementCommand", "lineCommand", "curveCommand", "toCommand", "drawCommand", 
			"iterationCommand", "numberIteration", "untilIteration", "functionDeclaration", 
			"returnFunctionDCL", "typeWord", "voidFunctionDCL", "parameterDeclarations", 
			"parameters", "functionCall", "parameterList", "returnStatement"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'.to'", null, null, null, null, "'shape'", "'point'", "'bool'", 
			"'number'", "'draw'", "'withAngle'", "'curve'", "'line'", "'to'", "'from'", 
			"'repeat'", "'repeat.end'", "'until'", "'.'", "'function'", "'return'", 
			"'void'", "'('", "')'", null, "'+'", "'-'", null, "'*'", "'/'", "'^'", 
			null, null, "'!'", "'='", "'{'", "'}'", "';'", "','", "'xmin'", "'xmax'", 
			"'ymin'", "'ymax'", "'Machine'", "'WorkArea'", "'size'", null, null, 
			"'if'", "'then'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, "Number", "BooleanValue", "WS", "COMMENT", "ShapeDCLWord", 
			"PointDCLWord", "BoolDCLWord", "NumberDCLWord", "DrawDCLWord", "WithAngle", 
			"Curve", "Line", "To", "From", "RepeatStart", "RepeatEnd", "Until", "DOT", 
			"FunctionStartWord", "FunctionReturnWord", "Void", "LParen", "RParen", 
			"Plus_Minus", "Plus", "Minus", "Mul_Div", "Times", "Div", "Pow", "LogicOperator", 
			"BoolOperator", "NOT", "Assign", "OpenScope", "CloseScope", "Terminator", 
			"Seperator", "XMIN", "XMAX", "YMAX", "YMIN", "Machine", "WorkArea", "Size", 
			"StartPointReference", "EndPointReference", "If", "Then", "CoordinateXYValue", 
			"ID"
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
			setState(90);
			machine();
			setState(91);
			draw();
			setState(95);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==FunctionStartWord) {
				{
				{
				setState(92);
				functionDeclaration();
				}
				}
				setState(97);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(101);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ShapeDCLWord) {
				{
				{
				setState(98);
				shapeDefinition();
				}
				}
				setState(103);
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
		public TerminalNode XMIN() { return getToken(OGParser.XMIN, 0); }
		public List<TerminalNode> Assign() { return getTokens(OGParser.Assign); }
		public TerminalNode Assign(int i) {
			return getToken(OGParser.Assign, i);
		}
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public List<TerminalNode> Seperator() { return getTokens(OGParser.Seperator); }
		public TerminalNode Seperator(int i) {
			return getToken(OGParser.Seperator, i);
		}
		public TerminalNode XMAX() { return getToken(OGParser.XMAX, 0); }
		public TerminalNode YMAX() { return getToken(OGParser.YMAX, 0); }
		public TerminalNode YMIN() { return getToken(OGParser.YMIN, 0); }
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
			setState(104);
			match(XMIN);
			setState(105);
			match(Assign);
			setState(106);
			mathExpression();
			setState(107);
			match(Seperator);
			setState(108);
			match(XMAX);
			setState(109);
			match(Assign);
			setState(110);
			mathExpression();
			setState(111);
			match(Seperator);
			setState(112);
			match(YMAX);
			setState(113);
			match(Assign);
			setState(114);
			mathExpression();
			setState(115);
			match(Seperator);
			setState(116);
			match(YMIN);
			setState(117);
			match(Assign);
			setState(118);
			mathExpression();
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
		public TerminalNode Machine() { return getToken(OGParser.Machine, 0); }
		public List<TerminalNode> DOT() { return getTokens(OGParser.DOT); }
		public TerminalNode DOT(int i) {
			return getToken(OGParser.DOT, i);
		}
		public TerminalNode WorkArea() { return getToken(OGParser.WorkArea, 0); }
		public TerminalNode Size() { return getToken(OGParser.Size, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public MachineVariablesContext machineVariables() {
			return getRuleContext(MachineVariablesContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
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
			setState(120);
			match(Machine);
			setState(121);
			match(DOT);
			setState(122);
			match(WorkArea);
			setState(123);
			match(DOT);
			setState(124);
			match(Size);
			setState(125);
			match(LParen);
			setState(126);
			machineVariables();
			setState(127);
			match(RParen);
			setState(128);
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
		public List<DrawCommandContext> drawCommand() {
			return getRuleContexts(DrawCommandContext.class);
		}
		public DrawCommandContext drawCommand(int i) {
			return getRuleContext(DrawCommandContext.class,i);
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
			setState(130);
			match(DrawDCLWord);
			setState(131);
			match(OpenScope);
			setState(135);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ID) {
				{
				{
				setState(132);
				drawCommand();
				}
				}
				setState(137);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(138);
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
			setState(140);
			match(ShapeDCLWord);
			setState(141);
			match(ID);
			setState(142);
			match(OpenScope);
			setState(143);
			body();
			setState(144);
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
		public List<CommandContext> command() {
			return getRuleContexts(CommandContext.class);
		}
		public CommandContext command(int i) {
			return getRuleContext(CommandContext.class,i);
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
			setState(155);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Number:
			case BooleanValue:
			case PointDCLWord:
			case BoolDCLWord:
			case NumberDCLWord:
			case Curve:
			case Line:
			case RepeatStart:
			case LParen:
			case NOT:
			case StartPointReference:
			case EndPointReference:
			case CoordinateXYValue:
			case ID:
				enterOuterAlt(_localctx, 1);
				{
				setState(150); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					setState(150);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
					case 1:
						{
						setState(146);
						expression();
						}
						break;
					case 2:
						{
						setState(147);
						declaration();
						}
						break;
					case 3:
						{
						setState(148);
						assignment();
						}
						break;
					case 4:
						{
						setState(149);
						command();
						}
						break;
					}
					}
					setState(152); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Number) | (1L << BooleanValue) | (1L << PointDCLWord) | (1L << BoolDCLWord) | (1L << NumberDCLWord) | (1L << Curve) | (1L << Line) | (1L << RepeatStart) | (1L << LParen) | (1L << NOT) | (1L << StartPointReference) | (1L << EndPointReference) | (1L << CoordinateXYValue) | (1L << ID))) != 0) );
				}
				break;
			case RepeatEnd:
			case FunctionReturnWord:
			case CloseScope:
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
		enterRule(_localctx, 12, RULE_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(160);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NumberDCLWord:
				{
				setState(157);
				numberDeclaration();
				}
				break;
			case PointDCLWord:
				{
				setState(158);
				pointDeclaration();
				}
				break;
			case BoolDCLWord:
				{
				setState(159);
				booleanDeclaration();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(162);
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
		enterRule(_localctx, 14, RULE_booleanDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(164);
			match(BoolDCLWord);
			setState(165);
			match(ID);
			setState(166);
			match(Assign);
			setState(167);
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
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
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
		enterRule(_localctx, 16, RULE_numberDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(169);
			match(NumberDCLWord);
			setState(170);
			match(ID);
			setState(171);
			match(Assign);
			setState(172);
			mathExpression();
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
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
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
		enterRule(_localctx, 18, RULE_pointDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(174);
			match(PointDCLWord);
			setState(175);
			match(ID);
			setState(176);
			match(Assign);
			setState(179);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
			case 1:
				{
				setState(177);
				pointReference();
				}
				break;
			case 2:
				{
				setState(178);
				match(ID);
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

	public static class PointReferenceContext extends ParserRuleContext {
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode StartPointReference() { return getToken(OGParser.StartPointReference, 0); }
		public TerminalNode EndPointReference() { return getToken(OGParser.EndPointReference, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public PointReferenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pointReference; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointReference(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PointReferenceContext pointReference() throws RecognitionException {
		PointReferenceContext _localctx = new PointReferenceContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_pointReference);
		try {
			setState(188);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case LParen:
				enterOuterAlt(_localctx, 1);
				{
				setState(181);
				match(LParen);
				setState(182);
				numberTuple();
				setState(183);
				match(RParen);
				}
				break;
			case StartPointReference:
				enterOuterAlt(_localctx, 2);
				{
				setState(185);
				match(StartPointReference);
				}
				break;
			case EndPointReference:
				enterOuterAlt(_localctx, 3);
				{
				setState(186);
				match(EndPointReference);
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 4);
				{
				setState(187);
				functionCall();
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

	public static class NumberTupleContext extends ParserRuleContext {
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public TerminalNode Seperator() { return getToken(OGParser.Seperator, 0); }
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
		enterRule(_localctx, 22, RULE_numberTuple);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(190);
			mathExpression();
			setState(191);
			match(Seperator);
			setState(192);
			mathExpression();
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
		public VariableAssignmentContext variableAssignment() {
			return getRuleContext(VariableAssignmentContext.class,0);
		}
		public PropertyAssignmentContext propertyAssignment() {
			return getRuleContext(PropertyAssignmentContext.class,0);
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
		enterRule(_localctx, 24, RULE_assignment);
		try {
			setState(196);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case StartPointReference:
			case EndPointReference:
			case ID:
				enterOuterAlt(_localctx, 1);
				{
				setState(194);
				variableAssignment();
				}
				break;
			case CoordinateXYValue:
				enterOuterAlt(_localctx, 2);
				{
				setState(195);
				propertyAssignment();
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

	public static class PropertyAssignmentContext extends ParserRuleContext {
		public TerminalNode CoordinateXYValue() { return getToken(OGParser.CoordinateXYValue, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public PropertyAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_propertyAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPropertyAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPropertyAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPropertyAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PropertyAssignmentContext propertyAssignment() throws RecognitionException {
		PropertyAssignmentContext _localctx = new PropertyAssignmentContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_propertyAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(198);
			match(CoordinateXYValue);
			setState(199);
			match(Assign);
			setState(200);
			mathExpression();
			setState(201);
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

	public static class VariableAssignmentContext extends ParserRuleContext {
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public IdAssignContext idAssign() {
			return getRuleContext(IdAssignContext.class,0);
		}
		public BoolAssignmentContext boolAssignment() {
			return getRuleContext(BoolAssignmentContext.class,0);
		}
		public NumberAssignmentContext numberAssignment() {
			return getRuleContext(NumberAssignmentContext.class,0);
		}
		public PointAssignmentContext pointAssignment() {
			return getRuleContext(PointAssignmentContext.class,0);
		}
		public VariableAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterVariableAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitVariableAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitVariableAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final VariableAssignmentContext variableAssignment() throws RecognitionException {
		VariableAssignmentContext _localctx = new VariableAssignmentContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_variableAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(207);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				{
				setState(203);
				idAssign();
				}
				break;
			case 2:
				{
				setState(204);
				boolAssignment();
				}
				break;
			case 3:
				{
				setState(205);
				numberAssignment();
				}
				break;
			case 4:
				{
				setState(206);
				pointAssignment();
				}
				break;
			}
			setState(209);
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

	public static class IdAssignContext extends ParserRuleContext {
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public IdAssignContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_idAssign; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterIdAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitIdAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitIdAssign(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IdAssignContext idAssign() throws RecognitionException {
		IdAssignContext _localctx = new IdAssignContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_idAssign);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(211);
			match(ID);
			setState(212);
			match(Assign);
			setState(213);
			match(ID);
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

	public static class BoolAssignmentContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public BoolAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_boolAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final BoolAssignmentContext boolAssignment() throws RecognitionException {
		BoolAssignmentContext _localctx = new BoolAssignmentContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_boolAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(215);
			match(ID);
			setState(216);
			match(Assign);
			setState(217);
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

	public static class NumberAssignmentContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public NumberAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_numberAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NumberAssignmentContext numberAssignment() throws RecognitionException {
		NumberAssignmentContext _localctx = new NumberAssignmentContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_numberAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(219);
			match(ID);
			setState(220);
			match(Assign);
			setState(221);
			mathExpression();
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

	public static class PointAssignmentContext extends ParserRuleContext {
		public EndPointAssignmentContext endPointAssignment() {
			return getRuleContext(EndPointAssignmentContext.class,0);
		}
		public StartPointAssignmentContext startPointAssignment() {
			return getRuleContext(StartPointAssignmentContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public PointAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pointAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PointAssignmentContext pointAssignment() throws RecognitionException {
		PointAssignmentContext _localctx = new PointAssignmentContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_pointAssignment);
		try {
			setState(231);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case EndPointReference:
				enterOuterAlt(_localctx, 1);
				{
				setState(223);
				endPointAssignment();
				}
				break;
			case StartPointReference:
				enterOuterAlt(_localctx, 2);
				{
				setState(224);
				startPointAssignment();
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 3);
				{
				setState(229);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
				case 1:
					{
					setState(225);
					match(ID);
					setState(226);
					match(Assign);
					setState(227);
					pointReference();
					}
					break;
				case 2:
					{
					setState(228);
					match(ID);
					}
					break;
				}
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

	public static class StartPointAssignmentContext extends ParserRuleContext {
		public TerminalNode StartPointReference() { return getToken(OGParser.StartPointReference, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public StartPointAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_startPointAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterStartPointAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitStartPointAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitStartPointAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final StartPointAssignmentContext startPointAssignment() throws RecognitionException {
		StartPointAssignmentContext _localctx = new StartPointAssignmentContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_startPointAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(233);
			match(StartPointReference);
			setState(234);
			match(Assign);
			setState(235);
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

	public static class EndPointAssignmentContext extends ParserRuleContext {
		public TerminalNode EndPointReference() { return getToken(OGParser.EndPointReference, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public EndPointAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_endPointAssignment; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterEndPointAssignment(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitEndPointAssignment(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitEndPointAssignment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EndPointAssignmentContext endPointAssignment() throws RecognitionException {
		EndPointAssignmentContext _localctx = new EndPointAssignmentContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_endPointAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(237);
			match(EndPointReference);
			setState(238);
			match(Assign);
			setState(239);
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

	public static class ExpressionContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
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
		enterRule(_localctx, 42, RULE_expression);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(245);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				{
				setState(241);
				match(ID);
				}
				break;
			case 2:
				{
				setState(242);
				mathExpression();
				}
				break;
			case 3:
				{
				setState(243);
				boolExpression(0);
				}
				break;
			case 4:
				{
				setState(244);
				functionCall();
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

	public static class MathExpressionContext extends ParserRuleContext {
		public List<TermContext> term() {
			return getRuleContexts(TermContext.class);
		}
		public TermContext term(int i) {
			return getRuleContext(TermContext.class,i);
		}
		public List<TerminalNode> Plus_Minus() { return getTokens(OGParser.Plus_Minus); }
		public TerminalNode Plus_Minus(int i) {
			return getToken(OGParser.Plus_Minus, i);
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
		enterRule(_localctx, 44, RULE_mathExpression);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(247);
			term();
			setState(252);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,14,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					{
					setState(248);
					match(Plus_Minus);
					}
					setState(249);
					term();
					}
					} 
				}
				setState(254);
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
		public List<TerminalNode> Mul_Div() { return getTokens(OGParser.Mul_Div); }
		public TerminalNode Mul_Div(int i) {
			return getToken(OGParser.Mul_Div, i);
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
		enterRule(_localctx, 46, RULE_term);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(255);
			factor();
			setState(260);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,15,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					{
					setState(256);
					match(Mul_Div);
					}
					setState(257);
					factor();
					}
					} 
				}
				setState(262);
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

	public static class FactorContext extends ParserRuleContext {
		public List<AtomContext> atom() {
			return getRuleContexts(AtomContext.class);
		}
		public AtomContext atom(int i) {
			return getRuleContext(AtomContext.class,i);
		}
		public List<TerminalNode> Pow() { return getTokens(OGParser.Pow); }
		public TerminalNode Pow(int i) {
			return getToken(OGParser.Pow, i);
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
		enterRule(_localctx, 48, RULE_factor);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(263);
			atom();
			setState(268);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,16,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(264);
					match(Pow);
					setState(265);
					atom();
					}
					} 
				}
				setState(270);
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

	public static class AtomContext extends ParserRuleContext {
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public TerminalNode CoordinateXYValue() { return getToken(OGParser.CoordinateXYValue, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
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
		enterRule(_localctx, 50, RULE_atom);
		try {
			setState(279);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,17,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(271);
				functionCall();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(272);
				match(Number);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(273);
				match(CoordinateXYValue);
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(274);
				match(ID);
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(275);
				match(LParen);
				setState(276);
				mathExpression();
				setState(277);
				match(RParen);
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

	public static class BoolExpressionContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode BooleanValue() { return getToken(OGParser.BooleanValue, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public TerminalNode BoolOperator() { return getToken(OGParser.BoolOperator, 0); }
		public TerminalNode NOT() { return getToken(OGParser.NOT, 0); }
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
		int _startState = 52;
		enterRecursionRule(_localctx, 52, RULE_boolExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(291);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,18,_ctx) ) {
			case 1:
				{
				setState(282);
				match(ID);
				}
				break;
			case 2:
				{
				setState(283);
				match(BooleanValue);
				}
				break;
			case 3:
				{
				setState(284);
				functionCall();
				}
				break;
			case 4:
				{
				setState(285);
				mathExpression();
				setState(286);
				match(BoolOperator);
				setState(287);
				mathExpression();
				}
				break;
			case 5:
				{
				setState(289);
				match(NOT);
				setState(290);
				boolExpression(1);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(298);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new BoolExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_boolExpression);
					setState(293);
					if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
					setState(294);
					match(LogicOperator);
					setState(295);
					boolExpression(3);
					}
					} 
				}
				setState(300);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,19,_ctx);
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

	public static class CommandContext extends ParserRuleContext {
		public IterationCommandContext iterationCommand() {
			return getRuleContext(IterationCommandContext.class,0);
		}
		public MovementCommandContext movementCommand() {
			return getRuleContext(MovementCommandContext.class,0);
		}
		public DrawCommandContext drawCommand() {
			return getRuleContext(DrawCommandContext.class,0);
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
		enterRule(_localctx, 54, RULE_command);
		try {
			setState(304);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case RepeatStart:
				enterOuterAlt(_localctx, 1);
				{
				setState(301);
				iterationCommand();
				}
				break;
			case Curve:
			case Line:
				enterOuterAlt(_localctx, 2);
				{
				setState(302);
				movementCommand();
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 3);
				{
				setState(303);
				drawCommand();
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
		enterRule(_localctx, 56, RULE_movementCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(308);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Line:
				{
				setState(306);
				lineCommand();
				}
				break;
			case Curve:
				{
				setState(307);
				curveCommand();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(310);
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
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
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
		enterRule(_localctx, 58, RULE_lineCommand);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(312);
			match(Line);
			setState(313);
			match(DOT);
			setState(314);
			match(From);
			setState(315);
			match(LParen);
			setState(319);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
			case 1:
				{
				setState(316);
				numberTuple();
				}
				break;
			case 2:
				{
				setState(317);
				match(ID);
				}
				break;
			case 3:
				{
				setState(318);
				pointReference();
				}
				break;
			}
			setState(321);
			match(RParen);
			setState(323); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(322);
				toCommand();
				}
				}
				setState(325); 
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

	public static class CurveCommandContext extends ParserRuleContext {
		public TerminalNode Curve() { return getToken(OGParser.Curve, 0); }
		public List<TerminalNode> DOT() { return getTokens(OGParser.DOT); }
		public TerminalNode DOT(int i) {
			return getToken(OGParser.DOT, i);
		}
		public TerminalNode WithAngle() { return getToken(OGParser.WithAngle, 0); }
		public List<TerminalNode> LParen() { return getTokens(OGParser.LParen); }
		public TerminalNode LParen(int i) {
			return getToken(OGParser.LParen, i);
		}
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public List<TerminalNode> RParen() { return getTokens(OGParser.RParen); }
		public TerminalNode RParen(int i) {
			return getToken(OGParser.RParen, i);
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
		enterRule(_localctx, 60, RULE_curveCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(327);
			match(Curve);
			setState(328);
			match(DOT);
			setState(329);
			match(WithAngle);
			setState(330);
			match(LParen);
			setState(331);
			mathExpression();
			setState(332);
			match(RParen);
			setState(333);
			match(DOT);
			setState(334);
			match(From);
			setState(335);
			match(LParen);
			setState(338);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,24,_ctx) ) {
			case 1:
				{
				setState(336);
				numberTuple();
				}
				break;
			case 2:
				{
				setState(337);
				match(ID);
				}
				break;
			}
			setState(340);
			match(RParen);
			setState(341);
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
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
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
		enterRule(_localctx, 62, RULE_toCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(343);
			match(T__0);
			setState(344);
			match(LParen);
			setState(347);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,25,_ctx) ) {
			case 1:
				{
				setState(345);
				numberTuple();
				}
				break;
			case 2:
				{
				setState(346);
				match(ID);
				}
				break;
			}
			setState(349);
			match(RParen);
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

	public static class DrawCommandContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public DrawCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_drawCommand; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDrawCommand(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDrawCommand(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDrawCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawCommandContext drawCommand() throws RecognitionException {
		DrawCommandContext _localctx = new DrawCommandContext(_ctx, getState());
		enterRule(_localctx, 64, RULE_drawCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(351);
			match(ID);
			setState(352);
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
		enterRule(_localctx, 66, RULE_iterationCommand);
		try {
			setState(356);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,26,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(354);
				numberIteration();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(355);
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
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
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
		enterRule(_localctx, 68, RULE_numberIteration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(358);
			match(RepeatStart);
			setState(359);
			match(LParen);
			setState(360);
			mathExpression();
			setState(361);
			match(RParen);
			setState(362);
			body();
			setState(363);
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
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public TerminalNode RepeatEnd() { return getToken(OGParser.RepeatEnd, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
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
		enterRule(_localctx, 70, RULE_untilIteration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(365);
			match(RepeatStart);
			setState(366);
			match(DOT);
			setState(367);
			match(Until);
			setState(368);
			match(LParen);
			setState(371);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,27,_ctx) ) {
			case 1:
				{
				setState(369);
				boolExpression(0);
				}
				break;
			case 2:
				{
				setState(370);
				functionCall();
				}
				break;
			}
			setState(373);
			match(RParen);
			setState(374);
			body();
			setState(375);
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
		enterRule(_localctx, 72, RULE_functionDeclaration);
		try {
			setState(379);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,28,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(377);
				returnFunctionDCL();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(378);
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
		enterRule(_localctx, 74, RULE_returnFunctionDCL);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(381);
			match(FunctionStartWord);
			setState(382);
			typeWord();
			setState(383);
			match(ID);
			setState(384);
			parameterDeclarations();
			setState(385);
			match(OpenScope);
			setState(386);
			body();
			setState(387);
			returnStatement();
			setState(388);
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
		enterRule(_localctx, 76, RULE_typeWord);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(390);
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
		enterRule(_localctx, 78, RULE_voidFunctionDCL);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(392);
			match(FunctionStartWord);
			setState(393);
			match(Void);
			setState(394);
			match(ID);
			setState(395);
			parameterDeclarations();
			setState(396);
			match(OpenScope);
			setState(397);
			body();
			setState(398);
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
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public ParametersContext parameters() {
			return getRuleContext(ParametersContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
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
		enterRule(_localctx, 80, RULE_parameterDeclarations);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(400);
			match(LParen);
			setState(401);
			parameters();
			setState(402);
			match(RParen);
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
		enterRule(_localctx, 82, RULE_parameters);
		try {
			int _alt;
			setState(417);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case PointDCLWord:
			case BoolDCLWord:
			case NumberDCLWord:
				enterOuterAlt(_localctx, 1);
				{
				setState(410);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,29,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(404);
						typeWord();
						setState(405);
						match(ID);
						setState(406);
						match(Seperator);
						}
						} 
					}
					setState(412);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,29,_ctx);
				}
				setState(413);
				typeWord();
				setState(414);
				match(ID);
				}
				break;
			case RParen:
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
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public ParameterListContext parameterList() {
			return getRuleContext(ParameterListContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
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
		enterRule(_localctx, 84, RULE_functionCall);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(419);
			match(ID);
			setState(420);
			match(LParen);
			setState(421);
			parameterList();
			setState(422);
			match(RParen);
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
		public List<TerminalNode> CoordinateXYValue() { return getTokens(OGParser.CoordinateXYValue); }
		public TerminalNode CoordinateXYValue(int i) {
			return getToken(OGParser.CoordinateXYValue, i);
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
		enterRule(_localctx, 86, RULE_parameterList);
		try {
			int _alt;
			setState(441);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Number:
			case BooleanValue:
			case LParen:
			case NOT:
			case CoordinateXYValue:
			case ID:
				enterOuterAlt(_localctx, 1);
				{
				setState(432);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,32,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(427);
						_errHandler.sync(this);
						switch ( getInterpreter().adaptivePredict(_input,31,_ctx) ) {
						case 1:
							{
							setState(424);
							match(ID);
							}
							break;
						case 2:
							{
							setState(425);
							expression();
							}
							break;
						case 3:
							{
							setState(426);
							match(CoordinateXYValue);
							}
							break;
						}
						setState(429);
						match(Seperator);
						}
						} 
					}
					setState(434);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,32,_ctx);
				}
				setState(438);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,33,_ctx) ) {
				case 1:
					{
					setState(435);
					match(ID);
					}
					break;
				case 2:
					{
					setState(436);
					expression();
					}
					break;
				case 3:
					{
					setState(437);
					match(CoordinateXYValue);
					}
					break;
				}
				}
				break;
			case RParen:
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
		enterRule(_localctx, 88, RULE_returnStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(443);
			match(FunctionReturnWord);
			setState(446);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,35,_ctx) ) {
			case 1:
				{
				setState(444);
				match(ID);
				}
				break;
			case 2:
				{
				setState(445);
				expression();
				}
				break;
			}
			setState(448);
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

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 26:
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\66\u01c5\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\3\2\3\2\3\2\7\2`\n\2\f\2\16\2c\13\2\3\2\7\2f\n\2\f\2"+
		"\16\2i\13\2\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3"+
		"\3\3\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\5\3\5\3\5\7\5\u0088\n"+
		"\5\f\5\16\5\u008b\13\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7"+
		"\6\7\u0099\n\7\r\7\16\7\u009a\3\7\5\7\u009e\n\7\3\b\3\b\3\b\5\b\u00a3"+
		"\n\b\3\b\3\b\3\t\3\t\3\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\13\3\13\3\13\3"+
		"\13\3\13\5\13\u00b6\n\13\3\f\3\f\3\f\3\f\3\f\3\f\3\f\5\f\u00bf\n\f\3\r"+
		"\3\r\3\r\3\r\3\16\3\16\5\16\u00c7\n\16\3\17\3\17\3\17\3\17\3\17\3\20\3"+
		"\20\3\20\3\20\5\20\u00d2\n\20\3\20\3\20\3\21\3\21\3\21\3\21\3\22\3\22"+
		"\3\22\3\22\3\23\3\23\3\23\3\23\3\24\3\24\3\24\3\24\3\24\3\24\5\24\u00e8"+
		"\n\24\5\24\u00ea\n\24\3\25\3\25\3\25\3\25\3\26\3\26\3\26\3\26\3\27\3\27"+
		"\3\27\3\27\5\27\u00f8\n\27\3\30\3\30\3\30\7\30\u00fd\n\30\f\30\16\30\u0100"+
		"\13\30\3\31\3\31\3\31\7\31\u0105\n\31\f\31\16\31\u0108\13\31\3\32\3\32"+
		"\3\32\7\32\u010d\n\32\f\32\16\32\u0110\13\32\3\33\3\33\3\33\3\33\3\33"+
		"\3\33\3\33\3\33\5\33\u011a\n\33\3\34\3\34\3\34\3\34\3\34\3\34\3\34\3\34"+
		"\3\34\3\34\5\34\u0126\n\34\3\34\3\34\3\34\7\34\u012b\n\34\f\34\16\34\u012e"+
		"\13\34\3\35\3\35\3\35\5\35\u0133\n\35\3\36\3\36\5\36\u0137\n\36\3\36\3"+
		"\36\3\37\3\37\3\37\3\37\3\37\3\37\3\37\5\37\u0142\n\37\3\37\3\37\6\37"+
		"\u0146\n\37\r\37\16\37\u0147\3 \3 \3 \3 \3 \3 \3 \3 \3 \3 \3 \5 \u0155"+
		"\n \3 \3 \3 \3!\3!\3!\3!\5!\u015e\n!\3!\3!\3\"\3\"\3\"\3#\3#\5#\u0167"+
		"\n#\3$\3$\3$\3$\3$\3$\3$\3%\3%\3%\3%\3%\3%\5%\u0176\n%\3%\3%\3%\3%\3&"+
		"\3&\5&\u017e\n&\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3(\3(\3)\3)\3)\3)"+
		"\3)\3)\3)\3)\3*\3*\3*\3*\3+\3+\3+\3+\7+\u019b\n+\f+\16+\u019e\13+\3+\3"+
		"+\3+\3+\5+\u01a4\n+\3,\3,\3,\3,\3,\3-\3-\3-\5-\u01ae\n-\3-\7-\u01b1\n"+
		"-\f-\16-\u01b4\13-\3-\3-\3-\5-\u01b9\n-\3-\5-\u01bc\n-\3.\3.\3.\5.\u01c1"+
		"\n.\3.\3.\3.\2\3\66/\2\4\6\b\n\f\16\20\22\24\26\30\32\34\36 \"$&(*,.\60"+
		"\62\64\668:<>@BDFHJLNPRTVXZ\2\3\3\2\t\13\2\u01cf\2\\\3\2\2\2\4j\3\2\2"+
		"\2\6z\3\2\2\2\b\u0084\3\2\2\2\n\u008e\3\2\2\2\f\u009d\3\2\2\2\16\u00a2"+
		"\3\2\2\2\20\u00a6\3\2\2\2\22\u00ab\3\2\2\2\24\u00b0\3\2\2\2\26\u00be\3"+
		"\2\2\2\30\u00c0\3\2\2\2\32\u00c6\3\2\2\2\34\u00c8\3\2\2\2\36\u00d1\3\2"+
		"\2\2 \u00d5\3\2\2\2\"\u00d9\3\2\2\2$\u00dd\3\2\2\2&\u00e9\3\2\2\2(\u00eb"+
		"\3\2\2\2*\u00ef\3\2\2\2,\u00f7\3\2\2\2.\u00f9\3\2\2\2\60\u0101\3\2\2\2"+
		"\62\u0109\3\2\2\2\64\u0119\3\2\2\2\66\u0125\3\2\2\28\u0132\3\2\2\2:\u0136"+
		"\3\2\2\2<\u013a\3\2\2\2>\u0149\3\2\2\2@\u0159\3\2\2\2B\u0161\3\2\2\2D"+
		"\u0166\3\2\2\2F\u0168\3\2\2\2H\u016f\3\2\2\2J\u017d\3\2\2\2L\u017f\3\2"+
		"\2\2N\u0188\3\2\2\2P\u018a\3\2\2\2R\u0192\3\2\2\2T\u01a3\3\2\2\2V\u01a5"+
		"\3\2\2\2X\u01bb\3\2\2\2Z\u01bd\3\2\2\2\\]\5\6\4\2]a\5\b\5\2^`\5J&\2_^"+
		"\3\2\2\2`c\3\2\2\2a_\3\2\2\2ab\3\2\2\2bg\3\2\2\2ca\3\2\2\2df\5\n\6\2e"+
		"d\3\2\2\2fi\3\2\2\2ge\3\2\2\2gh\3\2\2\2h\3\3\2\2\2ig\3\2\2\2jk\7*\2\2"+
		"kl\7%\2\2lm\5.\30\2mn\7)\2\2no\7+\2\2op\7%\2\2pq\5.\30\2qr\7)\2\2rs\7"+
		",\2\2st\7%\2\2tu\5.\30\2uv\7)\2\2vw\7-\2\2wx\7%\2\2xy\5.\30\2y\5\3\2\2"+
		"\2z{\7.\2\2{|\7\25\2\2|}\7/\2\2}~\7\25\2\2~\177\7\60\2\2\177\u0080\7\31"+
		"\2\2\u0080\u0081\5\4\3\2\u0081\u0082\7\32\2\2\u0082\u0083\7(\2\2\u0083"+
		"\7\3\2\2\2\u0084\u0085\7\f\2\2\u0085\u0089\7&\2\2\u0086\u0088\5B\"\2\u0087"+
		"\u0086\3\2\2\2\u0088\u008b\3\2\2\2\u0089\u0087\3\2\2\2\u0089\u008a\3\2"+
		"\2\2\u008a\u008c\3\2\2\2\u008b\u0089\3\2\2\2\u008c\u008d\7\'\2\2\u008d"+
		"\t\3\2\2\2\u008e\u008f\7\b\2\2\u008f\u0090\7\66\2\2\u0090\u0091\7&\2\2"+
		"\u0091\u0092\5\f\7\2\u0092\u0093\7\'\2\2\u0093\13\3\2\2\2\u0094\u0099"+
		"\5,\27\2\u0095\u0099\5\16\b\2\u0096\u0099\5\32\16\2\u0097\u0099\58\35"+
		"\2\u0098\u0094\3\2\2\2\u0098\u0095\3\2\2\2\u0098\u0096\3\2\2\2\u0098\u0097"+
		"\3\2\2\2\u0099\u009a\3\2\2\2\u009a\u0098\3\2\2\2\u009a\u009b\3\2\2\2\u009b"+
		"\u009e\3\2\2\2\u009c\u009e\3\2\2\2\u009d\u0098\3\2\2\2\u009d\u009c\3\2"+
		"\2\2\u009e\r\3\2\2\2\u009f\u00a3\5\22\n\2\u00a0\u00a3\5\24\13\2\u00a1"+
		"\u00a3\5\20\t\2\u00a2\u009f\3\2\2\2\u00a2\u00a0\3\2\2\2\u00a2\u00a1\3"+
		"\2\2\2\u00a3\u00a4\3\2\2\2\u00a4\u00a5\7(\2\2\u00a5\17\3\2\2\2\u00a6\u00a7"+
		"\7\n\2\2\u00a7\u00a8\7\66\2\2\u00a8\u00a9\7%\2\2\u00a9\u00aa\5\66\34\2"+
		"\u00aa\21\3\2\2\2\u00ab\u00ac\7\13\2\2\u00ac\u00ad\7\66\2\2\u00ad\u00ae"+
		"\7%\2\2\u00ae\u00af\5.\30\2\u00af\23\3\2\2\2\u00b0\u00b1\7\t\2\2\u00b1"+
		"\u00b2\7\66\2\2\u00b2\u00b5\7%\2\2\u00b3\u00b6\5\26\f\2\u00b4\u00b6\7"+
		"\66\2\2\u00b5\u00b3\3\2\2\2\u00b5\u00b4\3\2\2\2\u00b6\25\3\2\2\2\u00b7"+
		"\u00b8\7\31\2\2\u00b8\u00b9\5\30\r\2\u00b9\u00ba\7\32\2\2\u00ba\u00bf"+
		"\3\2\2\2\u00bb\u00bf\7\61\2\2\u00bc\u00bf\7\62\2\2\u00bd\u00bf\5V,\2\u00be"+
		"\u00b7\3\2\2\2\u00be\u00bb\3\2\2\2\u00be\u00bc\3\2\2\2\u00be\u00bd\3\2"+
		"\2\2\u00bf\27\3\2\2\2\u00c0\u00c1\5.\30\2\u00c1\u00c2\7)\2\2\u00c2\u00c3"+
		"\5.\30\2\u00c3\31\3\2\2\2\u00c4\u00c7\5\36\20\2\u00c5\u00c7\5\34\17\2"+
		"\u00c6\u00c4\3\2\2\2\u00c6\u00c5\3\2\2\2\u00c7\33\3\2\2\2\u00c8\u00c9"+
		"\7\65\2\2\u00c9\u00ca\7%\2\2\u00ca\u00cb\5.\30\2\u00cb\u00cc\7(\2\2\u00cc"+
		"\35\3\2\2\2\u00cd\u00d2\5 \21\2\u00ce\u00d2\5\"\22\2\u00cf\u00d2\5$\23"+
		"\2\u00d0\u00d2\5&\24\2\u00d1\u00cd\3\2\2\2\u00d1\u00ce\3\2\2\2\u00d1\u00cf"+
		"\3\2\2\2\u00d1\u00d0\3\2\2\2\u00d2\u00d3\3\2\2\2\u00d3\u00d4\7(\2\2\u00d4"+
		"\37\3\2\2\2\u00d5\u00d6\7\66\2\2\u00d6\u00d7\7%\2\2\u00d7\u00d8\7\66\2"+
		"\2\u00d8!\3\2\2\2\u00d9\u00da\7\66\2\2\u00da\u00db\7%\2\2\u00db\u00dc"+
		"\5\66\34\2\u00dc#\3\2\2\2\u00dd\u00de\7\66\2\2\u00de\u00df\7%\2\2\u00df"+
		"\u00e0\5.\30\2\u00e0%\3\2\2\2\u00e1\u00ea\5*\26\2\u00e2\u00ea\5(\25\2"+
		"\u00e3\u00e4\7\66\2\2\u00e4\u00e5\7%\2\2\u00e5\u00e8\5\26\f\2\u00e6\u00e8"+
		"\7\66\2\2\u00e7\u00e3\3\2\2\2\u00e7\u00e6\3\2\2\2\u00e8\u00ea\3\2\2\2"+
		"\u00e9\u00e1\3\2\2\2\u00e9\u00e2\3\2\2\2\u00e9\u00e7\3\2\2\2\u00ea\'\3"+
		"\2\2\2\u00eb\u00ec\7\61\2\2\u00ec\u00ed\7%\2\2\u00ed\u00ee\5\26\f\2\u00ee"+
		")\3\2\2\2\u00ef\u00f0\7\62\2\2\u00f0\u00f1\7%\2\2\u00f1\u00f2\5\26\f\2"+
		"\u00f2+\3\2\2\2\u00f3\u00f8\7\66\2\2\u00f4\u00f8\5.\30\2\u00f5\u00f8\5"+
		"\66\34\2\u00f6\u00f8\5V,\2\u00f7\u00f3\3\2\2\2\u00f7\u00f4\3\2\2\2\u00f7"+
		"\u00f5\3\2\2\2\u00f7\u00f6\3\2\2\2\u00f8-\3\2\2\2\u00f9\u00fe\5\60\31"+
		"\2\u00fa\u00fb\7\33\2\2\u00fb\u00fd\5\60\31\2\u00fc\u00fa\3\2\2\2\u00fd"+
		"\u0100\3\2\2\2\u00fe\u00fc\3\2\2\2\u00fe\u00ff\3\2\2\2\u00ff/\3\2\2\2"+
		"\u0100\u00fe\3\2\2\2\u0101\u0106\5\62\32\2\u0102\u0103\7\36\2\2\u0103"+
		"\u0105\5\62\32\2\u0104\u0102\3\2\2\2\u0105\u0108\3\2\2\2\u0106\u0104\3"+
		"\2\2\2\u0106\u0107\3\2\2\2\u0107\61\3\2\2\2\u0108\u0106\3\2\2\2\u0109"+
		"\u010e\5\64\33\2\u010a\u010b\7!\2\2\u010b\u010d\5\64\33\2\u010c\u010a"+
		"\3\2\2\2\u010d\u0110\3\2\2\2\u010e\u010c\3\2\2\2\u010e\u010f\3\2\2\2\u010f"+
		"\63\3\2\2\2\u0110\u010e\3\2\2\2\u0111\u011a\5V,\2\u0112\u011a\7\4\2\2"+
		"\u0113\u011a\7\65\2\2\u0114\u011a\7\66\2\2\u0115\u0116\7\31\2\2\u0116"+
		"\u0117\5.\30\2\u0117\u0118\7\32\2\2\u0118\u011a\3\2\2\2\u0119\u0111\3"+
		"\2\2\2\u0119\u0112\3\2\2\2\u0119\u0113\3\2\2\2\u0119\u0114\3\2\2\2\u0119"+
		"\u0115\3\2\2\2\u011a\65\3\2\2\2\u011b\u011c\b\34\1\2\u011c\u0126\7\66"+
		"\2\2\u011d\u0126\7\5\2\2\u011e\u0126\5V,\2\u011f\u0120\5.\30\2\u0120\u0121"+
		"\7#\2\2\u0121\u0122\5.\30\2\u0122\u0126\3\2\2\2\u0123\u0124\7$\2\2\u0124"+
		"\u0126\5\66\34\3\u0125\u011b\3\2\2\2\u0125\u011d\3\2\2\2\u0125\u011e\3"+
		"\2\2\2\u0125\u011f\3\2\2\2\u0125\u0123\3\2\2\2\u0126\u012c\3\2\2\2\u0127"+
		"\u0128\f\4\2\2\u0128\u0129\7\"\2\2\u0129\u012b\5\66\34\5\u012a\u0127\3"+
		"\2\2\2\u012b\u012e\3\2\2\2\u012c\u012a\3\2\2\2\u012c\u012d\3\2\2\2\u012d"+
		"\67\3\2\2\2\u012e\u012c\3\2\2\2\u012f\u0133\5D#\2\u0130\u0133\5:\36\2"+
		"\u0131\u0133\5B\"\2\u0132\u012f\3\2\2\2\u0132\u0130\3\2\2\2\u0132\u0131"+
		"\3\2\2\2\u01339\3\2\2\2\u0134\u0137\5<\37\2\u0135\u0137\5> \2\u0136\u0134"+
		"\3\2\2\2\u0136\u0135\3\2\2\2\u0137\u0138\3\2\2\2\u0138\u0139\7(\2\2\u0139"+
		";\3\2\2\2\u013a\u013b\7\17\2\2\u013b\u013c\7\25\2\2\u013c\u013d\7\21\2"+
		"\2\u013d\u0141\7\31\2\2\u013e\u0142\5\30\r\2\u013f\u0142\7\66\2\2\u0140"+
		"\u0142\5\26\f\2\u0141\u013e\3\2\2\2\u0141\u013f\3\2\2\2\u0141\u0140\3"+
		"\2\2\2\u0142\u0143\3\2\2\2\u0143\u0145\7\32\2\2\u0144\u0146\5@!\2\u0145"+
		"\u0144\3\2\2\2\u0146\u0147\3\2\2\2\u0147\u0145\3\2\2\2\u0147\u0148\3\2"+
		"\2\2\u0148=\3\2\2\2\u0149\u014a\7\16\2\2\u014a\u014b\7\25\2\2\u014b\u014c"+
		"\7\r\2\2\u014c\u014d\7\31\2\2\u014d\u014e\5.\30\2\u014e\u014f\7\32\2\2"+
		"\u014f\u0150\7\25\2\2\u0150\u0151\7\21\2\2\u0151\u0154\7\31\2\2\u0152"+
		"\u0155\5\30\r\2\u0153\u0155\7\66\2\2\u0154\u0152\3\2\2\2\u0154\u0153\3"+
		"\2\2\2\u0155\u0156\3\2\2\2\u0156\u0157\7\32\2\2\u0157\u0158\5@!\2\u0158"+
		"?\3\2\2\2\u0159\u015a\7\3\2\2\u015a\u015d\7\31\2\2\u015b\u015e\5\30\r"+
		"\2\u015c\u015e\7\66\2\2\u015d\u015b\3\2\2\2\u015d\u015c\3\2\2\2\u015e"+
		"\u015f\3\2\2\2\u015f\u0160\7\32\2\2\u0160A\3\2\2\2\u0161\u0162\7\66\2"+
		"\2\u0162\u0163\7(\2\2\u0163C\3\2\2\2\u0164\u0167\5F$\2\u0165\u0167\5H"+
		"%\2\u0166\u0164\3\2\2\2\u0166\u0165\3\2\2\2\u0167E\3\2\2\2\u0168\u0169"+
		"\7\22\2\2\u0169\u016a\7\31\2\2\u016a\u016b\5.\30\2\u016b\u016c\7\32\2"+
		"\2\u016c\u016d\5\f\7\2\u016d\u016e\7\23\2\2\u016eG\3\2\2\2\u016f\u0170"+
		"\7\22\2\2\u0170\u0171\7\25\2\2\u0171\u0172\7\24\2\2\u0172\u0175\7\31\2"+
		"\2\u0173\u0176\5\66\34\2\u0174\u0176\5V,\2\u0175\u0173\3\2\2\2\u0175\u0174"+
		"\3\2\2\2\u0176\u0177\3\2\2\2\u0177\u0178\7\32\2\2\u0178\u0179\5\f\7\2"+
		"\u0179\u017a\7\23\2\2\u017aI\3\2\2\2\u017b\u017e\5L\'\2\u017c\u017e\5"+
		"P)\2\u017d\u017b\3\2\2\2\u017d\u017c\3\2\2\2\u017eK\3\2\2\2\u017f\u0180"+
		"\7\26\2\2\u0180\u0181\5N(\2\u0181\u0182\7\66\2\2\u0182\u0183\5R*\2\u0183"+
		"\u0184\7&\2\2\u0184\u0185\5\f\7\2\u0185\u0186\5Z.\2\u0186\u0187\7\'\2"+
		"\2\u0187M\3\2\2\2\u0188\u0189\t\2\2\2\u0189O\3\2\2\2\u018a\u018b\7\26"+
		"\2\2\u018b\u018c\7\30\2\2\u018c\u018d\7\66\2\2\u018d\u018e\5R*\2\u018e"+
		"\u018f\7&\2\2\u018f\u0190\5\f\7\2\u0190\u0191\7\'\2\2\u0191Q\3\2\2\2\u0192"+
		"\u0193\7\31\2\2\u0193\u0194\5T+\2\u0194\u0195\7\32\2\2\u0195S\3\2\2\2"+
		"\u0196\u0197\5N(\2\u0197\u0198\7\66\2\2\u0198\u0199\7)\2\2\u0199\u019b"+
		"\3\2\2\2\u019a\u0196\3\2\2\2\u019b\u019e\3\2\2\2\u019c\u019a\3\2\2\2\u019c"+
		"\u019d\3\2\2\2\u019d\u019f\3\2\2\2\u019e\u019c\3\2\2\2\u019f\u01a0\5N"+
		"(\2\u01a0\u01a1\7\66\2\2\u01a1\u01a4\3\2\2\2\u01a2\u01a4\3\2\2\2\u01a3"+
		"\u019c\3\2\2\2\u01a3\u01a2\3\2\2\2\u01a4U\3\2\2\2\u01a5\u01a6\7\66\2\2"+
		"\u01a6\u01a7\7\31\2\2\u01a7\u01a8\5X-\2\u01a8\u01a9\7\32\2\2\u01a9W\3"+
		"\2\2\2\u01aa\u01ae\7\66\2\2\u01ab\u01ae\5,\27\2\u01ac\u01ae\7\65\2\2\u01ad"+
		"\u01aa\3\2\2\2\u01ad\u01ab\3\2\2\2\u01ad\u01ac\3\2\2\2\u01ae\u01af\3\2"+
		"\2\2\u01af\u01b1\7)\2\2\u01b0\u01ad\3\2\2\2\u01b1\u01b4\3\2\2\2\u01b2"+
		"\u01b0\3\2\2\2\u01b2\u01b3\3\2\2\2\u01b3\u01b8\3\2\2\2\u01b4\u01b2\3\2"+
		"\2\2\u01b5\u01b9\7\66\2\2\u01b6\u01b9\5,\27\2\u01b7\u01b9\7\65\2\2\u01b8"+
		"\u01b5\3\2\2\2\u01b8\u01b6\3\2\2\2\u01b8\u01b7\3\2\2\2\u01b9\u01bc\3\2"+
		"\2\2\u01ba\u01bc\3\2\2\2\u01bb\u01b2\3\2\2\2\u01bb\u01ba\3\2\2\2\u01bc"+
		"Y\3\2\2\2\u01bd\u01c0\7\27\2\2\u01be\u01c1\7\66\2\2\u01bf\u01c1\5,\27"+
		"\2\u01c0\u01be\3\2\2\2\u01c0\u01bf\3\2\2\2\u01c1\u01c2\3\2\2\2\u01c2\u01c3"+
		"\7(\2\2\u01c3[\3\2\2\2&ag\u0089\u0098\u009a\u009d\u00a2\u00b5\u00be\u00c6"+
		"\u00d1\u00e7\u00e9\u00f7\u00fe\u0106\u010e\u0119\u0125\u012c\u0132\u0136"+
		"\u0141\u0147\u0154\u015d\u0166\u0175\u017d\u019c\u01a3\u01ad\u01b2\u01b8"+
		"\u01bb\u01c0";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}