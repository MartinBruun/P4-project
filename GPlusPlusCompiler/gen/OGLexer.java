// Generated from /Users/saxjax/developer/P4-project/GPlusPlusCompiler/GPlusPlusCompiler/OG.g4 by ANTLR 4.9.1
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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, BooleanValue=6, Number=7, WS=8, 
		COMMENT=9, ShapeDCLWord=10, PointDCLWord=11, BoolDCLWord=12, NumberDCLWord=13, 
		DrawDCLWord=14, WithAngle=15, Curve=16, Line=17, To=18, From=19, RepeatStart=20, 
		RepeatEnd=21, Until=22, DOT=23, FunctionStartWord=24, FunctionReturnWord=25, 
		Void=26, LPAREN=27, RPAREN=28, PLUS=29, MINUS=30, TIMES=31, DIV=32, POW=33, 
		LogicOperator=34, BoolOperator=35, GT=36, LT=37, EQ=38, AND=39, OR=40, 
		Assign=41, OpenScope=42, CloseScope=43, Terminator=44, Seperator=45, CoordinatePropRef=46, 
		ID=47;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "BooleanValue", "Number", "Integer", 
			"Float", "WS", "COMMENT", "ShapeDCLWord", "PointDCLWord", "BoolDCLWord", 
			"NumberDCLWord", "DrawDCLWord", "WithAngle", "Curve", "Line", "To", "From", 
			"RepeatStart", "RepeatEnd", "Until", "DOT", "FunctionStartWord", "FunctionReturnWord", 
			"Void", "LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "POW", "LogicOperator", 
			"BoolOperator", "GT", "LT", "EQ", "AND", "OR", "Assign", "OpenScope", 
			"CloseScope", "Terminator", "Seperator", "CoordinatePropRef", "ID"
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\61\u0181\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t"+
		" \4!\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t"+
		"+\4,\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\3\2\3\2\3\2\3"+
		"\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4"+
		"\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\5\7\u008f\n\7\3\b\3\b\5\b\u0093\n\b\3\t\6\t\u0096\n\t\r\t\16"+
		"\t\u0097\3\t\3\t\6\t\u009c\n\t\r\t\16\t\u009d\5\t\u00a0\n\t\3\n\6\n\u00a3"+
		"\n\n\r\n\16\n\u00a4\3\n\3\n\6\n\u00a9\n\n\r\n\16\n\u00aa\3\n\3\n\6\n\u00af"+
		"\n\n\r\n\16\n\u00b0\3\n\3\n\6\n\u00b5\n\n\r\n\16\n\u00b6\3\n\3\n\6\n\u00bb"+
		"\n\n\r\n\16\n\u00bc\5\n\u00bf\n\n\3\13\6\13\u00c2\n\13\r\13\16\13\u00c3"+
		"\3\13\3\13\3\f\3\f\3\f\3\f\7\f\u00cc\n\f\f\f\16\f\u00cf\13\f\3\f\3\f\3"+
		"\f\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\16\3\17"+
		"\3\17\3\17\3\17\3\17\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\21\3\21\3\21"+
		"\3\21\3\21\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\23\3\23"+
		"\3\23\3\23\3\23\3\23\3\24\3\24\3\24\3\24\3\24\3\25\3\25\3\25\3\26\3\26"+
		"\3\26\3\26\3\26\3\27\3\27\3\27\3\27\3\27\3\27\3\27\3\30\3\30\3\30\3\30"+
		"\3\30\3\30\3\30\3\30\3\30\3\30\3\30\3\31\3\31\3\31\3\31\3\31\3\31\3\32"+
		"\3\32\3\33\3\33\3\33\3\33\3\33\3\33\3\33\3\33\3\33\3\34\3\34\3\34\3\34"+
		"\3\34\3\34\3\34\3\35\3\35\3\35\3\35\3\35\3\36\3\36\3\37\3\37\3 \3 \3!"+
		"\3!\3\"\3\"\3#\3#\3$\3$\3%\3%\5%\u014f\n%\3&\3&\3&\5&\u0154\n&\3\'\3\'"+
		"\3(\3(\3)\3)\3)\3*\3*\3*\3+\3+\3+\3,\3,\3-\3-\3.\3.\3/\3/\3\60\3\60\3"+
		"\61\3\61\3\61\3\61\3\61\3\61\3\61\3\61\5\61\u0175\n\61\3\62\6\62\u0178"+
		"\n\62\r\62\16\62\u0179\3\62\7\62\u017d\n\62\f\62\16\62\u0180\13\62\3\u00cd"+
		"\2\63\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\2\23\2\25\n\27\13\31\f\33\r\35"+
		"\16\37\17!\20#\21%\22\'\23)\24+\25-\26/\27\61\30\63\31\65\32\67\339\34"+
		";\35=\36?\37A C!E\"G#I$K%M&O\'Q(S)U*W+Y,[-]._/a\60c\61\3\2\6\3\2\62;\5"+
		"\2\13\f\17\17\"\"\4\2C\\c|\5\2\62;C\\c|\2\u0192\2\3\3\2\2\2\2\5\3\2\2"+
		"\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\25"+
		"\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2"+
		"\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2"+
		"\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2\2\2\2\65\3\2\2\2\2\67\3"+
		"\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2\2\2\2A\3\2\2\2\2C\3\2\2"+
		"\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2\2M\3\2\2\2\2O\3\2\2\2\2"+
		"Q\3\2\2\2\2S\3\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2Y\3\2\2\2\2[\3\2\2\2\2]\3"+
		"\2\2\2\2_\3\2\2\2\2a\3\2\2\2\2c\3\2\2\2\3e\3\2\2\2\5k\3\2\2\2\7s\3\2\2"+
		"\2\t|\3\2\2\2\13\u0081\3\2\2\2\r\u008e\3\2\2\2\17\u0092\3\2\2\2\21\u009f"+
		"\3\2\2\2\23\u00be\3\2\2\2\25\u00c1\3\2\2\2\27\u00c7\3\2\2\2\31\u00d5\3"+
		"\2\2\2\33\u00db\3\2\2\2\35\u00e1\3\2\2\2\37\u00e6\3\2\2\2!\u00ed\3\2\2"+
		"\2#\u00f2\3\2\2\2%\u00fc\3\2\2\2\'\u0102\3\2\2\2)\u0107\3\2\2\2+\u010a"+
		"\3\2\2\2-\u010f\3\2\2\2/\u0116\3\2\2\2\61\u0121\3\2\2\2\63\u0127\3\2\2"+
		"\2\65\u0129\3\2\2\2\67\u0132\3\2\2\29\u0139\3\2\2\2;\u013e\3\2\2\2=\u0140"+
		"\3\2\2\2?\u0142\3\2\2\2A\u0144\3\2\2\2C\u0146\3\2\2\2E\u0148\3\2\2\2G"+
		"\u014a\3\2\2\2I\u014e\3\2\2\2K\u0153\3\2\2\2M\u0155\3\2\2\2O\u0157\3\2"+
		"\2\2Q\u0159\3\2\2\2S\u015c\3\2\2\2U\u015f\3\2\2\2W\u0162\3\2\2\2Y\u0164"+
		"\3\2\2\2[\u0166\3\2\2\2]\u0168\3\2\2\2_\u016a\3\2\2\2a\u0174\3\2\2\2c"+
		"\u0177\3\2\2\2ef\7Z\2\2fg\7o\2\2gh\7k\2\2hi\7p\2\2ij\7<\2\2j\4\3\2\2\2"+
		"kl\7O\2\2lm\7c\2\2mn\7e\2\2no\7j\2\2op\7k\2\2pq\7p\2\2qr\7g\2\2r\6\3\2"+
		"\2\2st\7Y\2\2tu\7q\2\2uv\7t\2\2vw\7m\2\2wx\7C\2\2xy\7t\2\2yz\7g\2\2z{"+
		"\7c\2\2{\b\3\2\2\2|}\7u\2\2}~\7k\2\2~\177\7|\2\2\177\u0080\7g\2\2\u0080"+
		"\n\3\2\2\2\u0081\u0082\7\60\2\2\u0082\u0083\7v\2\2\u0083\u0084\7q\2\2"+
		"\u0084\f\3\2\2\2\u0085\u0086\7v\2\2\u0086\u0087\7t\2\2\u0087\u0088\7w"+
		"\2\2\u0088\u008f\7g\2\2\u0089\u008a\7h\2\2\u008a\u008b\7c\2\2\u008b\u008c"+
		"\7n\2\2\u008c\u008d\7u\2\2\u008d\u008f\7g\2\2\u008e\u0085\3\2\2\2\u008e"+
		"\u0089\3\2\2\2\u008f\16\3\2\2\2\u0090\u0093\5\21\t\2\u0091\u0093\5\23"+
		"\n\2\u0092\u0090\3\2\2\2\u0092\u0091\3\2\2\2\u0093\20\3\2\2\2\u0094\u0096"+
		"\t\2\2\2\u0095\u0094\3\2\2\2\u0096\u0097\3\2\2\2\u0097\u0095\3\2\2\2\u0097"+
		"\u0098\3\2\2\2\u0098\u00a0\3\2\2\2\u0099\u009b\7/\2\2\u009a\u009c\t\2"+
		"\2\2\u009b\u009a\3\2\2\2\u009c\u009d\3\2\2\2\u009d\u009b\3\2\2\2\u009d"+
		"\u009e\3\2\2\2\u009e\u00a0\3\2\2\2\u009f\u0095\3\2\2\2\u009f\u0099\3\2"+
		"\2\2\u00a0\22\3\2\2\2\u00a1\u00a3\t\2\2\2\u00a2\u00a1\3\2\2\2\u00a3\u00a4"+
		"\3\2\2\2\u00a4\u00a2\3\2\2\2\u00a4\u00a5\3\2\2\2\u00a5\u00a6\3\2\2\2\u00a6"+
		"\u00a8\7\60\2\2\u00a7\u00a9\t\2\2\2\u00a8\u00a7\3\2\2\2\u00a9\u00aa\3"+
		"\2\2\2\u00aa\u00a8\3\2\2\2\u00aa\u00ab\3\2\2\2\u00ab\u00bf\3\2\2\2\u00ac"+
		"\u00ae\7/\2\2\u00ad\u00af\t\2\2\2\u00ae\u00ad\3\2\2\2\u00af\u00b0\3\2"+
		"\2\2\u00b0\u00ae\3\2\2\2\u00b0\u00b1\3\2\2\2\u00b1\u00bf\3\2\2\2\u00b2"+
		"\u00b4\7/\2\2\u00b3\u00b5\t\2\2\2\u00b4\u00b3\3\2\2\2\u00b5\u00b6\3\2"+
		"\2\2\u00b6\u00b4\3\2\2\2\u00b6\u00b7\3\2\2\2\u00b7\u00b8\3\2\2\2\u00b8"+
		"\u00ba\7\60\2\2\u00b9\u00bb\t\2\2\2\u00ba\u00b9\3\2\2\2\u00bb\u00bc\3"+
		"\2\2\2\u00bc\u00ba\3\2\2\2\u00bc\u00bd\3\2\2\2\u00bd\u00bf\3\2\2\2\u00be"+
		"\u00a2\3\2\2\2\u00be\u00ac\3\2\2\2\u00be\u00b2\3\2\2\2\u00bf\24\3\2\2"+
		"\2\u00c0\u00c2\t\3\2\2\u00c1\u00c0\3\2\2\2\u00c2\u00c3\3\2\2\2\u00c3\u00c1"+
		"\3\2\2\2\u00c3\u00c4\3\2\2\2\u00c4\u00c5\3\2\2\2\u00c5\u00c6\b\13\2\2"+
		"\u00c6\26\3\2\2\2\u00c7\u00c8\7\61\2\2\u00c8\u00c9\7,\2\2\u00c9\u00cd"+
		"\3\2\2\2\u00ca\u00cc\13\2\2\2\u00cb\u00ca\3\2\2\2\u00cc\u00cf\3\2\2\2"+
		"\u00cd\u00ce\3\2\2\2\u00cd\u00cb\3\2\2\2\u00ce\u00d0\3\2\2\2\u00cf\u00cd"+
		"\3\2\2\2\u00d0\u00d1\7,\2\2\u00d1\u00d2\7\61\2\2\u00d2\u00d3\3\2\2\2\u00d3"+
		"\u00d4\b\f\2\2\u00d4\30\3\2\2\2\u00d5\u00d6\7u\2\2\u00d6\u00d7\7j\2\2"+
		"\u00d7\u00d8\7c\2\2\u00d8\u00d9\7r\2\2\u00d9\u00da\7g\2\2\u00da\32\3\2"+
		"\2\2\u00db\u00dc\7r\2\2\u00dc\u00dd\7q\2\2\u00dd\u00de\7k\2\2\u00de\u00df"+
		"\7p\2\2\u00df\u00e0\7v\2\2\u00e0\34\3\2\2\2\u00e1\u00e2\7d\2\2\u00e2\u00e3"+
		"\7q\2\2\u00e3\u00e4\7q\2\2\u00e4\u00e5\7n\2\2\u00e5\36\3\2\2\2\u00e6\u00e7"+
		"\7p\2\2\u00e7\u00e8\7w\2\2\u00e8\u00e9\7o\2\2\u00e9\u00ea\7d\2\2\u00ea"+
		"\u00eb\7g\2\2\u00eb\u00ec\7t\2\2\u00ec \3\2\2\2\u00ed\u00ee\7f\2\2\u00ee"+
		"\u00ef\7t\2\2\u00ef\u00f0\7c\2\2\u00f0\u00f1\7y\2\2\u00f1\"\3\2\2\2\u00f2"+
		"\u00f3\7y\2\2\u00f3\u00f4\7k\2\2\u00f4\u00f5\7v\2\2\u00f5\u00f6\7j\2\2"+
		"\u00f6\u00f7\7C\2\2\u00f7\u00f8\7p\2\2\u00f8\u00f9\7i\2\2\u00f9\u00fa"+
		"\7n\2\2\u00fa\u00fb\7g\2\2\u00fb$\3\2\2\2\u00fc\u00fd\7e\2\2\u00fd\u00fe"+
		"\7w\2\2\u00fe\u00ff\7t\2\2\u00ff\u0100\7x\2\2\u0100\u0101\7g\2\2\u0101"+
		"&\3\2\2\2\u0102\u0103\7n\2\2\u0103\u0104\7k\2\2\u0104\u0105\7p\2\2\u0105"+
		"\u0106\7g\2\2\u0106(\3\2\2\2\u0107\u0108\7v\2\2\u0108\u0109\7q\2\2\u0109"+
		"*\3\2\2\2\u010a\u010b\7h\2\2\u010b\u010c\7t\2\2\u010c\u010d\7q\2\2\u010d"+
		"\u010e\7o\2\2\u010e,\3\2\2\2\u010f\u0110\7t\2\2\u0110\u0111\7g\2\2\u0111"+
		"\u0112\7r\2\2\u0112\u0113\7g\2\2\u0113\u0114\7c\2\2\u0114\u0115\7v\2\2"+
		"\u0115.\3\2\2\2\u0116\u0117\7t\2\2\u0117\u0118\7g\2\2\u0118\u0119\7r\2"+
		"\2\u0119\u011a\7g\2\2\u011a\u011b\7c\2\2\u011b\u011c\7v\2\2\u011c\u011d"+
		"\7\60\2\2\u011d\u011e\7g\2\2\u011e\u011f\7p\2\2\u011f\u0120\7f\2\2\u0120"+
		"\60\3\2\2\2\u0121\u0122\7w\2\2\u0122\u0123\7p\2\2\u0123\u0124\7v\2\2\u0124"+
		"\u0125\7k\2\2\u0125\u0126\7n\2\2\u0126\62\3\2\2\2\u0127\u0128\7\60\2\2"+
		"\u0128\64\3\2\2\2\u0129\u012a\7h\2\2\u012a\u012b\7w\2\2\u012b\u012c\7"+
		"p\2\2\u012c\u012d\7e\2\2\u012d\u012e\7v\2\2\u012e\u012f\7k\2\2\u012f\u0130"+
		"\7q\2\2\u0130\u0131\7p\2\2\u0131\66\3\2\2\2\u0132\u0133\7t\2\2\u0133\u0134"+
		"\7g\2\2\u0134\u0135\7v\2\2\u0135\u0136\7w\2\2\u0136\u0137\7t\2\2\u0137"+
		"\u0138\7p\2\2\u01388\3\2\2\2\u0139\u013a\7x\2\2\u013a\u013b\7q\2\2\u013b"+
		"\u013c\7k\2\2\u013c\u013d\7f\2\2\u013d:\3\2\2\2\u013e\u013f\7*\2\2\u013f"+
		"<\3\2\2\2\u0140\u0141\7+\2\2\u0141>\3\2\2\2\u0142\u0143\7-\2\2\u0143@"+
		"\3\2\2\2\u0144\u0145\7/\2\2\u0145B\3\2\2\2\u0146\u0147\7,\2\2\u0147D\3"+
		"\2\2\2\u0148\u0149\7\61\2\2\u0149F\3\2\2\2\u014a\u014b\7`\2\2\u014bH\3"+
		"\2\2\2\u014c\u014f\5S*\2\u014d\u014f\5U+\2\u014e\u014c\3\2\2\2\u014e\u014d"+
		"\3\2\2\2\u014fJ\3\2\2\2\u0150\u0154\5O(\2\u0151\u0154\5M\'\2\u0152\u0154"+
		"\5Q)\2\u0153\u0150\3\2\2\2\u0153\u0151\3\2\2\2\u0153\u0152\3\2\2\2\u0154"+
		"L\3\2\2\2\u0155\u0156\7@\2\2\u0156N\3\2\2\2\u0157\u0158\7>\2\2\u0158P"+
		"\3\2\2\2\u0159\u015a\7?\2\2\u015a\u015b\7?\2\2\u015bR\3\2\2\2\u015c\u015d"+
		"\7(\2\2\u015d\u015e\7(\2\2\u015eT\3\2\2\2\u015f\u0160\7~\2\2\u0160\u0161"+
		"\7~\2\2\u0161V\3\2\2\2\u0162\u0163\7?\2\2\u0163X\3\2\2\2\u0164\u0165\7"+
		"}\2\2\u0165Z\3\2\2\2\u0166\u0167\7\177\2\2\u0167\\\3\2\2\2\u0168\u0169"+
		"\7=\2\2\u0169^\3\2\2\2\u016a\u016b\7.\2\2\u016b`\3\2\2\2\u016c\u016d\5"+
		"c\62\2\u016d\u016e\7\60\2\2\u016e\u016f\7z\2\2\u016f\u0175\3\2\2\2\u0170"+
		"\u0171\5c\62\2\u0171\u0172\7\60\2\2\u0172\u0173\7{\2\2\u0173\u0175\3\2"+
		"\2\2\u0174\u016c\3\2\2\2\u0174\u0170\3\2\2\2\u0175b\3\2\2\2\u0176\u0178"+
		"\t\4\2\2\u0177\u0176\3\2\2\2\u0178\u0179\3\2\2\2\u0179\u0177\3\2\2\2\u0179"+
		"\u017a\3\2\2\2\u017a\u017e\3\2\2\2\u017b\u017d\t\5\2\2\u017c\u017b\3\2"+
		"\2\2\u017d\u0180\3\2\2\2\u017e\u017c\3\2\2\2\u017e\u017f\3\2\2\2\u017f"+
		"d\3\2\2\2\u0180\u017e\3\2\2\2\25\2\u008e\u0092\u0097\u009d\u009f\u00a4"+
		"\u00aa\u00b0\u00b6\u00bc\u00be\u00c3\u00cd\u014e\u0153\u0174\u0179\u017e"+
		"\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}