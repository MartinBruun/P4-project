// Generated from /Users/saxjax/developer/P4-project/OG/OG/OG.g4 by ANTLR 4.9.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class OGLexer extends Lexer {
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
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "Number", "BooleanValue", "Integer", "Float", "WS", "COMMENT", 
			"ShapeDCLWord", "PointDCLWord", "BoolDCLWord", "NumberDCLWord", "DrawDCLWord", 
			"WithAngle", "Curve", "Line", "To", "From", "RepeatStart", "RepeatEnd", 
			"Until", "DOT", "FunctionStartWord", "FunctionReturnWord", "Void", "LParen", 
			"RParen", "Plus_Minus", "Plus", "Minus", "Mul_Div", "Times", "Div", "Pow", 
			"LogicOperator", "BoolOperator", "GT", "LT", "EQ", "AND", "NOT", "OR", 
			"Assign", "OpenScope", "CloseScope", "Terminator", "Seperator", "XMIN", 
			"XMAX", "YMAX", "YMIN", "Machine", "WorkArea", "Size", "StartPointReference", 
			"EndPointReference", "If", "Then", "CoordinateXYValue", "ID"
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


	public OGLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "OG.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\66\u01d7\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t"+
		" \4!\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t"+
		"+\4,\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64"+
		"\t\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\3\2"+
		"\3\2\3\2\3\2\3\3\3\3\5\3\u0080\n\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4"+
		"\5\4\u008b\n\4\3\5\6\5\u008e\n\5\r\5\16\5\u008f\3\5\3\5\6\5\u0094\n\5"+
		"\r\5\16\5\u0095\5\5\u0098\n\5\3\6\6\6\u009b\n\6\r\6\16\6\u009c\3\6\3\6"+
		"\6\6\u00a1\n\6\r\6\16\6\u00a2\3\6\3\6\6\6\u00a7\n\6\r\6\16\6\u00a8\3\6"+
		"\3\6\6\6\u00ad\n\6\r\6\16\6\u00ae\3\6\3\6\6\6\u00b3\n\6\r\6\16\6\u00b4"+
		"\5\6\u00b7\n\6\3\7\6\7\u00ba\n\7\r\7\16\7\u00bb\3\7\3\7\3\b\3\b\3\b\3"+
		"\b\7\b\u00c4\n\b\f\b\16\b\u00c7\13\b\3\b\3\b\3\b\3\b\3\b\3\t\3\t\3\t\3"+
		"\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n\3\13\3\13\3\13\3\13\3\13\3\f\3\f\3"+
		"\f\3\f\3\f\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\16\3"+
		"\16\3\16\3\16\3\16\3\17\3\17\3\17\3\17\3\17\3\17\3\20\3\20\3\20\3\20\3"+
		"\20\3\21\3\21\3\21\3\22\3\22\3\22\3\22\3\22\3\23\3\23\3\23\3\23\3\23\3"+
		"\23\3\23\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\25\3"+
		"\25\3\25\3\25\3\25\3\25\3\26\3\26\3\27\3\27\3\27\3\27\3\27\3\27\3\27\3"+
		"\27\3\27\3\30\3\30\3\30\3\30\3\30\3\30\3\30\3\31\3\31\3\31\3\31\3\31\3"+
		"\32\3\32\3\33\3\33\3\34\3\34\5\34\u013d\n\34\3\35\3\35\3\36\3\36\3\37"+
		"\3\37\5\37\u0145\n\37\3 \3 \3!\3!\3\"\3\"\3#\3#\5#\u014f\n#\3$\3$\3$\5"+
		"$\u0154\n$\3%\3%\3&\3&\3\'\3\'\3\'\3(\3(\3(\3)\3)\3*\3*\3*\3+\3+\3,\3"+
		",\3-\3-\3.\3.\3/\3/\3\60\3\60\3\60\3\60\3\60\3\61\3\61\3\61\3\61\3\61"+
		"\3\62\3\62\3\62\3\62\3\62\3\63\3\63\3\63\3\63\3\63\3\64\3\64\3\64\3\64"+
		"\3\64\3\64\3\64\3\64\3\65\3\65\3\65\3\65\3\65\3\65\3\65\3\65\3\65\3\66"+
		"\3\66\3\66\3\66\3\66\3\67\3\67\3\67\3\67\3\67\3\67\3\67\3\67\3\67\3\67"+
		"\3\67\3\67\3\67\38\38\38\38\38\38\38\38\38\38\38\39\39\39\3:\3:\3:\3:"+
		"\3:\3;\3;\3;\3;\3;\3;\3;\3;\3;\3;\5;\u01c3\n;\3;\3;\3;\3;\5;\u01c9\n;"+
		"\5;\u01cb\n;\3<\6<\u01ce\n<\r<\16<\u01cf\3<\7<\u01d3\n<\f<\16<\u01d6\13"+
		"<\3\u00c5\2=\3\3\5\4\7\5\t\2\13\2\r\6\17\7\21\b\23\t\25\n\27\13\31\f\33"+
		"\r\35\16\37\17!\20#\21%\22\'\23)\24+\25-\26/\27\61\30\63\31\65\32\67\33"+
		"9\34;\35=\36?\37A C!E\"G#I\2K\2M\2O\2Q$S\2U%W&Y\'[(])_*a+c,e-g.i/k\60"+
		"m\61o\62q\63s\64u\65w\66\3\2\6\3\2\62;\5\2\13\f\17\17\"\"\4\2C\\c|\5\2"+
		"\62;C\\c|\2\u01e8\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\r\3\2\2\2\2\17"+
		"\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2"+
		"\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3"+
		"\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3"+
		"\2\2\2\2\63\3\2\2\2\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2"+
		"=\3\2\2\2\2?\3\2\2\2\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2Q\3"+
		"\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2Y\3\2\2\2\2[\3\2\2\2\2]\3\2\2\2\2_\3\2\2"+
		"\2\2a\3\2\2\2\2c\3\2\2\2\2e\3\2\2\2\2g\3\2\2\2\2i\3\2\2\2\2k\3\2\2\2\2"+
		"m\3\2\2\2\2o\3\2\2\2\2q\3\2\2\2\2s\3\2\2\2\2u\3\2\2\2\2w\3\2\2\2\3y\3"+
		"\2\2\2\5\177\3\2\2\2\7\u008a\3\2\2\2\t\u0097\3\2\2\2\13\u00b6\3\2\2\2"+
		"\r\u00b9\3\2\2\2\17\u00bf\3\2\2\2\21\u00cd\3\2\2\2\23\u00d3\3\2\2\2\25"+
		"\u00d9\3\2\2\2\27\u00de\3\2\2\2\31\u00e5\3\2\2\2\33\u00ea\3\2\2\2\35\u00f4"+
		"\3\2\2\2\37\u00fa\3\2\2\2!\u00ff\3\2\2\2#\u0102\3\2\2\2%\u0107\3\2\2\2"+
		"\'\u010e\3\2\2\2)\u0119\3\2\2\2+\u011f\3\2\2\2-\u0121\3\2\2\2/\u012a\3"+
		"\2\2\2\61\u0131\3\2\2\2\63\u0136\3\2\2\2\65\u0138\3\2\2\2\67\u013c\3\2"+
		"\2\29\u013e\3\2\2\2;\u0140\3\2\2\2=\u0144\3\2\2\2?\u0146\3\2\2\2A\u0148"+
		"\3\2\2\2C\u014a\3\2\2\2E\u014e\3\2\2\2G\u0153\3\2\2\2I\u0155\3\2\2\2K"+
		"\u0157\3\2\2\2M\u0159\3\2\2\2O\u015c\3\2\2\2Q\u015f\3\2\2\2S\u0161\3\2"+
		"\2\2U\u0164\3\2\2\2W\u0166\3\2\2\2Y\u0168\3\2\2\2[\u016a\3\2\2\2]\u016c"+
		"\3\2\2\2_\u016e\3\2\2\2a\u0173\3\2\2\2c\u0178\3\2\2\2e\u017d\3\2\2\2g"+
		"\u0182\3\2\2\2i\u018a\3\2\2\2k\u0193\3\2\2\2m\u0198\3\2\2\2o\u01a5\3\2"+
		"\2\2q\u01b0\3\2\2\2s\u01b3\3\2\2\2u\u01ca\3\2\2\2w\u01cd\3\2\2\2yz\7\60"+
		"\2\2z{\7v\2\2{|\7q\2\2|\4\3\2\2\2}\u0080\5\t\5\2~\u0080\5\13\6\2\177}"+
		"\3\2\2\2\177~\3\2\2\2\u0080\6\3\2\2\2\u0081\u0082\7v\2\2\u0082\u0083\7"+
		"t\2\2\u0083\u0084\7w\2\2\u0084\u008b\7g\2\2\u0085\u0086\7h\2\2\u0086\u0087"+
		"\7c\2\2\u0087\u0088\7n\2\2\u0088\u0089\7u\2\2\u0089\u008b\7g\2\2\u008a"+
		"\u0081\3\2\2\2\u008a\u0085\3\2\2\2\u008b\b\3\2\2\2\u008c\u008e\t\2\2\2"+
		"\u008d\u008c\3\2\2\2\u008e\u008f\3\2\2\2\u008f\u008d\3\2\2\2\u008f\u0090"+
		"\3\2\2\2\u0090\u0098\3\2\2\2\u0091\u0093\7/\2\2\u0092\u0094\t\2\2\2\u0093"+
		"\u0092\3\2\2\2\u0094\u0095\3\2\2\2\u0095\u0093\3\2\2\2\u0095\u0096\3\2"+
		"\2\2\u0096\u0098\3\2\2\2\u0097\u008d\3\2\2\2\u0097\u0091\3\2\2\2\u0098"+
		"\n\3\2\2\2\u0099\u009b\t\2\2\2\u009a\u0099\3\2\2\2\u009b\u009c\3\2\2\2"+
		"\u009c\u009a\3\2\2\2\u009c\u009d\3\2\2\2\u009d\u009e\3\2\2\2\u009e\u00a0"+
		"\7\60\2\2\u009f\u00a1\t\2\2\2\u00a0\u009f\3\2\2\2\u00a1\u00a2\3\2\2\2"+
		"\u00a2\u00a0\3\2\2\2\u00a2\u00a3\3\2\2\2\u00a3\u00b7\3\2\2\2\u00a4\u00a6"+
		"\7/\2\2\u00a5\u00a7\t\2\2\2\u00a6\u00a5\3\2\2\2\u00a7\u00a8\3\2\2\2\u00a8"+
		"\u00a6\3\2\2\2\u00a8\u00a9\3\2\2\2\u00a9\u00b7\3\2\2\2\u00aa\u00ac\7/"+
		"\2\2\u00ab\u00ad\t\2\2\2\u00ac\u00ab\3\2\2\2\u00ad\u00ae\3\2\2\2\u00ae"+
		"\u00ac\3\2\2\2\u00ae\u00af\3\2\2\2\u00af\u00b0\3\2\2\2\u00b0\u00b2\7\60"+
		"\2\2\u00b1\u00b3\t\2\2\2\u00b2\u00b1\3\2\2\2\u00b3\u00b4\3\2\2\2\u00b4"+
		"\u00b2\3\2\2\2\u00b4\u00b5\3\2\2\2\u00b5\u00b7\3\2\2\2\u00b6\u009a\3\2"+
		"\2\2\u00b6\u00a4\3\2\2\2\u00b6\u00aa\3\2\2\2\u00b7\f\3\2\2\2\u00b8\u00ba"+
		"\t\3\2\2\u00b9\u00b8\3\2\2\2\u00ba\u00bb\3\2\2\2\u00bb\u00b9\3\2\2\2\u00bb"+
		"\u00bc\3\2\2\2\u00bc\u00bd\3\2\2\2\u00bd\u00be\b\7\2\2\u00be\16\3\2\2"+
		"\2\u00bf\u00c0\7\61\2\2\u00c0\u00c1\7,\2\2\u00c1\u00c5\3\2\2\2\u00c2\u00c4"+
		"\13\2\2\2\u00c3\u00c2\3\2\2\2\u00c4\u00c7\3\2\2\2\u00c5\u00c6\3\2\2\2"+
		"\u00c5\u00c3\3\2\2\2\u00c6\u00c8\3\2\2\2\u00c7\u00c5\3\2\2\2\u00c8\u00c9"+
		"\7,\2\2\u00c9\u00ca\7\61\2\2\u00ca\u00cb\3\2\2\2\u00cb\u00cc\b\b\2\2\u00cc"+
		"\20\3\2\2\2\u00cd\u00ce\7u\2\2\u00ce\u00cf\7j\2\2\u00cf\u00d0\7c\2\2\u00d0"+
		"\u00d1\7r\2\2\u00d1\u00d2\7g\2\2\u00d2\22\3\2\2\2\u00d3\u00d4\7r\2\2\u00d4"+
		"\u00d5\7q\2\2\u00d5\u00d6\7k\2\2\u00d6\u00d7\7p\2\2\u00d7\u00d8\7v\2\2"+
		"\u00d8\24\3\2\2\2\u00d9\u00da\7d\2\2\u00da\u00db\7q\2\2\u00db\u00dc\7"+
		"q\2\2\u00dc\u00dd\7n\2\2\u00dd\26\3\2\2\2\u00de\u00df\7p\2\2\u00df\u00e0"+
		"\7w\2\2\u00e0\u00e1\7o\2\2\u00e1\u00e2\7d\2\2\u00e2\u00e3\7g\2\2\u00e3"+
		"\u00e4\7t\2\2\u00e4\30\3\2\2\2\u00e5\u00e6\7f\2\2\u00e6\u00e7\7t\2\2\u00e7"+
		"\u00e8\7c\2\2\u00e8\u00e9\7y\2\2\u00e9\32\3\2\2\2\u00ea\u00eb\7y\2\2\u00eb"+
		"\u00ec\7k\2\2\u00ec\u00ed\7v\2\2\u00ed\u00ee\7j\2\2\u00ee\u00ef\7C\2\2"+
		"\u00ef\u00f0\7p\2\2\u00f0\u00f1\7i\2\2\u00f1\u00f2\7n\2\2\u00f2\u00f3"+
		"\7g\2\2\u00f3\34\3\2\2\2\u00f4\u00f5\7e\2\2\u00f5\u00f6\7w\2\2\u00f6\u00f7"+
		"\7t\2\2\u00f7\u00f8\7x\2\2\u00f8\u00f9\7g\2\2\u00f9\36\3\2\2\2\u00fa\u00fb"+
		"\7n\2\2\u00fb\u00fc\7k\2\2\u00fc\u00fd\7p\2\2\u00fd\u00fe\7g\2\2\u00fe"+
		" \3\2\2\2\u00ff\u0100\7v\2\2\u0100\u0101\7q\2\2\u0101\"\3\2\2\2\u0102"+
		"\u0103\7h\2\2\u0103\u0104\7t\2\2\u0104\u0105\7q\2\2\u0105\u0106\7o\2\2"+
		"\u0106$\3\2\2\2\u0107\u0108\7t\2\2\u0108\u0109\7g\2\2\u0109\u010a\7r\2"+
		"\2\u010a\u010b\7g\2\2\u010b\u010c\7c\2\2\u010c\u010d\7v\2\2\u010d&\3\2"+
		"\2\2\u010e\u010f\7t\2\2\u010f\u0110\7g\2\2\u0110\u0111\7r\2\2\u0111\u0112"+
		"\7g\2\2\u0112\u0113\7c\2\2\u0113\u0114\7v\2\2\u0114\u0115\7\60\2\2\u0115"+
		"\u0116\7g\2\2\u0116\u0117\7p\2\2\u0117\u0118\7f\2\2\u0118(\3\2\2\2\u0119"+
		"\u011a\7w\2\2\u011a\u011b\7p\2\2\u011b\u011c\7v\2\2\u011c\u011d\7k\2\2"+
		"\u011d\u011e\7n\2\2\u011e*\3\2\2\2\u011f\u0120\7\60\2\2\u0120,\3\2\2\2"+
		"\u0121\u0122\7h\2\2\u0122\u0123\7w\2\2\u0123\u0124\7p\2\2\u0124\u0125"+
		"\7e\2\2\u0125\u0126\7v\2\2\u0126\u0127\7k\2\2\u0127\u0128\7q\2\2\u0128"+
		"\u0129\7p\2\2\u0129.\3\2\2\2\u012a\u012b\7t\2\2\u012b\u012c\7g\2\2\u012c"+
		"\u012d\7v\2\2\u012d\u012e\7w\2\2\u012e\u012f\7t\2\2\u012f\u0130\7p\2\2"+
		"\u0130\60\3\2\2\2\u0131\u0132\7x\2\2\u0132\u0133\7q\2\2\u0133\u0134\7"+
		"k\2\2\u0134\u0135\7f\2\2\u0135\62\3\2\2\2\u0136\u0137\7*\2\2\u0137\64"+
		"\3\2\2\2\u0138\u0139\7+\2\2\u0139\66\3\2\2\2\u013a\u013d\59\35\2\u013b"+
		"\u013d\5;\36\2\u013c\u013a\3\2\2\2\u013c\u013b\3\2\2\2\u013d8\3\2\2\2"+
		"\u013e\u013f\7-\2\2\u013f:\3\2\2\2\u0140\u0141\7/\2\2\u0141<\3\2\2\2\u0142"+
		"\u0145\5? \2\u0143\u0145\5A!\2\u0144\u0142\3\2\2\2\u0144\u0143\3\2\2\2"+
		"\u0145>\3\2\2\2\u0146\u0147\7,\2\2\u0147@\3\2\2\2\u0148\u0149\7\61\2\2"+
		"\u0149B\3\2\2\2\u014a\u014b\7`\2\2\u014bD\3\2\2\2\u014c\u014f\5O(\2\u014d"+
		"\u014f\5S*\2\u014e\u014c\3\2\2\2\u014e\u014d\3\2\2\2\u014fF\3\2\2\2\u0150"+
		"\u0154\5K&\2\u0151\u0154\5I%\2\u0152\u0154\5M\'\2\u0153\u0150\3\2\2\2"+
		"\u0153\u0151\3\2\2\2\u0153\u0152\3\2\2\2\u0154H\3\2\2\2\u0155\u0156\7"+
		"@\2\2\u0156J\3\2\2\2\u0157\u0158\7>\2\2\u0158L\3\2\2\2\u0159\u015a\7?"+
		"\2\2\u015a\u015b\7?\2\2\u015bN\3\2\2\2\u015c\u015d\7(\2\2\u015d\u015e"+
		"\7(\2\2\u015eP\3\2\2\2\u015f\u0160\7#\2\2\u0160R\3\2\2\2\u0161\u0162\7"+
		"~\2\2\u0162\u0163\7~\2\2\u0163T\3\2\2\2\u0164\u0165\7?\2\2\u0165V\3\2"+
		"\2\2\u0166\u0167\7}\2\2\u0167X\3\2\2\2\u0168\u0169\7\177\2\2\u0169Z\3"+
		"\2\2\2\u016a\u016b\7=\2\2\u016b\\\3\2\2\2\u016c\u016d\7.\2\2\u016d^\3"+
		"\2\2\2\u016e\u016f\7z\2\2\u016f\u0170\7o\2\2\u0170\u0171\7k\2\2\u0171"+
		"\u0172\7p\2\2\u0172`\3\2\2\2\u0173\u0174\7z\2\2\u0174\u0175\7o\2\2\u0175"+
		"\u0176\7c\2\2\u0176\u0177\7z\2\2\u0177b\3\2\2\2\u0178\u0179\7{\2\2\u0179"+
		"\u017a\7o\2\2\u017a\u017b\7k\2\2\u017b\u017c\7p\2\2\u017cd\3\2\2\2\u017d"+
		"\u017e\7{\2\2\u017e\u017f\7o\2\2\u017f\u0180\7c\2\2\u0180\u0181\7z\2\2"+
		"\u0181f\3\2\2\2\u0182\u0183\7O\2\2\u0183\u0184\7c\2\2\u0184\u0185\7e\2"+
		"\2\u0185\u0186\7j\2\2\u0186\u0187\7k\2\2\u0187\u0188\7p\2\2\u0188\u0189"+
		"\7g\2\2\u0189h\3\2\2\2\u018a\u018b\7Y\2\2\u018b\u018c\7q\2\2\u018c\u018d"+
		"\7t\2\2\u018d\u018e\7m\2\2\u018e\u018f\7C\2\2\u018f\u0190\7t\2\2\u0190"+
		"\u0191\7g\2\2\u0191\u0192\7c\2\2\u0192j\3\2\2\2\u0193\u0194\7u\2\2\u0194"+
		"\u0195\7k\2\2\u0195\u0196\7|\2\2\u0196\u0197\7g\2\2\u0197l\3\2\2\2\u0198"+
		"\u0199\5w<\2\u0199\u019a\7\60\2\2\u019a\u019b\7u\2\2\u019b\u019c\7v\2"+
		"\2\u019c\u019d\7c\2\2\u019d\u019e\7t\2\2\u019e\u019f\7v\2\2\u019f\u01a0"+
		"\7R\2\2\u01a0\u01a1\7q\2\2\u01a1\u01a2\7k\2\2\u01a2\u01a3\7p\2\2\u01a3"+
		"\u01a4\7v\2\2\u01a4n\3\2\2\2\u01a5\u01a6\5w<\2\u01a6\u01a7\7\60\2\2\u01a7"+
		"\u01a8\7g\2\2\u01a8\u01a9\7p\2\2\u01a9\u01aa\7f\2\2\u01aa\u01ab\7R\2\2"+
		"\u01ab\u01ac\7q\2\2\u01ac\u01ad\7k\2\2\u01ad\u01ae\7p\2\2\u01ae\u01af"+
		"\7v\2\2\u01afp\3\2\2\2\u01b0\u01b1\7k\2\2\u01b1\u01b2\7h\2\2\u01b2r\3"+
		"\2\2\2\u01b3\u01b4\7v\2\2\u01b4\u01b5\7j\2\2\u01b5\u01b6\7g\2\2\u01b6"+
		"\u01b7\7p\2\2\u01b7t\3\2\2\2\u01b8\u01b9\5w<\2\u01b9\u01ba\7\60\2\2\u01ba"+
		"\u01bb\7z\2\2\u01bb\u01cb\3\2\2\2\u01bc\u01bd\5w<\2\u01bd\u01be\7\60\2"+
		"\2\u01be\u01bf\7{\2\2\u01bf\u01cb\3\2\2\2\u01c0\u01c3\5m\67\2\u01c1\u01c3"+
		"\5o8\2\u01c2\u01c0\3\2\2\2\u01c2\u01c1\3\2\2\2\u01c3\u01c8\3\2\2\2\u01c4"+
		"\u01c5\7\60\2\2\u01c5\u01c9\7z\2\2\u01c6\u01c7\7\60\2\2\u01c7\u01c9\7"+
		"{\2\2\u01c8\u01c4\3\2\2\2\u01c8\u01c6\3\2\2\2\u01c9\u01cb\3\2\2\2\u01ca"+
		"\u01b8\3\2\2\2\u01ca\u01bc\3\2\2\2\u01ca\u01c2\3\2\2\2\u01cbv\3\2\2\2"+
		"\u01cc\u01ce\t\4\2\2\u01cd\u01cc\3\2\2\2\u01ce\u01cf\3\2\2\2\u01cf\u01cd"+
		"\3\2\2\2\u01cf\u01d0\3\2\2\2\u01d0\u01d4\3\2\2\2\u01d1\u01d3\t\5\2\2\u01d2"+
		"\u01d1\3\2\2\2\u01d3\u01d6\3\2\2\2\u01d4\u01d2\3\2\2\2\u01d4\u01d5\3\2"+
		"\2\2\u01d5x\3\2\2\2\u01d6\u01d4\3\2\2\2\31\2\177\u008a\u008f\u0095\u0097"+
		"\u009c\u00a2\u00a8\u00ae\u00b4\u00b6\u00bb\u00c5\u013c\u0144\u014e\u0153"+
		"\u01c2\u01c8\u01ca\u01cf\u01d4\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}