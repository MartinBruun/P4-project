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
		T__0=1, T__1=2, T__2=3, T__3=4, Number=5, BooleanValue=6, WS=7, COMMENT=8, 
		ShapeDCLWord=9, PointDCLWord=10, BoolDCLWord=11, NumberDCLWord=12, DrawDCLWord=13, 
		WithAngle=14, Curve=15, Line=16, To=17, From=18, RepeatStart=19, RepeatEnd=20, 
		Until=21, DOT=22, FunctionStartWord=23, FunctionReturnWord=24, Void=25, 
		LParen=26, RParen=27, Plus_Minus=28, Plus=29, Minus=30, Mul_Div=31, Times=32, 
		Div=33, Pow=34, LogicOperator=35, BoolOperator=36, NOT=37, Assign=38, 
		OpenScope=39, CloseScope=40, Terminator=41, Seperator=42, XMIN=43, XMAX=44, 
		YMAX=45, YMIN=46, Machine=47, WorkArea=48, Size=49, If=50, Then=51, ID=52;
	public static final int
		RULE_program = 0, RULE_machineSettings = 1, RULE_machineMods = 2, RULE_workAreaMod = 3, 
		RULE_workAreaModPrpts = 4, RULE_sizePrpt = 5, RULE_workAreaVars = 6, RULE_shapeDcls = 7, 
		RULE_functionDcls = 8, RULE_draw = 9, RULE_drawCommands = 10, RULE_drawCommand = 11, 
		RULE_shapeDcl = 12, RULE_body = 13, RULE_stmts = 14, RULE_stmt = 15, RULE_assignments = 16, 
		RULE_declarations = 17, RULE_commands = 18, RULE_declaration = 19, RULE_booleanDeclaration = 20, 
		RULE_numberDeclaration = 21, RULE_pointDeclaration = 22, RULE_pointReference = 23, 
		RULE_numberTuple = 24, RULE_assignment = 25, RULE_propertyAssignment = 26, 
		RULE_variableAssignment = 27, RULE_pointAssignment = 28, RULE_startPointAssignment = 29, 
		RULE_endPointAssignment = 30, RULE_expression = 31, RULE_mathExpression = 32, 
		RULE_term = 33, RULE_factor = 34, RULE_atom = 35, RULE_boolExpression = 36, 
		RULE_command = 37, RULE_movementCommand = 38, RULE_lineCommand = 39, RULE_toCommands = 40, 
		RULE_curveCommand = 41, RULE_toCommand = 42, RULE_fromCommand = 43, RULE_iterationCommand = 44, 
		RULE_numberIteration = 45, RULE_untilIteration = 46, RULE_functionDcl = 47, 
		RULE_returnFunctionDCL = 48, RULE_typeWord = 49, RULE_voidFunctionDCL = 50, 
		RULE_parameterDeclarations = 51, RULE_parameterDcl = 52, RULE_functionCall = 53, 
		RULE_passedParams = 54, RULE_passedParam = 55, RULE_returnStatement = 56, 
		RULE_startPointReference = 57, RULE_endPointReference = 58, RULE_coordinateXYValue = 59;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "machineSettings", "machineMods", "workAreaMod", "workAreaModPrpts", 
			"sizePrpt", "workAreaVars", "shapeDcls", "functionDcls", "draw", "drawCommands", 
			"drawCommand", "shapeDcl", "body", "stmts", "stmt", "assignments", "declarations", 
			"commands", "declaration", "booleanDeclaration", "numberDeclaration", 
			"pointDeclaration", "pointReference", "numberTuple", "assignment", "propertyAssignment", 
			"variableAssignment", "pointAssignment", "startPointAssignment", "endPointAssignment", 
			"expression", "mathExpression", "term", "factor", "atom", "boolExpression", 
			"command", "movementCommand", "lineCommand", "toCommands", "curveCommand", 
			"toCommand", "fromCommand", "iterationCommand", "numberIteration", "untilIteration", 
			"functionDcl", "returnFunctionDCL", "typeWord", "voidFunctionDCL", "parameterDeclarations", 
			"parameterDcl", "functionCall", "passedParams", "passedParam", "returnStatement", 
			"startPointReference", "endPointReference", "coordinateXYValue"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'startPoint'", "'endPoint'", "'.x'", "'.y'", null, null, null, 
			null, "'shape'", "'point'", "'bool'", "'number'", "'draw'", "'withAngle'", 
			"'curve'", "'line'", "'to'", "'from'", "'repeat'", "'repeat.end'", "'until'", 
			"'.'", "'function'", "'return'", "'void'", "'('", "')'", null, "'+'", 
			"'-'", null, "'*'", "'/'", "'^'", null, null, "'!'", "'='", "'{'", "'}'", 
			"';'", "','", "'xmin'", "'xmax'", "'ymin'", "'ymax'", "'Machine'", "'WorkArea'", 
			"'size'", "'if'", "'then'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, "Number", "BooleanValue", "WS", "COMMENT", 
			"ShapeDCLWord", "PointDCLWord", "BoolDCLWord", "NumberDCLWord", "DrawDCLWord", 
			"WithAngle", "Curve", "Line", "To", "From", "RepeatStart", "RepeatEnd", 
			"Until", "DOT", "FunctionStartWord", "FunctionReturnWord", "Void", "LParen", 
			"RParen", "Plus_Minus", "Plus", "Minus", "Mul_Div", "Times", "Div", "Pow", 
			"LogicOperator", "BoolOperator", "NOT", "Assign", "OpenScope", "CloseScope", 
			"Terminator", "Seperator", "XMIN", "XMAX", "YMAX", "YMIN", "Machine", 
			"WorkArea", "Size", "If", "Then", "ID"
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
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
	 
		public ProgramContext() { }
		public void copyFrom(ProgramContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class ProgContext extends ProgramContext {
		public MachineSettingsContext settings;
		public DrawContext drawFunction;
		public FunctionDclsContext functionsDeclarations;
		public ShapeDclsContext shapeDeclarations;
		public MachineSettingsContext machineSettings() {
			return getRuleContext(MachineSettingsContext.class,0);
		}
		public DrawContext draw() {
			return getRuleContext(DrawContext.class,0);
		}
		public FunctionDclsContext functionDcls() {
			return getRuleContext(FunctionDclsContext.class,0);
		}
		public ShapeDclsContext shapeDcls() {
			return getRuleContext(ShapeDclsContext.class,0);
		}
		public ProgContext(ProgramContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterProg(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitProg(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitProg(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		try {
			_localctx = new ProgContext(_localctx);
			enterOuterAlt(_localctx, 1);
			{
			setState(120);
			((ProgContext)_localctx).settings = machineSettings();
			setState(121);
			((ProgContext)_localctx).drawFunction = draw();
			setState(122);
			((ProgContext)_localctx).functionsDeclarations = functionDcls();
			setState(123);
			((ProgContext)_localctx).shapeDeclarations = shapeDcls();
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

	public static class MachineSettingsContext extends ParserRuleContext {
		public MachineModsContext machineModifications;
		public TerminalNode Machine() { return getToken(OGParser.Machine, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public MachineModsContext machineMods() {
			return getRuleContext(MachineModsContext.class,0);
		}
		public MachineSettingsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_machineSettings; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMachineSettings(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMachineSettings(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMachineSettings(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MachineSettingsContext machineSettings() throws RecognitionException {
		MachineSettingsContext _localctx = new MachineSettingsContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_machineSettings);
		try {
			setState(130);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Machine:
				enterOuterAlt(_localctx, 1);
				{
				setState(125);
				match(Machine);
				setState(126);
				((MachineSettingsContext)_localctx).machineModifications = machineMods();
				setState(127);
				match(Terminator);
				}
				break;
			case DrawDCLWord:
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

	public static class MachineModsContext extends ParserRuleContext {
		public WorkAreaModContext workAreaModifications;
		public MachineModsContext machineModifications;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public WorkAreaModContext workAreaMod() {
			return getRuleContext(WorkAreaModContext.class,0);
		}
		public MachineModsContext machineMods() {
			return getRuleContext(MachineModsContext.class,0);
		}
		public MachineModsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_machineMods; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMachineMods(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMachineMods(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMachineMods(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MachineModsContext machineMods() throws RecognitionException {
		MachineModsContext _localctx = new MachineModsContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_machineMods);
		try {
			setState(137);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case DOT:
				enterOuterAlt(_localctx, 1);
				{
				setState(132);
				match(DOT);
				setState(133);
				((MachineModsContext)_localctx).workAreaModifications = workAreaMod();
				setState(134);
				((MachineModsContext)_localctx).machineModifications = machineMods();
				}
				break;
			case Terminator:
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

	public static class WorkAreaModContext extends ParserRuleContext {
		public WorkAreaModPrptsContext workAreaModificationProperties;
		public TerminalNode WorkArea() { return getToken(OGParser.WorkArea, 0); }
		public WorkAreaModPrptsContext workAreaModPrpts() {
			return getRuleContext(WorkAreaModPrptsContext.class,0);
		}
		public WorkAreaModContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_workAreaMod; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterWorkAreaMod(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitWorkAreaMod(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitWorkAreaMod(this);
			else return visitor.visitChildren(this);
		}
	}

	public final WorkAreaModContext workAreaMod() throws RecognitionException {
		WorkAreaModContext _localctx = new WorkAreaModContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_workAreaMod);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(139);
			match(WorkArea);
			setState(140);
			((WorkAreaModContext)_localctx).workAreaModificationProperties = workAreaModPrpts();
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

	public static class WorkAreaModPrptsContext extends ParserRuleContext {
		public WorkAreaModPrptsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_workAreaModPrpts; }
	 
		public WorkAreaModPrptsContext() { }
		public void copyFrom(WorkAreaModPrptsContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class WorkAreaModifierPropertiesContext extends WorkAreaModPrptsContext {
		public SizePrptContext sizeProperty;
		public WorkAreaModPrptsContext workAreaModificationProperties;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public SizePrptContext sizePrpt() {
			return getRuleContext(SizePrptContext.class,0);
		}
		public WorkAreaModPrptsContext workAreaModPrpts() {
			return getRuleContext(WorkAreaModPrptsContext.class,0);
		}
		public WorkAreaModifierPropertiesContext(WorkAreaModPrptsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterWorkAreaModifierProperties(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitWorkAreaModifierProperties(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitWorkAreaModifierProperties(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class EndOfWorkAreaModifierPropertiesContext extends WorkAreaModPrptsContext {
		public EndOfWorkAreaModifierPropertiesContext(WorkAreaModPrptsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterEndOfWorkAreaModifierProperties(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitEndOfWorkAreaModifierProperties(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitEndOfWorkAreaModifierProperties(this);
			else return visitor.visitChildren(this);
		}
	}

	public final WorkAreaModPrptsContext workAreaModPrpts() throws RecognitionException {
		WorkAreaModPrptsContext _localctx = new WorkAreaModPrptsContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_workAreaModPrpts);
		try {
			setState(147);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
			case 1:
				_localctx = new WorkAreaModifierPropertiesContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(142);
				match(DOT);
				setState(143);
				((WorkAreaModifierPropertiesContext)_localctx).sizeProperty = sizePrpt();
				setState(144);
				((WorkAreaModifierPropertiesContext)_localctx).workAreaModificationProperties = workAreaModPrpts();
				}
				break;
			case 2:
				_localctx = new EndOfWorkAreaModifierPropertiesContext(_localctx);
				enterOuterAlt(_localctx, 2);
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

	public static class SizePrptContext extends ParserRuleContext {
		public SizePrptContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_sizePrpt; }
	 
		public SizePrptContext() { }
		public void copyFrom(SizePrptContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class SizePropertyContext extends SizePrptContext {
		public WorkAreaVarsContext workAreaVariables;
		public TerminalNode Size() { return getToken(OGParser.Size, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public WorkAreaVarsContext workAreaVars() {
			return getRuleContext(WorkAreaVarsContext.class,0);
		}
		public SizePropertyContext(SizePrptContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSizeProperty(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSizeProperty(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSizeProperty(this);
			else return visitor.visitChildren(this);
		}
	}

	public final SizePrptContext sizePrpt() throws RecognitionException {
		SizePrptContext _localctx = new SizePrptContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_sizePrpt);
		try {
			_localctx = new SizePropertyContext(_localctx);
			enterOuterAlt(_localctx, 1);
			{
			setState(149);
			match(Size);
			setState(150);
			match(LParen);
			setState(151);
			((SizePropertyContext)_localctx).workAreaVariables = workAreaVars();
			setState(152);
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

	public static class WorkAreaVarsContext extends ParserRuleContext {
		public MathExpressionContext xmin;
		public MathExpressionContext xmax;
		public MathExpressionContext ymin;
		public MathExpressionContext ymax;
		public TerminalNode XMIN() { return getToken(OGParser.XMIN, 0); }
		public List<TerminalNode> Assign() { return getTokens(OGParser.Assign); }
		public TerminalNode Assign(int i) {
			return getToken(OGParser.Assign, i);
		}
		public List<TerminalNode> Seperator() { return getTokens(OGParser.Seperator); }
		public TerminalNode Seperator(int i) {
			return getToken(OGParser.Seperator, i);
		}
		public TerminalNode XMAX() { return getToken(OGParser.XMAX, 0); }
		public TerminalNode YMAX() { return getToken(OGParser.YMAX, 0); }
		public TerminalNode YMIN() { return getToken(OGParser.YMIN, 0); }
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public WorkAreaVarsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_workAreaVars; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterWorkAreaVars(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitWorkAreaVars(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitWorkAreaVars(this);
			else return visitor.visitChildren(this);
		}
	}

	public final WorkAreaVarsContext workAreaVars() throws RecognitionException {
		WorkAreaVarsContext _localctx = new WorkAreaVarsContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_workAreaVars);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(154);
			match(XMIN);
			setState(155);
			match(Assign);
			setState(156);
			((WorkAreaVarsContext)_localctx).xmin = mathExpression();
			setState(157);
			match(Seperator);
			setState(158);
			match(XMAX);
			setState(159);
			match(Assign);
			setState(160);
			((WorkAreaVarsContext)_localctx).xmax = mathExpression();
			setState(161);
			match(Seperator);
			setState(162);
			match(YMAX);
			setState(163);
			match(Assign);
			setState(164);
			((WorkAreaVarsContext)_localctx).ymin = mathExpression();
			setState(165);
			match(Seperator);
			setState(166);
			match(YMIN);
			setState(167);
			match(Assign);
			setState(168);
			((WorkAreaVarsContext)_localctx).ymax = mathExpression();
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

	public static class ShapeDclsContext extends ParserRuleContext {
		public ShapeDclContext currentShapeDcl;
		public ShapeDclsContext shapeDeclarations;
		public ShapeDclContext shapeDcl() {
			return getRuleContext(ShapeDclContext.class,0);
		}
		public ShapeDclsContext shapeDcls() {
			return getRuleContext(ShapeDclsContext.class,0);
		}
		public ShapeDclsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapeDcls; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterShapeDcls(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitShapeDcls(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitShapeDcls(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ShapeDclsContext shapeDcls() throws RecognitionException {
		ShapeDclsContext _localctx = new ShapeDclsContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_shapeDcls);
		try {
			setState(174);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case ShapeDCLWord:
				enterOuterAlt(_localctx, 1);
				{
				setState(170);
				((ShapeDclsContext)_localctx).currentShapeDcl = shapeDcl();
				setState(171);
				((ShapeDclsContext)_localctx).shapeDeclarations = shapeDcls();
				}
				break;
			case EOF:
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

	public static class FunctionDclsContext extends ParserRuleContext {
		public FunctionDclContext functionDcl() {
			return getRuleContext(FunctionDclContext.class,0);
		}
		public FunctionDclsContext functionDcls() {
			return getRuleContext(FunctionDclsContext.class,0);
		}
		public FunctionDclsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDcls; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFunctionDcls(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFunctionDcls(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFunctionDcls(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FunctionDclsContext functionDcls() throws RecognitionException {
		FunctionDclsContext _localctx = new FunctionDclsContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_functionDcls);
		try {
			setState(180);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case FunctionStartWord:
				enterOuterAlt(_localctx, 1);
				{
				setState(176);
				functionDcl();
				setState(177);
				functionDcls();
				}
				break;
			case EOF:
			case ShapeDCLWord:
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

	public static class DrawContext extends ParserRuleContext {
		public DrawCommandsContext shapesToDraw;
		public TerminalNode DrawDCLWord() { return getToken(OGParser.DrawDCLWord, 0); }
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public DrawCommandsContext drawCommands() {
			return getRuleContext(DrawCommandsContext.class,0);
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
		enterRule(_localctx, 18, RULE_draw);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(182);
			match(DrawDCLWord);
			setState(183);
			match(OpenScope);
			setState(184);
			((DrawContext)_localctx).shapesToDraw = drawCommands();
			setState(185);
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

	public static class DrawCommandsContext extends ParserRuleContext {
		public DrawCommandContext drawCommand() {
			return getRuleContext(DrawCommandContext.class,0);
		}
		public DrawCommandsContext drawCommands() {
			return getRuleContext(DrawCommandsContext.class,0);
		}
		public DrawCommandsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_drawCommands; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDrawCommands(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDrawCommands(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDrawCommands(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawCommandsContext drawCommands() throws RecognitionException {
		DrawCommandsContext _localctx = new DrawCommandsContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_drawCommands);
		try {
			setState(191);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case ID:
				enterOuterAlt(_localctx, 1);
				{
				setState(187);
				drawCommand();
				setState(188);
				drawCommands();
				}
				break;
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

	public static class DrawCommandContext extends ParserRuleContext {
		public DrawCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_drawCommand; }
	 
		public DrawCommandContext() { }
		public void copyFrom(DrawCommandContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class DrawCmdContext extends DrawCommandContext {
		public Token id;
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public DrawCmdContext(DrawCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDrawCmd(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDrawCmd(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDrawCmd(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class DrawFromCmdContext extends DrawCommandContext {
		public Token id;
		public FromCommandContext fromCmd;
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public FromCommandContext fromCommand() {
			return getRuleContext(FromCommandContext.class,0);
		}
		public DrawFromCmdContext(DrawCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDrawFromCmd(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDrawFromCmd(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDrawFromCmd(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DrawCommandContext drawCommand() throws RecognitionException {
		DrawCommandContext _localctx = new DrawCommandContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_drawCommand);
		try {
			setState(199);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				_localctx = new DrawCmdContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(193);
				((DrawCmdContext)_localctx).id = match(ID);
				setState(194);
				match(Terminator);
				}
				break;
			case 2:
				_localctx = new DrawFromCmdContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(195);
				((DrawFromCmdContext)_localctx).id = match(ID);
				setState(196);
				((DrawFromCmdContext)_localctx).fromCmd = fromCommand();
				setState(197);
				match(Terminator);
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

	public static class ShapeDclContext extends ParserRuleContext {
		public Token id;
		public BodyContext bdy;
		public TerminalNode ShapeDCLWord() { return getToken(OGParser.ShapeDCLWord, 0); }
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public ShapeDclContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_shapeDcl; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterShapeDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitShapeDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitShapeDcl(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ShapeDclContext shapeDcl() throws RecognitionException {
		ShapeDclContext _localctx = new ShapeDclContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_shapeDcl);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(201);
			match(ShapeDCLWord);
			setState(202);
			((ShapeDclContext)_localctx).id = match(ID);
			setState(203);
			match(OpenScope);
			setState(204);
			((ShapeDclContext)_localctx).bdy = body();
			setState(205);
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
		public StmtsContext statements;
		public StmtsContext stmts() {
			return getRuleContext(StmtsContext.class,0);
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
		enterRule(_localctx, 26, RULE_body);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(207);
			((BodyContext)_localctx).statements = stmts();
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

	public static class StmtsContext extends ParserRuleContext {
		public StmtContext currentStatement;
		public StmtsContext statements;
		public StmtContext stmt() {
			return getRuleContext(StmtContext.class,0);
		}
		public StmtsContext stmts() {
			return getRuleContext(StmtsContext.class,0);
		}
		public StmtsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_stmts; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterStmts(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitStmts(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitStmts(this);
			else return visitor.visitChildren(this);
		}
	}

	public final StmtsContext stmts() throws RecognitionException {
		StmtsContext _localctx = new StmtsContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_stmts);
		try {
			setState(213);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case PointDCLWord:
			case BoolDCLWord:
			case NumberDCLWord:
			case Curve:
			case Line:
			case RepeatStart:
			case ID:
				enterOuterAlt(_localctx, 1);
				{
				setState(209);
				((StmtsContext)_localctx).currentStatement = stmt();
				setState(210);
				((StmtsContext)_localctx).statements = stmts();
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

	public static class StmtContext extends ParserRuleContext {
		public DeclarationContext dcl;
		public AssignmentContext assign;
		public CommandContext cmd;
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public CommandContext command() {
			return getRuleContext(CommandContext.class,0);
		}
		public StmtContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_stmt; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterStmt(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitStmt(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitStmt(this);
			else return visitor.visitChildren(this);
		}
	}

	public final StmtContext stmt() throws RecognitionException {
		StmtContext _localctx = new StmtContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_stmt);
		try {
			setState(218);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(215);
				((StmtContext)_localctx).dcl = declaration();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(216);
				((StmtContext)_localctx).assign = assignment();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(217);
				((StmtContext)_localctx).cmd = command();
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

	public static class AssignmentsContext extends ParserRuleContext {
		public AssignmentsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignments; }
	 
		public AssignmentsContext() { }
		public void copyFrom(AssignmentsContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class AssgnmentsContext extends AssignmentsContext {
		public AssignmentContext assign;
		public AssignmentsContext assignmnts;
		public AssignmentContext assignment() {
			return getRuleContext(AssignmentContext.class,0);
		}
		public AssignmentsContext assignments() {
			return getRuleContext(AssignmentsContext.class,0);
		}
		public AssgnmentsContext(AssignmentsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterAssgnments(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitAssgnments(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitAssgnments(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class NoAssignmentsDefinedContext extends AssignmentsContext {
		public NoAssignmentsDefinedContext(AssignmentsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNoAssignmentsDefined(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNoAssignmentsDefined(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNoAssignmentsDefined(this);
			else return visitor.visitChildren(this);
		}
	}

	public final AssignmentsContext assignments() throws RecognitionException {
		AssignmentsContext _localctx = new AssignmentsContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_assignments);
		try {
			setState(224);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				_localctx = new AssgnmentsContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(220);
				((AssgnmentsContext)_localctx).assign = assignment();
				setState(221);
				((AssgnmentsContext)_localctx).assignmnts = assignments();
				}
				break;
			case 2:
				_localctx = new NoAssignmentsDefinedContext(_localctx);
				enterOuterAlt(_localctx, 2);
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

	public static class DeclarationsContext extends ParserRuleContext {
		public DeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declarations; }
	 
		public DeclarationsContext() { }
		public void copyFrom(DeclarationsContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class NoDeclarationsDefinedContext extends DeclarationsContext {
		public NoDeclarationsDefinedContext(DeclarationsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNoDeclarationsDefined(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNoDeclarationsDefined(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNoDeclarationsDefined(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class DclsContext extends DeclarationsContext {
		public DeclarationContext dcl;
		public DeclarationsContext dcls;
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public DeclarationsContext declarations() {
			return getRuleContext(DeclarationsContext.class,0);
		}
		public DclsContext(DeclarationsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterDcls(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitDcls(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitDcls(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DeclarationsContext declarations() throws RecognitionException {
		DeclarationsContext _localctx = new DeclarationsContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_declarations);
		try {
			setState(230);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				_localctx = new DclsContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(226);
				((DclsContext)_localctx).dcl = declaration();
				setState(227);
				((DclsContext)_localctx).dcls = declarations();
				}
				break;
			case 2:
				_localctx = new NoDeclarationsDefinedContext(_localctx);
				enterOuterAlt(_localctx, 2);
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

	public static class CommandsContext extends ParserRuleContext {
		public CommandsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_commands; }
	 
		public CommandsContext() { }
		public void copyFrom(CommandsContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class CmdsContext extends CommandsContext {
		public CommandContext cmd;
		public CommandsContext cmds;
		public CommandContext command() {
			return getRuleContext(CommandContext.class,0);
		}
		public CommandsContext commands() {
			return getRuleContext(CommandsContext.class,0);
		}
		public CmdsContext(CommandsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterCmds(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitCmds(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitCmds(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class NoCmdsDeclaredContext extends CommandsContext {
		public NoCmdsDeclaredContext(CommandsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNoCmdsDeclared(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNoCmdsDeclared(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNoCmdsDeclared(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CommandsContext commands() throws RecognitionException {
		CommandsContext _localctx = new CommandsContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_commands);
		try {
			setState(236);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				_localctx = new CmdsContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(232);
				((CmdsContext)_localctx).cmd = command();
				setState(233);
				((CmdsContext)_localctx).cmds = commands();
				}
				break;
			case 2:
				_localctx = new NoCmdsDeclaredContext(_localctx);
				enterOuterAlt(_localctx, 2);
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

	public static class DeclarationContext extends ParserRuleContext {
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	 
		public DeclarationContext() { }
		public void copyFrom(DeclarationContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class NumberDclContext extends DeclarationContext {
		public NumberDeclarationContext numberDcl;
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public NumberDeclarationContext numberDeclaration() {
			return getRuleContext(NumberDeclarationContext.class,0);
		}
		public NumberDclContext(DeclarationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberDcl(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PointDclContext extends DeclarationContext {
		public PointDeclarationContext pointDcl;
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public PointDeclarationContext pointDeclaration() {
			return getRuleContext(PointDeclarationContext.class,0);
		}
		public PointDclContext(DeclarationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointDcl(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class BoolDclContext extends DeclarationContext {
		public BooleanDeclarationContext boolDcl;
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public BooleanDeclarationContext booleanDeclaration() {
			return getRuleContext(BooleanDeclarationContext.class,0);
		}
		public BoolDclContext(DeclarationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolDcl(this);
			else return visitor.visitChildren(this);
		}
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_declaration);
		try {
			setState(247);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NumberDCLWord:
				_localctx = new NumberDclContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(238);
				((NumberDclContext)_localctx).numberDcl = numberDeclaration();
				setState(239);
				match(Terminator);
				}
				break;
			case PointDCLWord:
				_localctx = new PointDclContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(241);
				((PointDclContext)_localctx).pointDcl = pointDeclaration();
				setState(242);
				match(Terminator);
				}
				break;
			case BoolDCLWord:
				_localctx = new BoolDclContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(244);
				((BoolDclContext)_localctx).boolDcl = booleanDeclaration();
				setState(245);
				match(Terminator);
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

	public static class BooleanDeclarationContext extends ParserRuleContext {
		public Token id;
		public BoolExpressionContext value;
		public TerminalNode BoolDCLWord() { return getToken(OGParser.BoolDCLWord, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
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
		enterRule(_localctx, 40, RULE_booleanDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(249);
			match(BoolDCLWord);
			setState(250);
			((BooleanDeclarationContext)_localctx).id = match(ID);
			setState(251);
			match(Assign);
			setState(252);
			((BooleanDeclarationContext)_localctx).value = boolExpression(0);
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
		public Token id;
		public MathExpressionContext value;
		public TerminalNode NumberDCLWord() { return getToken(OGParser.NumberDCLWord, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
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
		enterRule(_localctx, 42, RULE_numberDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(254);
			match(NumberDCLWord);
			setState(255);
			((NumberDeclarationContext)_localctx).id = match(ID);
			setState(256);
			match(Assign);
			setState(257);
			((NumberDeclarationContext)_localctx).value = mathExpression();
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
		public PointDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pointDeclaration; }
	 
		public PointDeclarationContext() { }
		public void copyFrom(PointDeclarationContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class PointDclIdAssignContext extends PointDeclarationContext {
		public Token id;
		public Token value;
		public TerminalNode PointDCLWord() { return getToken(OGParser.PointDCLWord, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public PointDclIdAssignContext(PointDeclarationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointDclIdAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointDclIdAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointDclIdAssign(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PointDclPointRefAssignContext extends PointDeclarationContext {
		public Token id;
		public PointReferenceContext value;
		public TerminalNode PointDCLWord() { return getToken(OGParser.PointDCLWord, 0); }
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public PointReferenceContext pointReference() {
			return getRuleContext(PointReferenceContext.class,0);
		}
		public PointDclPointRefAssignContext(PointDeclarationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointDclPointRefAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointDclPointRefAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointDclPointRefAssign(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PointDeclarationContext pointDeclaration() throws RecognitionException {
		PointDeclarationContext _localctx = new PointDeclarationContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_pointDeclaration);
		try {
			setState(267);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				_localctx = new PointDclPointRefAssignContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(259);
				match(PointDCLWord);
				setState(260);
				((PointDclPointRefAssignContext)_localctx).id = match(ID);
				setState(261);
				match(Assign);
				setState(262);
				((PointDclPointRefAssignContext)_localctx).value = pointReference();
				}
				break;
			case 2:
				_localctx = new PointDclIdAssignContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(263);
				match(PointDCLWord);
				setState(264);
				((PointDclIdAssignContext)_localctx).id = match(ID);
				setState(265);
				match(Assign);
				setState(266);
				((PointDclIdAssignContext)_localctx).value = match(ID);
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

	public static class PointReferenceContext extends ParserRuleContext {
		public NumberTupleContext tuple;
		public StartPointReferenceContext startPoint;
		public EndPointReferenceContext endPoint;
		public Token idPoint;
		public FunctionCallContext funcCall;
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public StartPointReferenceContext startPointReference() {
			return getRuleContext(StartPointReferenceContext.class,0);
		}
		public EndPointReferenceContext endPointReference() {
			return getRuleContext(EndPointReferenceContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
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
		enterRule(_localctx, 46, RULE_pointReference);
		try {
			setState(277);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(269);
				match(LParen);
				setState(270);
				((PointReferenceContext)_localctx).tuple = numberTuple();
				setState(271);
				match(RParen);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(273);
				((PointReferenceContext)_localctx).startPoint = startPointReference();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(274);
				((PointReferenceContext)_localctx).endPoint = endPointReference();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(275);
				((PointReferenceContext)_localctx).idPoint = match(ID);
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(276);
				((PointReferenceContext)_localctx).funcCall = functionCall();
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

	public static class NumberTupleContext extends ParserRuleContext {
		public MathExpressionContext lhs;
		public MathExpressionContext rhs;
		public TerminalNode Seperator() { return getToken(OGParser.Seperator, 0); }
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
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
		enterRule(_localctx, 48, RULE_numberTuple);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(279);
			((NumberTupleContext)_localctx).lhs = mathExpression();
			setState(280);
			match(Seperator);
			setState(281);
			((NumberTupleContext)_localctx).rhs = mathExpression();
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
		enterRule(_localctx, 50, RULE_assignment);
		try {
			setState(285);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(283);
				variableAssignment();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(284);
				propertyAssignment();
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

	public static class PropertyAssignmentContext extends ParserRuleContext {
		public CoordinateXYValueContext xyVal;
		public MathExpressionContext value;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public CoordinateXYValueContext coordinateXYValue() {
			return getRuleContext(CoordinateXYValueContext.class,0);
		}
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
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
		enterRule(_localctx, 52, RULE_propertyAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(287);
			((PropertyAssignmentContext)_localctx).xyVal = coordinateXYValue();
			setState(288);
			match(Assign);
			setState(289);
			((PropertyAssignmentContext)_localctx).value = mathExpression();
			setState(290);
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
		public VariableAssignmentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableAssignment; }
	 
		public VariableAssignmentContext() { }
		public void copyFrom(VariableAssignmentContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class IdAssignContext extends VariableAssignmentContext {
		public Token id;
		public Token value;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public List<TerminalNode> ID() { return getTokens(OGParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(OGParser.ID, i);
		}
		public IdAssignContext(VariableAssignmentContext ctx) { copyFrom(ctx); }
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
	public static class BoolAssignContext extends VariableAssignmentContext {
		public Token id;
		public BoolExpressionContext value;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public BoolAssignContext(VariableAssignmentContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolAssign(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class FunctionCallAssignContext extends VariableAssignmentContext {
		public Token id;
		public FunctionCallContext funcCall;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public FunctionCallAssignContext(VariableAssignmentContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFunctionCallAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFunctionCallAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFunctionCallAssign(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class NumberAssignContext extends VariableAssignmentContext {
		public Token id;
		public MathExpressionContext value;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public NumberAssignContext(VariableAssignmentContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumberAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumberAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumberAssign(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PointAssignContext extends VariableAssignmentContext {
		public PointAssignmentContext pointAssignment() {
			return getRuleContext(PointAssignmentContext.class,0);
		}
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public PointAssignContext(VariableAssignmentContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPointAssign(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPointAssign(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPointAssign(this);
			else return visitor.visitChildren(this);
		}
	}

	public final VariableAssignmentContext variableAssignment() throws RecognitionException {
		VariableAssignmentContext _localctx = new VariableAssignmentContext(_ctx, getState());
		enterRule(_localctx, 54, RULE_variableAssignment);
		try {
			setState(314);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,16,_ctx) ) {
			case 1:
				_localctx = new IdAssignContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(292);
				((IdAssignContext)_localctx).id = match(ID);
				setState(293);
				match(Assign);
				setState(294);
				((IdAssignContext)_localctx).value = match(ID);
				setState(295);
				match(Terminator);
				}
				break;
			case 2:
				_localctx = new BoolAssignContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(296);
				((BoolAssignContext)_localctx).id = match(ID);
				setState(297);
				match(Assign);
				setState(298);
				((BoolAssignContext)_localctx).value = boolExpression(0);
				setState(299);
				match(Terminator);
				}
				break;
			case 3:
				_localctx = new NumberAssignContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(301);
				((NumberAssignContext)_localctx).id = match(ID);
				setState(302);
				match(Assign);
				setState(303);
				((NumberAssignContext)_localctx).value = mathExpression();
				setState(304);
				match(Terminator);
				}
				break;
			case 4:
				_localctx = new PointAssignContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(306);
				pointAssignment();
				setState(307);
				match(Terminator);
				}
				break;
			case 5:
				_localctx = new FunctionCallAssignContext(_localctx);
				enterOuterAlt(_localctx, 5);
				{
				setState(309);
				((FunctionCallAssignContext)_localctx).id = match(ID);
				setState(310);
				match(Assign);
				setState(311);
				((FunctionCallAssignContext)_localctx).funcCall = functionCall();
				setState(312);
				match(Terminator);
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

	public static class PointAssignmentContext extends ParserRuleContext {
		public Token id;
		public PointReferenceContext value;
		public EndPointAssignmentContext endPointAssignment() {
			return getRuleContext(EndPointAssignmentContext.class,0);
		}
		public StartPointAssignmentContext startPointAssignment() {
			return getRuleContext(StartPointAssignmentContext.class,0);
		}
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
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
		enterRule(_localctx, 56, RULE_pointAssignment);
		try {
			setState(321);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,17,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(316);
				endPointAssignment();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(317);
				startPointAssignment();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(318);
				((PointAssignmentContext)_localctx).id = match(ID);
				setState(319);
				match(Assign);
				setState(320);
				((PointAssignmentContext)_localctx).value = pointReference();
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

	public static class StartPointAssignmentContext extends ParserRuleContext {
		public StartPointReferenceContext id;
		public PointReferenceContext value;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public StartPointReferenceContext startPointReference() {
			return getRuleContext(StartPointReferenceContext.class,0);
		}
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
		enterRule(_localctx, 58, RULE_startPointAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(323);
			((StartPointAssignmentContext)_localctx).id = startPointReference();
			setState(324);
			match(Assign);
			setState(325);
			((StartPointAssignmentContext)_localctx).value = pointReference();
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
		public EndPointReferenceContext id;
		public PointReferenceContext value;
		public TerminalNode Assign() { return getToken(OGParser.Assign, 0); }
		public EndPointReferenceContext endPointReference() {
			return getRuleContext(EndPointReferenceContext.class,0);
		}
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
		enterRule(_localctx, 60, RULE_endPointAssignment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(327);
			((EndPointAssignmentContext)_localctx).id = endPointReference();
			setState(328);
			match(Assign);
			setState(329);
			((EndPointAssignmentContext)_localctx).value = pointReference();
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
		public Token id;
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
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
		enterRule(_localctx, 62, RULE_expression);
		try {
			setState(335);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,18,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(331);
				((ExpressionContext)_localctx).id = match(ID);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(332);
				functionCall();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(333);
				mathExpression();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(334);
				boolExpression(0);
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

	public static class MathExpressionContext extends ParserRuleContext {
		public MathExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_mathExpression; }
	 
		public MathExpressionContext() { }
		public void copyFrom(MathExpressionContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class InfixAdditionExprContext extends MathExpressionContext {
		public TermContext lhs;
		public Token op;
		public MathExpressionContext rhs;
		public TermContext term() {
			return getRuleContext(TermContext.class,0);
		}
		public TerminalNode Plus_Minus() { return getToken(OGParser.Plus_Minus, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public InfixAdditionExprContext(MathExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterInfixAdditionExpr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitInfixAdditionExpr(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitInfixAdditionExpr(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class SingleTermExprContext extends MathExpressionContext {
		public TermContext child;
		public TermContext term() {
			return getRuleContext(TermContext.class,0);
		}
		public SingleTermExprContext(MathExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSingleTermExpr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSingleTermExpr(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSingleTermExpr(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MathExpressionContext mathExpression() throws RecognitionException {
		MathExpressionContext _localctx = new MathExpressionContext(_ctx, getState());
		enterRule(_localctx, 64, RULE_mathExpression);
		try {
			setState(342);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
			case 1:
				_localctx = new InfixAdditionExprContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(337);
				((InfixAdditionExprContext)_localctx).lhs = term();
				setState(338);
				((InfixAdditionExprContext)_localctx).op = match(Plus_Minus);
				setState(339);
				((InfixAdditionExprContext)_localctx).rhs = mathExpression();
				}
				break;
			case 2:
				_localctx = new SingleTermExprContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(341);
				((SingleTermExprContext)_localctx).child = term();
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

	public static class TermContext extends ParserRuleContext {
		public TermContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_term; }
	 
		public TermContext() { }
		public void copyFrom(TermContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class InfixMultExprContext extends TermContext {
		public FactorContext lhs;
		public Token op;
		public TermContext rhs;
		public FactorContext factor() {
			return getRuleContext(FactorContext.class,0);
		}
		public TerminalNode Mul_Div() { return getToken(OGParser.Mul_Div, 0); }
		public TermContext term() {
			return getRuleContext(TermContext.class,0);
		}
		public InfixMultExprContext(TermContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterInfixMultExpr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitInfixMultExpr(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitInfixMultExpr(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class SingleTermChildContext extends TermContext {
		public FactorContext child;
		public FactorContext factor() {
			return getRuleContext(FactorContext.class,0);
		}
		public SingleTermChildContext(TermContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSingleTermChild(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSingleTermChild(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSingleTermChild(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TermContext term() throws RecognitionException {
		TermContext _localctx = new TermContext(_ctx, getState());
		enterRule(_localctx, 66, RULE_term);
		try {
			setState(349);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,20,_ctx) ) {
			case 1:
				_localctx = new InfixMultExprContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(344);
				((InfixMultExprContext)_localctx).lhs = factor();
				setState(345);
				((InfixMultExprContext)_localctx).op = match(Mul_Div);
				setState(346);
				((InfixMultExprContext)_localctx).rhs = term();
				}
				break;
			case 2:
				_localctx = new SingleTermChildContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(348);
				((SingleTermChildContext)_localctx).child = factor();
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

	public static class FactorContext extends ParserRuleContext {
		public FactorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_factor; }
	 
		public FactorContext() { }
		public void copyFrom(FactorContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class PowerExprContext extends FactorContext {
		public AtomContext lhs;
		public Token pow;
		public FactorContext rhs;
		public AtomContext atom() {
			return getRuleContext(AtomContext.class,0);
		}
		public TerminalNode Pow() { return getToken(OGParser.Pow, 0); }
		public FactorContext factor() {
			return getRuleContext(FactorContext.class,0);
		}
		public PowerExprContext(FactorContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPowerExpr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPowerExpr(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPowerExpr(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class SingleAtomContext extends FactorContext {
		public AtomContext child;
		public AtomContext atom() {
			return getRuleContext(AtomContext.class,0);
		}
		public SingleAtomContext(FactorContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSingleAtom(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSingleAtom(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSingleAtom(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class ParenthesisMathExprContext extends FactorContext {
		public MathExpressionContext mathExpr;
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public ParenthesisMathExprContext(FactorContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterParenthesisMathExpr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitParenthesisMathExpr(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitParenthesisMathExpr(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FactorContext factor() throws RecognitionException {
		FactorContext _localctx = new FactorContext(_ctx, getState());
		enterRule(_localctx, 68, RULE_factor);
		try {
			setState(360);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
			case 1:
				_localctx = new PowerExprContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(351);
				((PowerExprContext)_localctx).lhs = atom();
				setState(352);
				((PowerExprContext)_localctx).pow = match(Pow);
				setState(353);
				((PowerExprContext)_localctx).rhs = factor();
				}
				break;
			case 2:
				_localctx = new SingleAtomContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(355);
				((SingleAtomContext)_localctx).child = atom();
				}
				break;
			case 3:
				_localctx = new ParenthesisMathExprContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(356);
				match(LParen);
				setState(357);
				((ParenthesisMathExprContext)_localctx).mathExpr = mathExpression();
				setState(358);
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

	public static class AtomContext extends ParserRuleContext {
		public AtomContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_atom; }
	 
		public AtomContext() { }
		public void copyFrom(AtomContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class AtomIdContext extends AtomContext {
		public Token id;
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public AtomIdContext(AtomContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterAtomId(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitAtomId(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitAtomId(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class NumberContext extends AtomContext {
		public Token value;
		public TerminalNode Number() { return getToken(OGParser.Number, 0); }
		public NumberContext(AtomContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNumber(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNumber(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNumber(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class AtomfuncCallContext extends AtomContext {
		public FunctionCallContext funcCall;
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public AtomfuncCallContext(AtomContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterAtomfuncCall(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitAtomfuncCall(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitAtomfuncCall(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class AtomXYValueContext extends AtomContext {
		public CoordinateXYValueContext xyValue;
		public CoordinateXYValueContext coordinateXYValue() {
			return getRuleContext(CoordinateXYValueContext.class,0);
		}
		public AtomXYValueContext(AtomContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterAtomXYValue(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitAtomXYValue(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitAtomXYValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final AtomContext atom() throws RecognitionException {
		AtomContext _localctx = new AtomContext(_ctx, getState());
		enterRule(_localctx, 70, RULE_atom);
		try {
			setState(366);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,22,_ctx) ) {
			case 1:
				_localctx = new AtomfuncCallContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(362);
				((AtomfuncCallContext)_localctx).funcCall = functionCall();
				}
				break;
			case 2:
				_localctx = new NumberContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(363);
				((NumberContext)_localctx).value = match(Number);
				}
				break;
			case 3:
				_localctx = new AtomXYValueContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(364);
				((AtomXYValueContext)_localctx).xyValue = coordinateXYValue();
				}
				break;
			case 4:
				_localctx = new AtomIdContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(365);
				((AtomIdContext)_localctx).id = match(ID);
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
		public BoolExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_boolExpression; }
	 
		public BoolExpressionContext() { }
		public void copyFrom(BoolExpressionContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class BoolExprIDContext extends BoolExpressionContext {
		public Token id;
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public BoolExprIDContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExprID(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExprID(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExprID(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class BoolExprBoolCompContext extends BoolExpressionContext {
		public BoolExpressionContext lhs;
		public BoolExpressionContext rhs;
		public TerminalNode LogicOperator() { return getToken(OGParser.LogicOperator, 0); }
		public List<BoolExpressionContext> boolExpression() {
			return getRuleContexts(BoolExpressionContext.class);
		}
		public BoolExpressionContext boolExpression(int i) {
			return getRuleContext(BoolExpressionContext.class,i);
		}
		public BoolExprBoolCompContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExprBoolComp(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExprBoolComp(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExprBoolComp(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class ParenthesisBoolExprContext extends BoolExpressionContext {
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public ParenthesisBoolExprContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterParenthesisBoolExpr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitParenthesisBoolExpr(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitParenthesisBoolExpr(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class BoolExprMathCompContext extends BoolExpressionContext {
		public MathExpressionContext lhs;
		public MathExpressionContext rhs;
		public TerminalNode BoolOperator() { return getToken(OGParser.BoolOperator, 0); }
		public List<MathExpressionContext> mathExpression() {
			return getRuleContexts(MathExpressionContext.class);
		}
		public MathExpressionContext mathExpression(int i) {
			return getRuleContext(MathExpressionContext.class,i);
		}
		public BoolExprMathCompContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExprMathComp(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExprMathComp(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExprMathComp(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class BoolExprNotPrefixContext extends BoolExpressionContext {
		public BoolExpressionContext boolExpr;
		public TerminalNode NOT() { return getToken(OGParser.NOT, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public BoolExprNotPrefixContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExprNotPrefix(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExprNotPrefix(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExprNotPrefix(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class BoolExprTrueFalseContext extends BoolExpressionContext {
		public Token value;
		public TerminalNode BooleanValue() { return getToken(OGParser.BooleanValue, 0); }
		public BoolExprTrueFalseContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExprTrueFalse(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExprTrueFalse(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExprTrueFalse(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class BoolExprFuncCallContext extends BoolExpressionContext {
		public FunctionCallContext funcCall;
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public BoolExprFuncCallContext(BoolExpressionContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterBoolExprFuncCall(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitBoolExprFuncCall(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitBoolExprFuncCall(this);
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
		int _startState = 72;
		enterRecursionRule(_localctx, 72, RULE_boolExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(382);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,23,_ctx) ) {
			case 1:
				{
				_localctx = new BoolExprIDContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(369);
				((BoolExprIDContext)_localctx).id = match(ID);
				}
				break;
			case 2:
				{
				_localctx = new BoolExprTrueFalseContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(370);
				((BoolExprTrueFalseContext)_localctx).value = match(BooleanValue);
				}
				break;
			case 3:
				{
				_localctx = new BoolExprFuncCallContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(371);
				((BoolExprFuncCallContext)_localctx).funcCall = functionCall();
				}
				break;
			case 4:
				{
				_localctx = new BoolExprMathCompContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(372);
				((BoolExprMathCompContext)_localctx).lhs = mathExpression();
				setState(373);
				match(BoolOperator);
				setState(374);
				((BoolExprMathCompContext)_localctx).rhs = mathExpression();
				}
				break;
			case 5:
				{
				_localctx = new BoolExprNotPrefixContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(376);
				match(NOT);
				setState(377);
				((BoolExprNotPrefixContext)_localctx).boolExpr = boolExpression(2);
				}
				break;
			case 6:
				{
				_localctx = new ParenthesisBoolExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(378);
				match(LParen);
				setState(379);
				boolExpression(0);
				setState(380);
				match(RParen);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(389);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new BoolExprBoolCompContext(new BoolExpressionContext(_parentctx, _parentState));
					((BoolExprBoolCompContext)_localctx).lhs = _prevctx;
					pushNewRecursionContext(_localctx, _startState, RULE_boolExpression);
					setState(384);
					if (!(precpred(_ctx, 3))) throw new FailedPredicateException(this, "precpred(_ctx, 3)");
					setState(385);
					match(LogicOperator);
					setState(386);
					((BoolExprBoolCompContext)_localctx).rhs = boolExpression(4);
					}
					} 
				}
				setState(391);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,24,_ctx);
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
		public IterationCommandContext iterCmd;
		public MovementCommandContext movementCmd;
		public DrawCommandContext drawCmd;
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
		enterRule(_localctx, 74, RULE_command);
		try {
			setState(395);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case RepeatStart:
				enterOuterAlt(_localctx, 1);
				{
				setState(392);
				((CommandContext)_localctx).iterCmd = iterationCommand();
				}
				break;
			case Curve:
			case Line:
				enterOuterAlt(_localctx, 2);
				{
				setState(393);
				((CommandContext)_localctx).movementCmd = movementCommand();
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 3);
				{
				setState(394);
				((CommandContext)_localctx).drawCmd = drawCommand();
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
		public LineCommandContext lineCmd;
		public CurveCommandContext curveCmd;
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
		enterRule(_localctx, 76, RULE_movementCommand);
		try {
			setState(403);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Line:
				enterOuterAlt(_localctx, 1);
				{
				setState(397);
				((MovementCommandContext)_localctx).lineCmd = lineCommand();
				setState(398);
				match(Terminator);
				}
				break;
			case Curve:
				enterOuterAlt(_localctx, 2);
				{
				setState(400);
				((MovementCommandContext)_localctx).curveCmd = curveCommand();
				setState(401);
				match(Terminator);
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

	public static class LineCommandContext extends ParserRuleContext {
		public Token type;
		public FromCommandContext fromCmd;
		public ToCommandsContext toCmds;
		public TerminalNode Line() { return getToken(OGParser.Line, 0); }
		public FromCommandContext fromCommand() {
			return getRuleContext(FromCommandContext.class,0);
		}
		public ToCommandsContext toCommands() {
			return getRuleContext(ToCommandsContext.class,0);
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
		enterRule(_localctx, 78, RULE_lineCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(405);
			((LineCommandContext)_localctx).type = match(Line);
			setState(406);
			((LineCommandContext)_localctx).fromCmd = fromCommand();
			setState(407);
			((LineCommandContext)_localctx).toCmds = toCommands();
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
		public ToCommandContext toCmd;
		public ToCommandsContext chainedToCmds;
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
			if ( listener instanceof OGListener ) ((OGListener)listener).enterToCommands(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitToCommands(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitToCommands(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ToCommandsContext toCommands() throws RecognitionException {
		ToCommandsContext _localctx = new ToCommandsContext(_ctx, getState());
		enterRule(_localctx, 80, RULE_toCommands);
		try {
			setState(413);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,27,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(409);
				((ToCommandsContext)_localctx).toCmd = toCommand();
				setState(410);
				((ToCommandsContext)_localctx).chainedToCmds = toCommands();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(412);
				((ToCommandsContext)_localctx).toCmd = toCommand();
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

	public static class CurveCommandContext extends ParserRuleContext {
		public Token type;
		public Token modifier;
		public MathExpressionContext angle;
		public FromCommandContext fromCmd;
		public ToCommandsContext toCmds;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode Curve() { return getToken(OGParser.Curve, 0); }
		public TerminalNode WithAngle() { return getToken(OGParser.WithAngle, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public FromCommandContext fromCommand() {
			return getRuleContext(FromCommandContext.class,0);
		}
		public ToCommandsContext toCommands() {
			return getRuleContext(ToCommandsContext.class,0);
		}
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
		enterRule(_localctx, 82, RULE_curveCommand);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(415);
			((CurveCommandContext)_localctx).type = match(Curve);
			setState(416);
			match(DOT);
			setState(417);
			((CurveCommandContext)_localctx).modifier = match(WithAngle);
			setState(418);
			match(LParen);
			setState(419);
			((CurveCommandContext)_localctx).angle = mathExpression();
			setState(420);
			match(RParen);
			setState(421);
			((CurveCommandContext)_localctx).fromCmd = fromCommand();
			setState(422);
			((CurveCommandContext)_localctx).toCmds = toCommands();
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
		public ToCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_toCommand; }
	 
		public ToCommandContext() { }
		public void copyFrom(ToCommandContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class ToWithStartPointRefContext extends ToCommandContext {
		public StartPointReferenceContext toPoint;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode To() { return getToken(OGParser.To, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public StartPointReferenceContext startPointReference() {
			return getRuleContext(StartPointReferenceContext.class,0);
		}
		public ToWithStartPointRefContext(ToCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterToWithStartPointRef(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitToWithStartPointRef(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitToWithStartPointRef(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class ToWithIdContext extends ToCommandContext {
		public Token id;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode To() { return getToken(OGParser.To, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ToWithIdContext(ToCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterToWithId(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitToWithId(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitToWithId(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class ToWithEndPointRefContext extends ToCommandContext {
		public EndPointReferenceContext toPoint;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode To() { return getToken(OGParser.To, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public EndPointReferenceContext endPointReference() {
			return getRuleContext(EndPointReferenceContext.class,0);
		}
		public ToWithEndPointRefContext(ToCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterToWithEndPointRef(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitToWithEndPointRef(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitToWithEndPointRef(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class ToWithNumberTupleContext extends ToCommandContext {
		public NumberTupleContext tuple;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode To() { return getToken(OGParser.To, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public ToWithNumberTupleContext(ToCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterToWithNumberTuple(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitToWithNumberTuple(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitToWithNumberTuple(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ToCommandContext toCommand() throws RecognitionException {
		ToCommandContext _localctx = new ToCommandContext(_ctx, getState());
		enterRule(_localctx, 84, RULE_toCommand);
		try {
			setState(447);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,28,_ctx) ) {
			case 1:
				_localctx = new ToWithIdContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(424);
				match(DOT);
				setState(425);
				match(To);
				setState(426);
				match(LParen);
				setState(427);
				((ToWithIdContext)_localctx).id = match(ID);
				setState(428);
				match(RParen);
				}
				break;
			case 2:
				_localctx = new ToWithNumberTupleContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(429);
				match(DOT);
				setState(430);
				match(To);
				setState(431);
				match(LParen);
				setState(432);
				((ToWithNumberTupleContext)_localctx).tuple = numberTuple();
				setState(433);
				match(RParen);
				}
				break;
			case 3:
				_localctx = new ToWithStartPointRefContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(435);
				match(DOT);
				setState(436);
				match(To);
				setState(437);
				match(LParen);
				setState(438);
				((ToWithStartPointRefContext)_localctx).toPoint = startPointReference();
				setState(439);
				match(RParen);
				}
				break;
			case 4:
				_localctx = new ToWithEndPointRefContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(441);
				match(DOT);
				setState(442);
				match(To);
				setState(443);
				match(LParen);
				setState(444);
				((ToWithEndPointRefContext)_localctx).toPoint = endPointReference();
				setState(445);
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

	public static class FromCommandContext extends ParserRuleContext {
		public FromCommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_fromCommand; }
	 
		public FromCommandContext() { }
		public void copyFrom(FromCommandContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class FromWithIdContext extends FromCommandContext {
		public Token id;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode From() { return getToken(OGParser.From, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public FromWithIdContext(FromCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFromWithId(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFromWithId(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFromWithId(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class FromWithStartPointRefContext extends FromCommandContext {
		public StartPointReferenceContext fromPoint;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode From() { return getToken(OGParser.From, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public StartPointReferenceContext startPointReference() {
			return getRuleContext(StartPointReferenceContext.class,0);
		}
		public FromWithStartPointRefContext(FromCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFromWithStartPointRef(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFromWithStartPointRef(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFromWithStartPointRef(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class FromWithNumberTupleContext extends FromCommandContext {
		public NumberTupleContext tuple;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode From() { return getToken(OGParser.From, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public NumberTupleContext numberTuple() {
			return getRuleContext(NumberTupleContext.class,0);
		}
		public FromWithNumberTupleContext(FromCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFromWithNumberTuple(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFromWithNumberTuple(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFromWithNumberTuple(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class FromWithEndPointRefContext extends FromCommandContext {
		public EndPointReferenceContext fromPoint;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode From() { return getToken(OGParser.From, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public EndPointReferenceContext endPointReference() {
			return getRuleContext(EndPointReferenceContext.class,0);
		}
		public FromWithEndPointRefContext(FromCommandContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFromWithEndPointRef(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFromWithEndPointRef(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFromWithEndPointRef(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FromCommandContext fromCommand() throws RecognitionException {
		FromCommandContext _localctx = new FromCommandContext(_ctx, getState());
		enterRule(_localctx, 86, RULE_fromCommand);
		try {
			setState(472);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,29,_ctx) ) {
			case 1:
				_localctx = new FromWithIdContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(449);
				match(DOT);
				setState(450);
				match(From);
				setState(451);
				match(LParen);
				setState(452);
				((FromWithIdContext)_localctx).id = match(ID);
				setState(453);
				match(RParen);
				}
				break;
			case 2:
				_localctx = new FromWithNumberTupleContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(454);
				match(DOT);
				setState(455);
				match(From);
				setState(456);
				match(LParen);
				setState(457);
				((FromWithNumberTupleContext)_localctx).tuple = numberTuple();
				setState(458);
				match(RParen);
				}
				break;
			case 3:
				_localctx = new FromWithStartPointRefContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(460);
				match(DOT);
				setState(461);
				match(From);
				setState(462);
				match(LParen);
				setState(463);
				((FromWithStartPointRefContext)_localctx).fromPoint = startPointReference();
				setState(464);
				match(RParen);
				}
				break;
			case 4:
				_localctx = new FromWithEndPointRefContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(466);
				match(DOT);
				setState(467);
				match(From);
				setState(468);
				match(LParen);
				setState(469);
				((FromWithEndPointRefContext)_localctx).fromPoint = endPointReference();
				setState(470);
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

	public static class IterationCommandContext extends ParserRuleContext {
		public NumberIterationContext numberIterCmd;
		public UntilIterationContext untilIterCmd;
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
		enterRule(_localctx, 88, RULE_iterationCommand);
		try {
			setState(476);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,30,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(474);
				((IterationCommandContext)_localctx).numberIterCmd = numberIteration();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(475);
				((IterationCommandContext)_localctx).untilIterCmd = untilIteration();
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
		public MathExpressionContext iterator;
		public BodyContext statements;
		public TerminalNode RepeatStart() { return getToken(OGParser.RepeatStart, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode RepeatEnd() { return getToken(OGParser.RepeatEnd, 0); }
		public MathExpressionContext mathExpression() {
			return getRuleContext(MathExpressionContext.class,0);
		}
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
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
		enterRule(_localctx, 90, RULE_numberIteration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(478);
			match(RepeatStart);
			setState(479);
			match(LParen);
			setState(480);
			((NumberIterationContext)_localctx).iterator = mathExpression();
			setState(481);
			match(RParen);
			setState(482);
			((NumberIterationContext)_localctx).statements = body();
			setState(483);
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
		public UntilIterationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_untilIteration; }
	 
		public UntilIterationContext() { }
		public void copyFrom(UntilIterationContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class UntilConditionContext extends UntilIterationContext {
		public BoolExpressionContext iterator;
		public BodyContext statements;
		public TerminalNode RepeatStart() { return getToken(OGParser.RepeatStart, 0); }
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode Until() { return getToken(OGParser.Until, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode RepeatEnd() { return getToken(OGParser.RepeatEnd, 0); }
		public BoolExpressionContext boolExpression() {
			return getRuleContext(BoolExpressionContext.class,0);
		}
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public UntilConditionContext(UntilIterationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterUntilCondition(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitUntilCondition(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitUntilCondition(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class UntilFuncCallContext extends UntilIterationContext {
		public FunctionCallContext iterator;
		public BodyContext statements;
		public TerminalNode RepeatStart() { return getToken(OGParser.RepeatStart, 0); }
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode Until() { return getToken(OGParser.Until, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode RepeatEnd() { return getToken(OGParser.RepeatEnd, 0); }
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public UntilFuncCallContext(UntilIterationContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterUntilFuncCall(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitUntilFuncCall(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitUntilFuncCall(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UntilIterationContext untilIteration() throws RecognitionException {
		UntilIterationContext _localctx = new UntilIterationContext(_ctx, getState());
		enterRule(_localctx, 92, RULE_untilIteration);
		try {
			setState(503);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,31,_ctx) ) {
			case 1:
				_localctx = new UntilFuncCallContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(485);
				match(RepeatStart);
				setState(486);
				match(DOT);
				setState(487);
				match(Until);
				setState(488);
				match(LParen);
				setState(489);
				((UntilFuncCallContext)_localctx).iterator = functionCall();
				setState(490);
				match(RParen);
				setState(491);
				((UntilFuncCallContext)_localctx).statements = body();
				setState(492);
				match(RepeatEnd);
				}
				break;
			case 2:
				_localctx = new UntilConditionContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(494);
				match(RepeatStart);
				setState(495);
				match(DOT);
				setState(496);
				match(Until);
				setState(497);
				match(LParen);
				setState(498);
				((UntilConditionContext)_localctx).iterator = boolExpression(0);
				setState(499);
				match(RParen);
				setState(500);
				((UntilConditionContext)_localctx).statements = body();
				setState(501);
				match(RepeatEnd);
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

	public static class FunctionDclContext extends ParserRuleContext {
		public ReturnFunctionDCLContext returnFunctionDCL() {
			return getRuleContext(ReturnFunctionDCLContext.class,0);
		}
		public VoidFunctionDCLContext voidFunctionDCL() {
			return getRuleContext(VoidFunctionDCLContext.class,0);
		}
		public FunctionDclContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDcl; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterFunctionDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitFunctionDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitFunctionDcl(this);
			else return visitor.visitChildren(this);
		}
	}

	public final FunctionDclContext functionDcl() throws RecognitionException {
		FunctionDclContext _localctx = new FunctionDclContext(_ctx, getState());
		enterRule(_localctx, 94, RULE_functionDcl);
		try {
			setState(507);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,32,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(505);
				returnFunctionDCL();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(506);
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
		public TypeWordContext type;
		public Token funcName;
		public ParameterDeclarationsContext paramDcls;
		public BodyContext statements;
		public ReturnStatementContext returnStmt;
		public TerminalNode FunctionStartWord() { return getToken(OGParser.FunctionStartWord, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public TypeWordContext typeWord() {
			return getRuleContext(TypeWordContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ParameterDeclarationsContext parameterDeclarations() {
			return getRuleContext(ParameterDeclarationsContext.class,0);
		}
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
		public ReturnStatementContext returnStatement() {
			return getRuleContext(ReturnStatementContext.class,0);
		}
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
		enterRule(_localctx, 96, RULE_returnFunctionDCL);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(509);
			match(FunctionStartWord);
			setState(510);
			((ReturnFunctionDCLContext)_localctx).type = typeWord();
			setState(511);
			((ReturnFunctionDCLContext)_localctx).funcName = match(ID);
			setState(512);
			match(LParen);
			setState(513);
			((ReturnFunctionDCLContext)_localctx).paramDcls = parameterDeclarations();
			setState(514);
			match(RParen);
			setState(515);
			match(OpenScope);
			setState(516);
			((ReturnFunctionDCLContext)_localctx).statements = body();
			setState(517);
			((ReturnFunctionDCLContext)_localctx).returnStmt = returnStatement();
			setState(518);
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
		enterRule(_localctx, 98, RULE_typeWord);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(520);
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
		public Token type;
		public Token id;
		public ParameterDeclarationsContext paramDcls;
		public BodyContext statements;
		public TerminalNode FunctionStartWord() { return getToken(OGParser.FunctionStartWord, 0); }
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode OpenScope() { return getToken(OGParser.OpenScope, 0); }
		public TerminalNode CloseScope() { return getToken(OGParser.CloseScope, 0); }
		public TerminalNode Void() { return getToken(OGParser.Void, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ParameterDeclarationsContext parameterDeclarations() {
			return getRuleContext(ParameterDeclarationsContext.class,0);
		}
		public BodyContext body() {
			return getRuleContext(BodyContext.class,0);
		}
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
		enterRule(_localctx, 100, RULE_voidFunctionDCL);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(522);
			match(FunctionStartWord);
			setState(523);
			((VoidFunctionDCLContext)_localctx).type = match(Void);
			setState(524);
			((VoidFunctionDCLContext)_localctx).id = match(ID);
			setState(525);
			match(LParen);
			setState(526);
			((VoidFunctionDCLContext)_localctx).paramDcls = parameterDeclarations();
			setState(527);
			match(RParen);
			setState(528);
			match(OpenScope);
			setState(529);
			((VoidFunctionDCLContext)_localctx).statements = body();
			setState(530);
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
		public ParameterDeclarationsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterDeclarations; }
	 
		public ParameterDeclarationsContext() { }
		public void copyFrom(ParameterDeclarationsContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class MultiParamDclContext extends ParameterDeclarationsContext {
		public ParameterDclContext currentParamDcl;
		public ParameterDeclarationsContext paramDcls;
		public TerminalNode Seperator() { return getToken(OGParser.Seperator, 0); }
		public ParameterDclContext parameterDcl() {
			return getRuleContext(ParameterDclContext.class,0);
		}
		public ParameterDeclarationsContext parameterDeclarations() {
			return getRuleContext(ParameterDeclarationsContext.class,0);
		}
		public MultiParamDclContext(ParameterDeclarationsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMultiParamDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMultiParamDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMultiParamDcl(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class NoParamsDclContext extends ParameterDeclarationsContext {
		public NoParamsDclContext(ParameterDeclarationsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNoParamsDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNoParamsDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNoParamsDcl(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class SingleParamDclContext extends ParameterDeclarationsContext {
		public ParameterDclContext paramDcl;
		public ParameterDclContext parameterDcl() {
			return getRuleContext(ParameterDclContext.class,0);
		}
		public SingleParamDclContext(ParameterDeclarationsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSingleParamDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSingleParamDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSingleParamDcl(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ParameterDeclarationsContext parameterDeclarations() throws RecognitionException {
		ParameterDeclarationsContext _localctx = new ParameterDeclarationsContext(_ctx, getState());
		enterRule(_localctx, 102, RULE_parameterDeclarations);
		try {
			setState(538);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,33,_ctx) ) {
			case 1:
				_localctx = new MultiParamDclContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(532);
				((MultiParamDclContext)_localctx).currentParamDcl = parameterDcl();
				setState(533);
				match(Seperator);
				setState(534);
				((MultiParamDclContext)_localctx).paramDcls = parameterDeclarations();
				}
				break;
			case 2:
				_localctx = new SingleParamDclContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(536);
				((SingleParamDclContext)_localctx).paramDcl = parameterDcl();
				}
				break;
			case 3:
				_localctx = new NoParamsDclContext(_localctx);
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

	public static class ParameterDclContext extends ParserRuleContext {
		public TypeWordContext type;
		public Token id;
		public TypeWordContext typeWord() {
			return getRuleContext(TypeWordContext.class,0);
		}
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ParameterDclContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameterDcl; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterParameterDcl(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitParameterDcl(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitParameterDcl(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ParameterDclContext parameterDcl() throws RecognitionException {
		ParameterDclContext _localctx = new ParameterDclContext(_ctx, getState());
		enterRule(_localctx, 104, RULE_parameterDcl);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(540);
			((ParameterDclContext)_localctx).type = typeWord();
			setState(541);
			((ParameterDclContext)_localctx).id = match(ID);
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
		public Token id;
		public PassedParamsContext params;
		public TerminalNode LParen() { return getToken(OGParser.LParen, 0); }
		public TerminalNode RParen() { return getToken(OGParser.RParen, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public PassedParamsContext passedParams() {
			return getRuleContext(PassedParamsContext.class,0);
		}
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
		enterRule(_localctx, 106, RULE_functionCall);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(543);
			((FunctionCallContext)_localctx).id = match(ID);
			setState(544);
			match(LParen);
			setState(545);
			((FunctionCallContext)_localctx).params = passedParams();
			setState(546);
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

	public static class PassedParamsContext extends ParserRuleContext {
		public PassedParamsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_passedParams; }
	 
		public PassedParamsContext() { }
		public void copyFrom(PassedParamsContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class MultiParametersContext extends PassedParamsContext {
		public PassedParamContext firstParameter;
		public PassedParamsContext params;
		public TerminalNode Seperator() { return getToken(OGParser.Seperator, 0); }
		public PassedParamContext passedParam() {
			return getRuleContext(PassedParamContext.class,0);
		}
		public PassedParamsContext passedParams() {
			return getRuleContext(PassedParamsContext.class,0);
		}
		public MultiParametersContext(PassedParamsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterMultiParameters(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitMultiParameters(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitMultiParameters(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class SingleParameterContext extends PassedParamsContext {
		public PassedParamContext parameter;
		public PassedParamContext passedParam() {
			return getRuleContext(PassedParamContext.class,0);
		}
		public SingleParameterContext(PassedParamsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterSingleParameter(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitSingleParameter(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitSingleParameter(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class NoParameterContext extends PassedParamsContext {
		public NoParameterContext(PassedParamsContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterNoParameter(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitNoParameter(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitNoParameter(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PassedParamsContext passedParams() throws RecognitionException {
		PassedParamsContext _localctx = new PassedParamsContext(_ctx, getState());
		enterRule(_localctx, 108, RULE_passedParams);
		try {
			setState(554);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,34,_ctx) ) {
			case 1:
				_localctx = new MultiParametersContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(548);
				((MultiParametersContext)_localctx).firstParameter = passedParam();
				setState(549);
				match(Seperator);
				setState(550);
				((MultiParametersContext)_localctx).params = passedParams();
				}
				break;
			case 2:
				_localctx = new SingleParameterContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(552);
				((SingleParameterContext)_localctx).parameter = passedParam();
				}
				break;
			case 3:
				_localctx = new NoParameterContext(_localctx);
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

	public static class PassedParamContext extends ParserRuleContext {
		public PassedParamContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_passedParam; }
	 
		public PassedParamContext() { }
		public void copyFrom(PassedParamContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class PassedStartPointReferenceContext extends PassedParamContext {
		public StartPointReferenceContext startpointRef;
		public StartPointReferenceContext startPointReference() {
			return getRuleContext(StartPointReferenceContext.class,0);
		}
		public PassedStartPointReferenceContext(PassedParamContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPassedStartPointReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPassedStartPointReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPassedStartPointReference(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PassedFunctionCallContext extends PassedParamContext {
		public FunctionCallContext funcCall;
		public FunctionCallContext functionCall() {
			return getRuleContext(FunctionCallContext.class,0);
		}
		public PassedFunctionCallContext(PassedParamContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPassedFunctionCall(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPassedFunctionCall(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPassedFunctionCall(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PassedEndPointReferenceContext extends PassedParamContext {
		public EndPointReferenceContext endpointRef;
		public EndPointReferenceContext endPointReference() {
			return getRuleContext(EndPointReferenceContext.class,0);
		}
		public PassedEndPointReferenceContext(PassedParamContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPassedEndPointReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPassedEndPointReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPassedEndPointReference(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PassedIDContext extends PassedParamContext {
		public Token id;
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public PassedIDContext(PassedParamContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPassedID(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPassedID(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPassedID(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class PassedDirectValueContext extends PassedParamContext {
		public ExpressionContext expr;
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public PassedDirectValueContext(PassedParamContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterPassedDirectValue(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitPassedDirectValue(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitPassedDirectValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PassedParamContext passedParam() throws RecognitionException {
		PassedParamContext _localctx = new PassedParamContext(_ctx, getState());
		enterRule(_localctx, 110, RULE_passedParam);
		try {
			setState(561);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,35,_ctx) ) {
			case 1:
				_localctx = new PassedIDContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(556);
				((PassedIDContext)_localctx).id = match(ID);
				}
				break;
			case 2:
				_localctx = new PassedFunctionCallContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(557);
				((PassedFunctionCallContext)_localctx).funcCall = functionCall();
				}
				break;
			case 3:
				_localctx = new PassedDirectValueContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(558);
				((PassedDirectValueContext)_localctx).expr = expression();
				}
				break;
			case 4:
				_localctx = new PassedEndPointReferenceContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(559);
				((PassedEndPointReferenceContext)_localctx).endpointRef = endPointReference();
				}
				break;
			case 5:
				_localctx = new PassedStartPointReferenceContext(_localctx);
				enterOuterAlt(_localctx, 5);
				{
				setState(560);
				((PassedStartPointReferenceContext)_localctx).startpointRef = startPointReference();
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

	public static class ReturnStatementContext extends ParserRuleContext {
		public ReturnStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_returnStatement; }
	 
		public ReturnStatementContext() { }
		public void copyFrom(ReturnStatementContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class ReturnValueReferenceContext extends ReturnStatementContext {
		public Token id;
		public TerminalNode FunctionReturnWord() { return getToken(OGParser.FunctionReturnWord, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public ReturnValueReferenceContext(ReturnStatementContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterReturnValueReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitReturnValueReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitReturnValueReference(this);
			else return visitor.visitChildren(this);
		}
	}
	public static class ReturnDirectValueContext extends ReturnStatementContext {
		public ExpressionContext expr;
		public TerminalNode FunctionReturnWord() { return getToken(OGParser.FunctionReturnWord, 0); }
		public TerminalNode Terminator() { return getToken(OGParser.Terminator, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public ReturnDirectValueContext(ReturnStatementContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterReturnDirectValue(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitReturnDirectValue(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitReturnDirectValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ReturnStatementContext returnStatement() throws RecognitionException {
		ReturnStatementContext _localctx = new ReturnStatementContext(_ctx, getState());
		enterRule(_localctx, 112, RULE_returnStatement);
		try {
			setState(570);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,36,_ctx) ) {
			case 1:
				_localctx = new ReturnValueReferenceContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(563);
				match(FunctionReturnWord);
				setState(564);
				((ReturnValueReferenceContext)_localctx).id = match(ID);
				setState(565);
				match(Terminator);
				}
				break;
			case 2:
				_localctx = new ReturnDirectValueContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(566);
				match(FunctionReturnWord);
				setState(567);
				((ReturnDirectValueContext)_localctx).expr = expression();
				setState(568);
				match(Terminator);
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

	public static class StartPointReferenceContext extends ParserRuleContext {
		public Token id;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public StartPointReferenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_startPointReference; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterStartPointReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitStartPointReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitStartPointReference(this);
			else return visitor.visitChildren(this);
		}
	}

	public final StartPointReferenceContext startPointReference() throws RecognitionException {
		StartPointReferenceContext _localctx = new StartPointReferenceContext(_ctx, getState());
		enterRule(_localctx, 114, RULE_startPointReference);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(572);
			((StartPointReferenceContext)_localctx).id = match(ID);
			setState(573);
			match(DOT);
			setState(574);
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

	public static class EndPointReferenceContext extends ParserRuleContext {
		public Token id;
		public TerminalNode DOT() { return getToken(OGParser.DOT, 0); }
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public EndPointReferenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_endPointReference; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterEndPointReference(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitEndPointReference(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitEndPointReference(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EndPointReferenceContext endPointReference() throws RecognitionException {
		EndPointReferenceContext _localctx = new EndPointReferenceContext(_ctx, getState());
		enterRule(_localctx, 116, RULE_endPointReference);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(576);
			((EndPointReferenceContext)_localctx).id = match(ID);
			setState(577);
			match(DOT);
			setState(578);
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

	public static class CoordinateXYValueContext extends ParserRuleContext {
		public Token id;
		public Token xy;
		public StartPointReferenceContext startPoint;
		public EndPointReferenceContext endPoint;
		public TerminalNode ID() { return getToken(OGParser.ID, 0); }
		public StartPointReferenceContext startPointReference() {
			return getRuleContext(StartPointReferenceContext.class,0);
		}
		public EndPointReferenceContext endPointReference() {
			return getRuleContext(EndPointReferenceContext.class,0);
		}
		public CoordinateXYValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_coordinateXYValue; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).enterCoordinateXYValue(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof OGListener ) ((OGListener)listener).exitCoordinateXYValue(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof OGVisitor ) return ((OGVisitor<? extends T>)visitor).visitCoordinateXYValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CoordinateXYValueContext coordinateXYValue() throws RecognitionException {
		CoordinateXYValueContext _localctx = new CoordinateXYValueContext(_ctx, getState());
		enterRule(_localctx, 118, RULE_coordinateXYValue);
		try {
			setState(592);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,39,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(580);
				((CoordinateXYValueContext)_localctx).id = match(ID);
				setState(581);
				((CoordinateXYValueContext)_localctx).xy = match(T__2);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				{
				setState(582);
				((CoordinateXYValueContext)_localctx).id = match(ID);
				setState(583);
				((CoordinateXYValueContext)_localctx).xy = match(T__3);
				}
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(586);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,37,_ctx) ) {
				case 1:
					{
					setState(584);
					((CoordinateXYValueContext)_localctx).startPoint = startPointReference();
					}
					break;
				case 2:
					{
					setState(585);
					((CoordinateXYValueContext)_localctx).endPoint = endPointReference();
					}
					break;
				}
				setState(590);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case T__2:
					{
					setState(588);
					((CoordinateXYValueContext)_localctx).xy = match(T__2);
					}
					break;
				case T__3:
					{
					setState(589);
					((CoordinateXYValueContext)_localctx).xy = match(T__3);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
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

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 36:
			return boolExpression_sempred((BoolExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean boolExpression_sempred(BoolExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 3);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\66\u0255\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64\t"+
		"\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\4=\t="+
		"\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\5\3\u0085\n\3\3\4\3\4\3\4\3\4"+
		"\3\4\5\4\u008c\n\4\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\5\6\u0096\n\6\3\7\3"+
		"\7\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b"+
		"\3\b\3\b\3\t\3\t\3\t\3\t\5\t\u00b1\n\t\3\n\3\n\3\n\3\n\5\n\u00b7\n\n\3"+
		"\13\3\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\5\f\u00c2\n\f\3\r\3\r\3\r\3\r"+
		"\3\r\3\r\5\r\u00ca\n\r\3\16\3\16\3\16\3\16\3\16\3\16\3\17\3\17\3\20\3"+
		"\20\3\20\3\20\5\20\u00d8\n\20\3\21\3\21\3\21\5\21\u00dd\n\21\3\22\3\22"+
		"\3\22\3\22\5\22\u00e3\n\22\3\23\3\23\3\23\3\23\5\23\u00e9\n\23\3\24\3"+
		"\24\3\24\3\24\5\24\u00ef\n\24\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3\25"+
		"\3\25\5\25\u00fa\n\25\3\26\3\26\3\26\3\26\3\26\3\27\3\27\3\27\3\27\3\27"+
		"\3\30\3\30\3\30\3\30\3\30\3\30\3\30\3\30\5\30\u010e\n\30\3\31\3\31\3\31"+
		"\3\31\3\31\3\31\3\31\3\31\5\31\u0118\n\31\3\32\3\32\3\32\3\32\3\33\3\33"+
		"\5\33\u0120\n\33\3\34\3\34\3\34\3\34\3\34\3\35\3\35\3\35\3\35\3\35\3\35"+
		"\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35"+
		"\3\35\3\35\5\35\u013d\n\35\3\36\3\36\3\36\3\36\3\36\5\36\u0144\n\36\3"+
		"\37\3\37\3\37\3\37\3 \3 \3 \3 \3!\3!\3!\3!\5!\u0152\n!\3\"\3\"\3\"\3\""+
		"\3\"\5\"\u0159\n\"\3#\3#\3#\3#\3#\5#\u0160\n#\3$\3$\3$\3$\3$\3$\3$\3$"+
		"\3$\5$\u016b\n$\3%\3%\3%\3%\5%\u0171\n%\3&\3&\3&\3&\3&\3&\3&\3&\3&\3&"+
		"\3&\3&\3&\3&\5&\u0181\n&\3&\3&\3&\7&\u0186\n&\f&\16&\u0189\13&\3\'\3\'"+
		"\3\'\5\'\u018e\n\'\3(\3(\3(\3(\3(\3(\5(\u0196\n(\3)\3)\3)\3)\3*\3*\3*"+
		"\3*\5*\u01a0\n*\3+\3+\3+\3+\3+\3+\3+\3+\3+\3,\3,\3,\3,\3,\3,\3,\3,\3,"+
		"\3,\3,\3,\3,\3,\3,\3,\3,\3,\3,\3,\3,\3,\3,\5,\u01c2\n,\3-\3-\3-\3-\3-"+
		"\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\3-\5-\u01db\n-\3."+
		"\3.\5.\u01df\n.\3/\3/\3/\3/\3/\3/\3/\3\60\3\60\3\60\3\60\3\60\3\60\3\60"+
		"\3\60\3\60\3\60\3\60\3\60\3\60\3\60\3\60\3\60\3\60\3\60\5\60\u01fa\n\60"+
		"\3\61\3\61\5\61\u01fe\n\61\3\62\3\62\3\62\3\62\3\62\3\62\3\62\3\62\3\62"+
		"\3\62\3\62\3\63\3\63\3\64\3\64\3\64\3\64\3\64\3\64\3\64\3\64\3\64\3\64"+
		"\3\65\3\65\3\65\3\65\3\65\3\65\5\65\u021d\n\65\3\66\3\66\3\66\3\67\3\67"+
		"\3\67\3\67\3\67\38\38\38\38\38\38\58\u022d\n8\39\39\39\39\39\59\u0234"+
		"\n9\3:\3:\3:\3:\3:\3:\3:\5:\u023d\n:\3;\3;\3;\3;\3<\3<\3<\3<\3=\3=\3="+
		"\3=\3=\3=\5=\u024d\n=\3=\3=\5=\u0251\n=\5=\u0253\n=\3=\2\3J>\2\4\6\b\n"+
		"\f\16\20\22\24\26\30\32\34\36 \"$&(*,.\60\62\64\668:<>@BDFHJLNPRTVXZ\\"+
		"^`bdfhjlnprtvx\2\3\3\2\f\16\2\u025d\2z\3\2\2\2\4\u0084\3\2\2\2\6\u008b"+
		"\3\2\2\2\b\u008d\3\2\2\2\n\u0095\3\2\2\2\f\u0097\3\2\2\2\16\u009c\3\2"+
		"\2\2\20\u00b0\3\2\2\2\22\u00b6\3\2\2\2\24\u00b8\3\2\2\2\26\u00c1\3\2\2"+
		"\2\30\u00c9\3\2\2\2\32\u00cb\3\2\2\2\34\u00d1\3\2\2\2\36\u00d7\3\2\2\2"+
		" \u00dc\3\2\2\2\"\u00e2\3\2\2\2$\u00e8\3\2\2\2&\u00ee\3\2\2\2(\u00f9\3"+
		"\2\2\2*\u00fb\3\2\2\2,\u0100\3\2\2\2.\u010d\3\2\2\2\60\u0117\3\2\2\2\62"+
		"\u0119\3\2\2\2\64\u011f\3\2\2\2\66\u0121\3\2\2\28\u013c\3\2\2\2:\u0143"+
		"\3\2\2\2<\u0145\3\2\2\2>\u0149\3\2\2\2@\u0151\3\2\2\2B\u0158\3\2\2\2D"+
		"\u015f\3\2\2\2F\u016a\3\2\2\2H\u0170\3\2\2\2J\u0180\3\2\2\2L\u018d\3\2"+
		"\2\2N\u0195\3\2\2\2P\u0197\3\2\2\2R\u019f\3\2\2\2T\u01a1\3\2\2\2V\u01c1"+
		"\3\2\2\2X\u01da\3\2\2\2Z\u01de\3\2\2\2\\\u01e0\3\2\2\2^\u01f9\3\2\2\2"+
		"`\u01fd\3\2\2\2b\u01ff\3\2\2\2d\u020a\3\2\2\2f\u020c\3\2\2\2h\u021c\3"+
		"\2\2\2j\u021e\3\2\2\2l\u0221\3\2\2\2n\u022c\3\2\2\2p\u0233\3\2\2\2r\u023c"+
		"\3\2\2\2t\u023e\3\2\2\2v\u0242\3\2\2\2x\u0252\3\2\2\2z{\5\4\3\2{|\5\24"+
		"\13\2|}\5\22\n\2}~\5\20\t\2~\3\3\2\2\2\177\u0080\7\61\2\2\u0080\u0081"+
		"\5\6\4\2\u0081\u0082\7+\2\2\u0082\u0085\3\2\2\2\u0083\u0085\3\2\2\2\u0084"+
		"\177\3\2\2\2\u0084\u0083\3\2\2\2\u0085\5\3\2\2\2\u0086\u0087\7\30\2\2"+
		"\u0087\u0088\5\b\5\2\u0088\u0089\5\6\4\2\u0089\u008c\3\2\2\2\u008a\u008c"+
		"\3\2\2\2\u008b\u0086\3\2\2\2\u008b\u008a\3\2\2\2\u008c\7\3\2\2\2\u008d"+
		"\u008e\7\62\2\2\u008e\u008f\5\n\6\2\u008f\t\3\2\2\2\u0090\u0091\7\30\2"+
		"\2\u0091\u0092\5\f\7\2\u0092\u0093\5\n\6\2\u0093\u0096\3\2\2\2\u0094\u0096"+
		"\3\2\2\2\u0095\u0090\3\2\2\2\u0095\u0094\3\2\2\2\u0096\13\3\2\2\2\u0097"+
		"\u0098\7\63\2\2\u0098\u0099\7\34\2\2\u0099\u009a\5\16\b\2\u009a\u009b"+
		"\7\35\2\2\u009b\r\3\2\2\2\u009c\u009d\7-\2\2\u009d\u009e\7(\2\2\u009e"+
		"\u009f\5B\"\2\u009f\u00a0\7,\2\2\u00a0\u00a1\7.\2\2\u00a1\u00a2\7(\2\2"+
		"\u00a2\u00a3\5B\"\2\u00a3\u00a4\7,\2\2\u00a4\u00a5\7/\2\2\u00a5\u00a6"+
		"\7(\2\2\u00a6\u00a7\5B\"\2\u00a7\u00a8\7,\2\2\u00a8\u00a9\7\60\2\2\u00a9"+
		"\u00aa\7(\2\2\u00aa\u00ab\5B\"\2\u00ab\17\3\2\2\2\u00ac\u00ad\5\32\16"+
		"\2\u00ad\u00ae\5\20\t\2\u00ae\u00b1\3\2\2\2\u00af\u00b1\3\2\2\2\u00b0"+
		"\u00ac\3\2\2\2\u00b0\u00af\3\2\2\2\u00b1\21\3\2\2\2\u00b2\u00b3\5`\61"+
		"\2\u00b3\u00b4\5\22\n\2\u00b4\u00b7\3\2\2\2\u00b5\u00b7\3\2\2\2\u00b6"+
		"\u00b2\3\2\2\2\u00b6\u00b5\3\2\2\2\u00b7\23\3\2\2\2\u00b8\u00b9\7\17\2"+
		"\2\u00b9\u00ba\7)\2\2\u00ba\u00bb\5\26\f\2\u00bb\u00bc\7*\2\2\u00bc\25"+
		"\3\2\2\2\u00bd\u00be\5\30\r\2\u00be\u00bf\5\26\f\2\u00bf\u00c2\3\2\2\2"+
		"\u00c0\u00c2\3\2\2\2\u00c1\u00bd\3\2\2\2\u00c1\u00c0\3\2\2\2\u00c2\27"+
		"\3\2\2\2\u00c3\u00c4\7\66\2\2\u00c4\u00ca\7+\2\2\u00c5\u00c6\7\66\2\2"+
		"\u00c6\u00c7\5X-\2\u00c7\u00c8\7+\2\2\u00c8\u00ca\3\2\2\2\u00c9\u00c3"+
		"\3\2\2\2\u00c9\u00c5\3\2\2\2\u00ca\31\3\2\2\2\u00cb\u00cc\7\13\2\2\u00cc"+
		"\u00cd\7\66\2\2\u00cd\u00ce\7)\2\2\u00ce\u00cf\5\34\17\2\u00cf\u00d0\7"+
		"*\2\2\u00d0\33\3\2\2\2\u00d1\u00d2\5\36\20\2\u00d2\35\3\2\2\2\u00d3\u00d4"+
		"\5 \21\2\u00d4\u00d5\5\36\20\2\u00d5\u00d8\3\2\2\2\u00d6\u00d8\3\2\2\2"+
		"\u00d7\u00d3\3\2\2\2\u00d7\u00d6\3\2\2\2\u00d8\37\3\2\2\2\u00d9\u00dd"+
		"\5(\25\2\u00da\u00dd\5\64\33\2\u00db\u00dd\5L\'\2\u00dc\u00d9\3\2\2\2"+
		"\u00dc\u00da\3\2\2\2\u00dc\u00db\3\2\2\2\u00dd!\3\2\2\2\u00de\u00df\5"+
		"\64\33\2\u00df\u00e0\5\"\22\2\u00e0\u00e3\3\2\2\2\u00e1\u00e3\3\2\2\2"+
		"\u00e2\u00de\3\2\2\2\u00e2\u00e1\3\2\2\2\u00e3#\3\2\2\2\u00e4\u00e5\5"+
		"(\25\2\u00e5\u00e6\5$\23\2\u00e6\u00e9\3\2\2\2\u00e7\u00e9\3\2\2\2\u00e8"+
		"\u00e4\3\2\2\2\u00e8\u00e7\3\2\2\2\u00e9%\3\2\2\2\u00ea\u00eb\5L\'\2\u00eb"+
		"\u00ec\5&\24\2\u00ec\u00ef\3\2\2\2\u00ed\u00ef\3\2\2\2\u00ee\u00ea\3\2"+
		"\2\2\u00ee\u00ed\3\2\2\2\u00ef\'\3\2\2\2\u00f0\u00f1\5,\27\2\u00f1\u00f2"+
		"\7+\2\2\u00f2\u00fa\3\2\2\2\u00f3\u00f4\5.\30\2\u00f4\u00f5\7+\2\2\u00f5"+
		"\u00fa\3\2\2\2\u00f6\u00f7\5*\26\2\u00f7\u00f8\7+\2\2\u00f8\u00fa\3\2"+
		"\2\2\u00f9\u00f0\3\2\2\2\u00f9\u00f3\3\2\2\2\u00f9\u00f6\3\2\2\2\u00fa"+
		")\3\2\2\2\u00fb\u00fc\7\r\2\2\u00fc\u00fd\7\66\2\2\u00fd\u00fe\7(\2\2"+
		"\u00fe\u00ff\5J&\2\u00ff+\3\2\2\2\u0100\u0101\7\16\2\2\u0101\u0102\7\66"+
		"\2\2\u0102\u0103\7(\2\2\u0103\u0104\5B\"\2\u0104-\3\2\2\2\u0105\u0106"+
		"\7\f\2\2\u0106\u0107\7\66\2\2\u0107\u0108\7(\2\2\u0108\u010e\5\60\31\2"+
		"\u0109\u010a\7\f\2\2\u010a\u010b\7\66\2\2\u010b\u010c\7(\2\2\u010c\u010e"+
		"\7\66\2\2\u010d\u0105\3\2\2\2\u010d\u0109\3\2\2\2\u010e/\3\2\2\2\u010f"+
		"\u0110\7\34\2\2\u0110\u0111\5\62\32\2\u0111\u0112\7\35\2\2\u0112\u0118"+
		"\3\2\2\2\u0113\u0118\5t;\2\u0114\u0118\5v<\2\u0115\u0118\7\66\2\2\u0116"+
		"\u0118\5l\67\2\u0117\u010f\3\2\2\2\u0117\u0113\3\2\2\2\u0117\u0114\3\2"+
		"\2\2\u0117\u0115\3\2\2\2\u0117\u0116\3\2\2\2\u0118\61\3\2\2\2\u0119\u011a"+
		"\5B\"\2\u011a\u011b\7,\2\2\u011b\u011c\5B\"\2\u011c\63\3\2\2\2\u011d\u0120"+
		"\58\35\2\u011e\u0120\5\66\34\2\u011f\u011d\3\2\2\2\u011f\u011e\3\2\2\2"+
		"\u0120\65\3\2\2\2\u0121\u0122\5x=\2\u0122\u0123\7(\2\2\u0123\u0124\5B"+
		"\"\2\u0124\u0125\7+\2\2\u0125\67\3\2\2\2\u0126\u0127\7\66\2\2\u0127\u0128"+
		"\7(\2\2\u0128\u0129\7\66\2\2\u0129\u013d\7+\2\2\u012a\u012b\7\66\2\2\u012b"+
		"\u012c\7(\2\2\u012c\u012d\5J&\2\u012d\u012e\7+\2\2\u012e\u013d\3\2\2\2"+
		"\u012f\u0130\7\66\2\2\u0130\u0131\7(\2\2\u0131\u0132\5B\"\2\u0132\u0133"+
		"\7+\2\2\u0133\u013d\3\2\2\2\u0134\u0135\5:\36\2\u0135\u0136\7+\2\2\u0136"+
		"\u013d\3\2\2\2\u0137\u0138\7\66\2\2\u0138\u0139\7(\2\2\u0139\u013a\5l"+
		"\67\2\u013a\u013b\7+\2\2\u013b\u013d\3\2\2\2\u013c\u0126\3\2\2\2\u013c"+
		"\u012a\3\2\2\2\u013c\u012f\3\2\2\2\u013c\u0134\3\2\2\2\u013c\u0137\3\2"+
		"\2\2\u013d9\3\2\2\2\u013e\u0144\5> \2\u013f\u0144\5<\37\2\u0140\u0141"+
		"\7\66\2\2\u0141\u0142\7(\2\2\u0142\u0144\5\60\31\2\u0143\u013e\3\2\2\2"+
		"\u0143\u013f\3\2\2\2\u0143\u0140\3\2\2\2\u0144;\3\2\2\2\u0145\u0146\5"+
		"t;\2\u0146\u0147\7(\2\2\u0147\u0148\5\60\31\2\u0148=\3\2\2\2\u0149\u014a"+
		"\5v<\2\u014a\u014b\7(\2\2\u014b\u014c\5\60\31\2\u014c?\3\2\2\2\u014d\u0152"+
		"\7\66\2\2\u014e\u0152\5l\67\2\u014f\u0152\5B\"\2\u0150\u0152\5J&\2\u0151"+
		"\u014d\3\2\2\2\u0151\u014e\3\2\2\2\u0151\u014f\3\2\2\2\u0151\u0150\3\2"+
		"\2\2\u0152A\3\2\2\2\u0153\u0154\5D#\2\u0154\u0155\7\36\2\2\u0155\u0156"+
		"\5B\"\2\u0156\u0159\3\2\2\2\u0157\u0159\5D#\2\u0158\u0153\3\2\2\2\u0158"+
		"\u0157\3\2\2\2\u0159C\3\2\2\2\u015a\u015b\5F$\2\u015b\u015c\7!\2\2\u015c"+
		"\u015d\5D#\2\u015d\u0160\3\2\2\2\u015e\u0160\5F$\2\u015f\u015a\3\2\2\2"+
		"\u015f\u015e\3\2\2\2\u0160E\3\2\2\2\u0161\u0162\5H%\2\u0162\u0163\7$\2"+
		"\2\u0163\u0164\5F$\2\u0164\u016b\3\2\2\2\u0165\u016b\5H%\2\u0166\u0167"+
		"\7\34\2\2\u0167\u0168\5B\"\2\u0168\u0169\7\35\2\2\u0169\u016b\3\2\2\2"+
		"\u016a\u0161\3\2\2\2\u016a\u0165\3\2\2\2\u016a\u0166\3\2\2\2\u016bG\3"+
		"\2\2\2\u016c\u0171\5l\67\2\u016d\u0171\7\7\2\2\u016e\u0171\5x=\2\u016f"+
		"\u0171\7\66\2\2\u0170\u016c\3\2\2\2\u0170\u016d\3\2\2\2\u0170\u016e\3"+
		"\2\2\2\u0170\u016f\3\2\2\2\u0171I\3\2\2\2\u0172\u0173\b&\1\2\u0173\u0181"+
		"\7\66\2\2\u0174\u0181\7\b\2\2\u0175\u0181\5l\67\2\u0176\u0177\5B\"\2\u0177"+
		"\u0178\7&\2\2\u0178\u0179\5B\"\2\u0179\u0181\3\2\2\2\u017a\u017b\7\'\2"+
		"\2\u017b\u0181\5J&\4\u017c\u017d\7\34\2\2\u017d\u017e\5J&\2\u017e\u017f"+
		"\7\35\2\2\u017f\u0181\3\2\2\2\u0180\u0172\3\2\2\2\u0180\u0174\3\2\2\2"+
		"\u0180\u0175\3\2\2\2\u0180\u0176\3\2\2\2\u0180\u017a\3\2\2\2\u0180\u017c"+
		"\3\2\2\2\u0181\u0187\3\2\2\2\u0182\u0183\f\5\2\2\u0183\u0184\7%\2\2\u0184"+
		"\u0186\5J&\6\u0185\u0182\3\2\2\2\u0186\u0189\3\2\2\2\u0187\u0185\3\2\2"+
		"\2\u0187\u0188\3\2\2\2\u0188K\3\2\2\2\u0189\u0187\3\2\2\2\u018a\u018e"+
		"\5Z.\2\u018b\u018e\5N(\2\u018c\u018e\5\30\r\2\u018d\u018a\3\2\2\2\u018d"+
		"\u018b\3\2\2\2\u018d\u018c\3\2\2\2\u018eM\3\2\2\2\u018f\u0190\5P)\2\u0190"+
		"\u0191\7+\2\2\u0191\u0196\3\2\2\2\u0192\u0193\5T+\2\u0193\u0194\7+\2\2"+
		"\u0194\u0196\3\2\2\2\u0195\u018f\3\2\2\2\u0195\u0192\3\2\2\2\u0196O\3"+
		"\2\2\2\u0197\u0198\7\22\2\2\u0198\u0199\5X-\2\u0199\u019a\5R*\2\u019a"+
		"Q\3\2\2\2\u019b\u019c\5V,\2\u019c\u019d\5R*\2\u019d\u01a0\3\2\2\2\u019e"+
		"\u01a0\5V,\2\u019f\u019b\3\2\2\2\u019f\u019e\3\2\2\2\u01a0S\3\2\2\2\u01a1"+
		"\u01a2\7\21\2\2\u01a2\u01a3\7\30\2\2\u01a3\u01a4\7\20\2\2\u01a4\u01a5"+
		"\7\34\2\2\u01a5\u01a6\5B\"\2\u01a6\u01a7\7\35\2\2\u01a7\u01a8\5X-\2\u01a8"+
		"\u01a9\5R*\2\u01a9U\3\2\2\2\u01aa\u01ab\7\30\2\2\u01ab\u01ac\7\23\2\2"+
		"\u01ac\u01ad\7\34\2\2\u01ad\u01ae\7\66\2\2\u01ae\u01c2\7\35\2\2\u01af"+
		"\u01b0\7\30\2\2\u01b0\u01b1\7\23\2\2\u01b1\u01b2\7\34\2\2\u01b2\u01b3"+
		"\5\62\32\2\u01b3\u01b4\7\35\2\2\u01b4\u01c2\3\2\2\2\u01b5\u01b6\7\30\2"+
		"\2\u01b6\u01b7\7\23\2\2\u01b7\u01b8\7\34\2\2\u01b8\u01b9\5t;\2\u01b9\u01ba"+
		"\7\35\2\2\u01ba\u01c2\3\2\2\2\u01bb\u01bc\7\30\2\2\u01bc\u01bd\7\23\2"+
		"\2\u01bd\u01be\7\34\2\2\u01be\u01bf\5v<\2\u01bf\u01c0\7\35\2\2\u01c0\u01c2"+
		"\3\2\2\2\u01c1\u01aa\3\2\2\2\u01c1\u01af\3\2\2\2\u01c1\u01b5\3\2\2\2\u01c1"+
		"\u01bb\3\2\2\2\u01c2W\3\2\2\2\u01c3\u01c4\7\30\2\2\u01c4\u01c5\7\24\2"+
		"\2\u01c5\u01c6\7\34\2\2\u01c6\u01c7\7\66\2\2\u01c7\u01db\7\35\2\2\u01c8"+
		"\u01c9\7\30\2\2\u01c9\u01ca\7\24\2\2\u01ca\u01cb\7\34\2\2\u01cb\u01cc"+
		"\5\62\32\2\u01cc\u01cd\7\35\2\2\u01cd\u01db\3\2\2\2\u01ce\u01cf\7\30\2"+
		"\2\u01cf\u01d0\7\24\2\2\u01d0\u01d1\7\34\2\2\u01d1\u01d2\5t;\2\u01d2\u01d3"+
		"\7\35\2\2\u01d3\u01db\3\2\2\2\u01d4\u01d5\7\30\2\2\u01d5\u01d6\7\24\2"+
		"\2\u01d6\u01d7\7\34\2\2\u01d7\u01d8\5v<\2\u01d8\u01d9\7\35\2\2\u01d9\u01db"+
		"\3\2\2\2\u01da\u01c3\3\2\2\2\u01da\u01c8\3\2\2\2\u01da\u01ce\3\2\2\2\u01da"+
		"\u01d4\3\2\2\2\u01dbY\3\2\2\2\u01dc\u01df\5\\/\2\u01dd\u01df\5^\60\2\u01de"+
		"\u01dc\3\2\2\2\u01de\u01dd\3\2\2\2\u01df[\3\2\2\2\u01e0\u01e1\7\25\2\2"+
		"\u01e1\u01e2\7\34\2\2\u01e2\u01e3\5B\"\2\u01e3\u01e4\7\35\2\2\u01e4\u01e5"+
		"\5\34\17\2\u01e5\u01e6\7\26\2\2\u01e6]\3\2\2\2\u01e7\u01e8\7\25\2\2\u01e8"+
		"\u01e9\7\30\2\2\u01e9\u01ea\7\27\2\2\u01ea\u01eb\7\34\2\2\u01eb\u01ec"+
		"\5l\67\2\u01ec\u01ed\7\35\2\2\u01ed\u01ee\5\34\17\2\u01ee\u01ef\7\26\2"+
		"\2\u01ef\u01fa\3\2\2\2\u01f0\u01f1\7\25\2\2\u01f1\u01f2\7\30\2\2\u01f2"+
		"\u01f3\7\27\2\2\u01f3\u01f4\7\34\2\2\u01f4\u01f5\5J&\2\u01f5\u01f6\7\35"+
		"\2\2\u01f6\u01f7\5\34\17\2\u01f7\u01f8\7\26\2\2\u01f8\u01fa\3\2\2\2\u01f9"+
		"\u01e7\3\2\2\2\u01f9\u01f0\3\2\2\2\u01fa_\3\2\2\2\u01fb\u01fe\5b\62\2"+
		"\u01fc\u01fe\5f\64\2\u01fd\u01fb\3\2\2\2\u01fd\u01fc\3\2\2\2\u01fea\3"+
		"\2\2\2\u01ff\u0200\7\31\2\2\u0200\u0201\5d\63\2\u0201\u0202\7\66\2\2\u0202"+
		"\u0203\7\34\2\2\u0203\u0204\5h\65\2\u0204\u0205\7\35\2\2\u0205\u0206\7"+
		")\2\2\u0206\u0207\5\34\17\2\u0207\u0208\5r:\2\u0208\u0209\7*\2\2\u0209"+
		"c\3\2\2\2\u020a\u020b\t\2\2\2\u020be\3\2\2\2\u020c\u020d\7\31\2\2\u020d"+
		"\u020e\7\33\2\2\u020e\u020f\7\66\2\2\u020f\u0210\7\34\2\2\u0210\u0211"+
		"\5h\65\2\u0211\u0212\7\35\2\2\u0212\u0213\7)\2\2\u0213\u0214\5\34\17\2"+
		"\u0214\u0215\7*\2\2\u0215g\3\2\2\2\u0216\u0217\5j\66\2\u0217\u0218\7,"+
		"\2\2\u0218\u0219\5h\65\2\u0219\u021d\3\2\2\2\u021a\u021d\5j\66\2\u021b"+
		"\u021d\3\2\2\2\u021c\u0216\3\2\2\2\u021c\u021a\3\2\2\2\u021c\u021b\3\2"+
		"\2\2\u021di\3\2\2\2\u021e\u021f\5d\63\2\u021f\u0220\7\66\2\2\u0220k\3"+
		"\2\2\2\u0221\u0222\7\66\2\2\u0222\u0223\7\34\2\2\u0223\u0224\5n8\2\u0224"+
		"\u0225\7\35\2\2\u0225m\3\2\2\2\u0226\u0227\5p9\2\u0227\u0228\7,\2\2\u0228"+
		"\u0229\5n8\2\u0229\u022d\3\2\2\2\u022a\u022d\5p9\2\u022b\u022d\3\2\2\2"+
		"\u022c\u0226\3\2\2\2\u022c\u022a\3\2\2\2\u022c\u022b\3\2\2\2\u022do\3"+
		"\2\2\2\u022e\u0234\7\66\2\2\u022f\u0234\5l\67\2\u0230\u0234\5@!\2\u0231"+
		"\u0234\5v<\2\u0232\u0234\5t;\2\u0233\u022e\3\2\2\2\u0233\u022f\3\2\2\2"+
		"\u0233\u0230\3\2\2\2\u0233\u0231\3\2\2\2\u0233\u0232\3\2\2\2\u0234q\3"+
		"\2\2\2\u0235\u0236\7\32\2\2\u0236\u0237\7\66\2\2\u0237\u023d\7+\2\2\u0238"+
		"\u0239\7\32\2\2\u0239\u023a\5@!\2\u023a\u023b\7+\2\2\u023b\u023d\3\2\2"+
		"\2\u023c\u0235\3\2\2\2\u023c\u0238\3\2\2\2\u023ds\3\2\2\2\u023e\u023f"+
		"\7\66\2\2\u023f\u0240\7\30\2\2\u0240\u0241\7\3\2\2\u0241u\3\2\2\2\u0242"+
		"\u0243\7\66\2\2\u0243\u0244\7\30\2\2\u0244\u0245\7\4\2\2\u0245w\3\2\2"+
		"\2\u0246\u0247\7\66\2\2\u0247\u0253\7\5\2\2\u0248\u0249\7\66\2\2\u0249"+
		"\u0253\7\6\2\2\u024a\u024d\5t;\2\u024b\u024d\5v<\2\u024c\u024a\3\2\2\2"+
		"\u024c\u024b\3\2\2\2\u024d\u0250\3\2\2\2\u024e\u0251\7\5\2\2\u024f\u0251"+
		"\7\6\2\2\u0250\u024e\3\2\2\2\u0250\u024f\3\2\2\2\u0251\u0253\3\2\2\2\u0252"+
		"\u0246\3\2\2\2\u0252\u0248\3\2\2\2\u0252\u024c\3\2\2\2\u0253y\3\2\2\2"+
		"*\u0084\u008b\u0095\u00b0\u00b6\u00c1\u00c9\u00d7\u00dc\u00e2\u00e8\u00ee"+
		"\u00f9\u010d\u0117\u011f\u013c\u0143\u0151\u0158\u015f\u016a\u0170\u0180"+
		"\u0187\u018d\u0195\u019f\u01c1\u01da\u01de\u01f9\u01fd\u021c\u022c\u0233"+
		"\u023c\u024c\u0250\u0252";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}