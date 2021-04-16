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
		T__0=1, T__1=2, T__2=3, T__3=4, Number=5, BooleanValue=6, WS=7, COMMENT=8, 
		ShapeDCLWord=9, PointDCLWord=10, BoolDCLWord=11, NumberDCLWord=12, DrawDCLWord=13, 
		WithAngle=14, Curve=15, Line=16, To=17, From=18, RepeatStart=19, RepeatEnd=20, 
		Until=21, DOT=22, FunctionStartWord=23, FunctionReturnWord=24, Void=25, 
		LParen=26, RParen=27, Plus_Minus=28, Plus=29, Minus=30, Mul_Div=31, Times=32, 
		Div=33, Pow=34, LogicOperator=35, BoolOperator=36, NOT=37, Assign=38, 
		OpenScope=39, CloseScope=40, Terminator=41, Seperator=42, XMIN=43, XMAX=44, 
		YMAX=45, YMIN=46, Machine=47, WorkArea=48, Size=49, If=50, Then=51, ID=52;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "Number", "BooleanValue", "Integer", 
			"Float", "WS", "COMMENT", "ShapeDCLWord", "PointDCLWord", "BoolDCLWord", 
			"NumberDCLWord", "DrawDCLWord", "WithAngle", "Curve", "Line", "To", "From", 
			"RepeatStart", "RepeatEnd", "Until", "DOT", "FunctionStartWord", "FunctionReturnWord", 
			"Void", "LParen", "RParen", "Plus_Minus", "Plus", "Minus", "Mul_Div", 
			"Times", "Div", "Pow", "LogicOperator", "BoolOperator", "GT", "LT", "EQ", 
			"AND", "NOT", "OR", "Assign", "OpenScope", "CloseScope", "Terminator", 
			"Seperator", "XMIN", "XMAX", "YMAX", "YMIN", "Machine", "WorkArea", "Size", 
			"If", "Then", "ID"
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\66\u01c1\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t"+
		" \4!\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t"+
		"+\4,\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64"+
		"\t\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\3\2"+
		"\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3"+
		"\3\3\3\3\4\3\4\3\4\3\5\3\5\3\5\3\6\3\6\5\6\u0096\n\6\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\3\7\3\7\5\7\u00a1\n\7\3\b\6\b\u00a4\n\b\r\b\16\b\u00a5\3\b"+
		"\3\b\6\b\u00aa\n\b\r\b\16\b\u00ab\5\b\u00ae\n\b\3\t\6\t\u00b1\n\t\r\t"+
		"\16\t\u00b2\3\t\3\t\6\t\u00b7\n\t\r\t\16\t\u00b8\3\t\3\t\6\t\u00bd\n\t"+
		"\r\t\16\t\u00be\3\t\3\t\6\t\u00c3\n\t\r\t\16\t\u00c4\3\t\3\t\6\t\u00c9"+
		"\n\t\r\t\16\t\u00ca\5\t\u00cd\n\t\3\n\6\n\u00d0\n\n\r\n\16\n\u00d1\3\n"+
		"\3\n\3\13\3\13\3\13\3\13\7\13\u00da\n\13\f\13\16\13\u00dd\13\13\3\13\3"+
		"\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3\r\3\16"+
		"\3\16\3\16\3\16\3\16\3\17\3\17\3\17\3\17\3\17\3\17\3\17\3\20\3\20\3\20"+
		"\3\20\3\20\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\22\3\22"+
		"\3\22\3\22\3\22\3\22\3\23\3\23\3\23\3\23\3\23\3\24\3\24\3\24\3\25\3\25"+
		"\3\25\3\25\3\25\3\26\3\26\3\26\3\26\3\26\3\26\3\26\3\27\3\27\3\27\3\27"+
		"\3\27\3\27\3\27\3\27\3\27\3\27\3\27\3\30\3\30\3\30\3\30\3\30\3\30\3\31"+
		"\3\31\3\32\3\32\3\32\3\32\3\32\3\32\3\32\3\32\3\32\3\33\3\33\3\33\3\33"+
		"\3\33\3\33\3\33\3\34\3\34\3\34\3\34\3\34\3\35\3\35\3\36\3\36\3\37\3\37"+
		"\5\37\u0153\n\37\3 \3 \3!\3!\3\"\3\"\5\"\u015b\n\"\3#\3#\3$\3$\3%\3%\3"+
		"&\3&\5&\u0165\n&\3\'\3\'\3\'\5\'\u016a\n\'\3(\3(\3)\3)\3*\3*\3*\3+\3+"+
		"\3+\3,\3,\3-\3-\3-\3.\3.\3/\3/\3\60\3\60\3\61\3\61\3\62\3\62\3\63\3\63"+
		"\3\63\3\63\3\63\3\64\3\64\3\64\3\64\3\64\3\65\3\65\3\65\3\65\3\65\3\66"+
		"\3\66\3\66\3\66\3\66\3\67\3\67\3\67\3\67\3\67\3\67\3\67\3\67\38\38\38"+
		"\38\38\38\38\38\38\39\39\39\39\39\3:\3:\3:\3;\3;\3;\3;\3;\3<\6<\u01b8"+
		"\n<\r<\16<\u01b9\3<\7<\u01bd\n<\f<\16<\u01c0\13<\3\u00db\2=\3\3\5\4\7"+
		"\5\t\6\13\7\r\b\17\2\21\2\23\t\25\n\27\13\31\f\33\r\35\16\37\17!\20#\21"+
		"%\22\'\23)\24+\25-\26/\27\61\30\63\31\65\32\67\339\34;\35=\36?\37A C!"+
		"E\"G#I$K%M&O\2Q\2S\2U\2W\'Y\2[(])_*a+c,e-g.i/k\60m\61o\62q\63s\64u\65"+
		"w\66\3\2\6\3\2\62;\5\2\13\f\17\17\"\"\4\2C\\c|\5\2\62;C\\c|\2\u01ce\2"+
		"\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2"+
		"\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2"+
		"\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2\2"+
		"\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2\2\2"+
		"\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2\2\2"+
		"\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2\2M"+
		"\3\2\2\2\2W\3\2\2\2\2[\3\2\2\2\2]\3\2\2\2\2_\3\2\2\2\2a\3\2\2\2\2c\3\2"+
		"\2\2\2e\3\2\2\2\2g\3\2\2\2\2i\3\2\2\2\2k\3\2\2\2\2m\3\2\2\2\2o\3\2\2\2"+
		"\2q\3\2\2\2\2s\3\2\2\2\2u\3\2\2\2\2w\3\2\2\2\3y\3\2\2\2\5\u0084\3\2\2"+
		"\2\7\u008d\3\2\2\2\t\u0090\3\2\2\2\13\u0095\3\2\2\2\r\u00a0\3\2\2\2\17"+
		"\u00ad\3\2\2\2\21\u00cc\3\2\2\2\23\u00cf\3\2\2\2\25\u00d5\3\2\2\2\27\u00e3"+
		"\3\2\2\2\31\u00e9\3\2\2\2\33\u00ef\3\2\2\2\35\u00f4\3\2\2\2\37\u00fb\3"+
		"\2\2\2!\u0100\3\2\2\2#\u010a\3\2\2\2%\u0110\3\2\2\2\'\u0115\3\2\2\2)\u0118"+
		"\3\2\2\2+\u011d\3\2\2\2-\u0124\3\2\2\2/\u012f\3\2\2\2\61\u0135\3\2\2\2"+
		"\63\u0137\3\2\2\2\65\u0140\3\2\2\2\67\u0147\3\2\2\29\u014c\3\2\2\2;\u014e"+
		"\3\2\2\2=\u0152\3\2\2\2?\u0154\3\2\2\2A\u0156\3\2\2\2C\u015a\3\2\2\2E"+
		"\u015c\3\2\2\2G\u015e\3\2\2\2I\u0160\3\2\2\2K\u0164\3\2\2\2M\u0169\3\2"+
		"\2\2O\u016b\3\2\2\2Q\u016d\3\2\2\2S\u016f\3\2\2\2U\u0172\3\2\2\2W\u0175"+
		"\3\2\2\2Y\u0177\3\2\2\2[\u017a\3\2\2\2]\u017c\3\2\2\2_\u017e\3\2\2\2a"+
		"\u0180\3\2\2\2c\u0182\3\2\2\2e\u0184\3\2\2\2g\u0189\3\2\2\2i\u018e\3\2"+
		"\2\2k\u0193\3\2\2\2m\u0198\3\2\2\2o\u01a0\3\2\2\2q\u01a9\3\2\2\2s\u01ae"+
		"\3\2\2\2u\u01b1\3\2\2\2w\u01b7\3\2\2\2yz\7u\2\2z{\7v\2\2{|\7c\2\2|}\7"+
		"t\2\2}~\7v\2\2~\177\7R\2\2\177\u0080\7q\2\2\u0080\u0081\7k\2\2\u0081\u0082"+
		"\7p\2\2\u0082\u0083\7v\2\2\u0083\4\3\2\2\2\u0084\u0085\7g\2\2\u0085\u0086"+
		"\7p\2\2\u0086\u0087\7f\2\2\u0087\u0088\7R\2\2\u0088\u0089\7q\2\2\u0089"+
		"\u008a\7k\2\2\u008a\u008b\7p\2\2\u008b\u008c\7v\2\2\u008c\6\3\2\2\2\u008d"+
		"\u008e\7\60\2\2\u008e\u008f\7z\2\2\u008f\b\3\2\2\2\u0090\u0091\7\60\2"+
		"\2\u0091\u0092\7{\2\2\u0092\n\3\2\2\2\u0093\u0096\5\17\b\2\u0094\u0096"+
		"\5\21\t\2\u0095\u0093\3\2\2\2\u0095\u0094\3\2\2\2\u0096\f\3\2\2\2\u0097"+
		"\u0098\7v\2\2\u0098\u0099\7t\2\2\u0099\u009a\7w\2\2\u009a\u00a1\7g\2\2"+
		"\u009b\u009c\7h\2\2\u009c\u009d\7c\2\2\u009d\u009e\7n\2\2\u009e\u009f"+
		"\7u\2\2\u009f\u00a1\7g\2\2\u00a0\u0097\3\2\2\2\u00a0\u009b\3\2\2\2\u00a1"+
		"\16\3\2\2\2\u00a2\u00a4\t\2\2\2\u00a3\u00a2\3\2\2\2\u00a4\u00a5\3\2\2"+
		"\2\u00a5\u00a3\3\2\2\2\u00a5\u00a6\3\2\2\2\u00a6\u00ae\3\2\2\2\u00a7\u00a9"+
		"\7/\2\2\u00a8\u00aa\t\2\2\2\u00a9\u00a8\3\2\2\2\u00aa\u00ab\3\2\2\2\u00ab"+
		"\u00a9\3\2\2\2\u00ab\u00ac\3\2\2\2\u00ac\u00ae\3\2\2\2\u00ad\u00a3\3\2"+
		"\2\2\u00ad\u00a7\3\2\2\2\u00ae\20\3\2\2\2\u00af\u00b1\t\2\2\2\u00b0\u00af"+
		"\3\2\2\2\u00b1\u00b2\3\2\2\2\u00b2\u00b0\3\2\2\2\u00b2\u00b3\3\2\2\2\u00b3"+
		"\u00b4\3\2\2\2\u00b4\u00b6\7\60\2\2\u00b5\u00b7\t\2\2\2\u00b6\u00b5\3"+
		"\2\2\2\u00b7\u00b8\3\2\2\2\u00b8\u00b6\3\2\2\2\u00b8\u00b9\3\2\2\2\u00b9"+
		"\u00cd\3\2\2\2\u00ba\u00bc\7/\2\2\u00bb\u00bd\t\2\2\2\u00bc\u00bb\3\2"+
		"\2\2\u00bd\u00be\3\2\2\2\u00be\u00bc\3\2\2\2\u00be\u00bf\3\2\2\2\u00bf"+
		"\u00cd\3\2\2\2\u00c0\u00c2\7/\2\2\u00c1\u00c3\t\2\2\2\u00c2\u00c1\3\2"+
		"\2\2\u00c3\u00c4\3\2\2\2\u00c4\u00c2\3\2\2\2\u00c4\u00c5\3\2\2\2\u00c5"+
		"\u00c6\3\2\2\2\u00c6\u00c8\7\60\2\2\u00c7\u00c9\t\2\2\2\u00c8\u00c7\3"+
		"\2\2\2\u00c9\u00ca\3\2\2\2\u00ca\u00c8\3\2\2\2\u00ca\u00cb\3\2\2\2\u00cb"+
		"\u00cd\3\2\2\2\u00cc\u00b0\3\2\2\2\u00cc\u00ba\3\2\2\2\u00cc\u00c0\3\2"+
		"\2\2\u00cd\22\3\2\2\2\u00ce\u00d0\t\3\2\2\u00cf\u00ce\3\2\2\2\u00d0\u00d1"+
		"\3\2\2\2\u00d1\u00cf\3\2\2\2\u00d1\u00d2\3\2\2\2\u00d2\u00d3\3\2\2\2\u00d3"+
		"\u00d4\b\n\2\2\u00d4\24\3\2\2\2\u00d5\u00d6\7\61\2\2\u00d6\u00d7\7,\2"+
		"\2\u00d7\u00db\3\2\2\2\u00d8\u00da\13\2\2\2\u00d9\u00d8\3\2\2\2\u00da"+
		"\u00dd\3\2\2\2\u00db\u00dc\3\2\2\2\u00db\u00d9\3\2\2\2\u00dc\u00de\3\2"+
		"\2\2\u00dd\u00db\3\2\2\2\u00de\u00df\7,\2\2\u00df\u00e0\7\61\2\2\u00e0"+
		"\u00e1\3\2\2\2\u00e1\u00e2\b\13\2\2\u00e2\26\3\2\2\2\u00e3\u00e4\7u\2"+
		"\2\u00e4\u00e5\7j\2\2\u00e5\u00e6\7c\2\2\u00e6\u00e7\7r\2\2\u00e7\u00e8"+
		"\7g\2\2\u00e8\30\3\2\2\2\u00e9\u00ea\7r\2\2\u00ea\u00eb\7q\2\2\u00eb\u00ec"+
		"\7k\2\2\u00ec\u00ed\7p\2\2\u00ed\u00ee\7v\2\2\u00ee\32\3\2\2\2\u00ef\u00f0"+
		"\7d\2\2\u00f0\u00f1\7q\2\2\u00f1\u00f2\7q\2\2\u00f2\u00f3\7n\2\2\u00f3"+
		"\34\3\2\2\2\u00f4\u00f5\7p\2\2\u00f5\u00f6\7w\2\2\u00f6\u00f7\7o\2\2\u00f7"+
		"\u00f8\7d\2\2\u00f8\u00f9\7g\2\2\u00f9\u00fa\7t\2\2\u00fa\36\3\2\2\2\u00fb"+
		"\u00fc\7f\2\2\u00fc\u00fd\7t\2\2\u00fd\u00fe\7c\2\2\u00fe\u00ff\7y\2\2"+
		"\u00ff \3\2\2\2\u0100\u0101\7y\2\2\u0101\u0102\7k\2\2\u0102\u0103\7v\2"+
		"\2\u0103\u0104\7j\2\2\u0104\u0105\7C\2\2\u0105\u0106\7p\2\2\u0106\u0107"+
		"\7i\2\2\u0107\u0108\7n\2\2\u0108\u0109\7g\2\2\u0109\"\3\2\2\2\u010a\u010b"+
		"\7e\2\2\u010b\u010c\7w\2\2\u010c\u010d\7t\2\2\u010d\u010e\7x\2\2\u010e"+
		"\u010f\7g\2\2\u010f$\3\2\2\2\u0110\u0111\7n\2\2\u0111\u0112\7k\2\2\u0112"+
		"\u0113\7p\2\2\u0113\u0114\7g\2\2\u0114&\3\2\2\2\u0115\u0116\7v\2\2\u0116"+
		"\u0117\7q\2\2\u0117(\3\2\2\2\u0118\u0119\7h\2\2\u0119\u011a\7t\2\2\u011a"+
		"\u011b\7q\2\2\u011b\u011c\7o\2\2\u011c*\3\2\2\2\u011d\u011e\7t\2\2\u011e"+
		"\u011f\7g\2\2\u011f\u0120\7r\2\2\u0120\u0121\7g\2\2\u0121\u0122\7c\2\2"+
		"\u0122\u0123\7v\2\2\u0123,\3\2\2\2\u0124\u0125\7t\2\2\u0125\u0126\7g\2"+
		"\2\u0126\u0127\7r\2\2\u0127\u0128\7g\2\2\u0128\u0129\7c\2\2\u0129\u012a"+
		"\7v\2\2\u012a\u012b\7\60\2\2\u012b\u012c\7g\2\2\u012c\u012d\7p\2\2\u012d"+
		"\u012e\7f\2\2\u012e.\3\2\2\2\u012f\u0130\7w\2\2\u0130\u0131\7p\2\2\u0131"+
		"\u0132\7v\2\2\u0132\u0133\7k\2\2\u0133\u0134\7n\2\2\u0134\60\3\2\2\2\u0135"+
		"\u0136\7\60\2\2\u0136\62\3\2\2\2\u0137\u0138\7h\2\2\u0138\u0139\7w\2\2"+
		"\u0139\u013a\7p\2\2\u013a\u013b\7e\2\2\u013b\u013c\7v\2\2\u013c\u013d"+
		"\7k\2\2\u013d\u013e\7q\2\2\u013e\u013f\7p\2\2\u013f\64\3\2\2\2\u0140\u0141"+
		"\7t\2\2\u0141\u0142\7g\2\2\u0142\u0143\7v\2\2\u0143\u0144\7w\2\2\u0144"+
		"\u0145\7t\2\2\u0145\u0146\7p\2\2\u0146\66\3\2\2\2\u0147\u0148\7x\2\2\u0148"+
		"\u0149\7q\2\2\u0149\u014a\7k\2\2\u014a\u014b\7f\2\2\u014b8\3\2\2\2\u014c"+
		"\u014d\7*\2\2\u014d:\3\2\2\2\u014e\u014f\7+\2\2\u014f<\3\2\2\2\u0150\u0153"+
		"\5? \2\u0151\u0153\5A!\2\u0152\u0150\3\2\2\2\u0152\u0151\3\2\2\2\u0153"+
		">\3\2\2\2\u0154\u0155\7-\2\2\u0155@\3\2\2\2\u0156\u0157\7/\2\2\u0157B"+
		"\3\2\2\2\u0158\u015b\5E#\2\u0159\u015b\5G$\2\u015a\u0158\3\2\2\2\u015a"+
		"\u0159\3\2\2\2\u015bD\3\2\2\2\u015c\u015d\7,\2\2\u015dF\3\2\2\2\u015e"+
		"\u015f\7\61\2\2\u015fH\3\2\2\2\u0160\u0161\7`\2\2\u0161J\3\2\2\2\u0162"+
		"\u0165\5U+\2\u0163\u0165\5Y-\2\u0164\u0162\3\2\2\2\u0164\u0163\3\2\2\2"+
		"\u0165L\3\2\2\2\u0166\u016a\5Q)\2\u0167\u016a\5O(\2\u0168\u016a\5S*\2"+
		"\u0169\u0166\3\2\2\2\u0169\u0167\3\2\2\2\u0169\u0168\3\2\2\2\u016aN\3"+
		"\2\2\2\u016b\u016c\7@\2\2\u016cP\3\2\2\2\u016d\u016e\7>\2\2\u016eR\3\2"+
		"\2\2\u016f\u0170\7?\2\2\u0170\u0171\7?\2\2\u0171T\3\2\2\2\u0172\u0173"+
		"\7(\2\2\u0173\u0174\7(\2\2\u0174V\3\2\2\2\u0175\u0176\7#\2\2\u0176X\3"+
		"\2\2\2\u0177\u0178\7~\2\2\u0178\u0179\7~\2\2\u0179Z\3\2\2\2\u017a\u017b"+
		"\7?\2\2\u017b\\\3\2\2\2\u017c\u017d\7}\2\2\u017d^\3\2\2\2\u017e\u017f"+
		"\7\177\2\2\u017f`\3\2\2\2\u0180\u0181\7=\2\2\u0181b\3\2\2\2\u0182\u0183"+
		"\7.\2\2\u0183d\3\2\2\2\u0184\u0185\7z\2\2\u0185\u0186\7o\2\2\u0186\u0187"+
		"\7k\2\2\u0187\u0188\7p\2\2\u0188f\3\2\2\2\u0189\u018a\7z\2\2\u018a\u018b"+
		"\7o\2\2\u018b\u018c\7c\2\2\u018c\u018d\7z\2\2\u018dh\3\2\2\2\u018e\u018f"+
		"\7{\2\2\u018f\u0190\7o\2\2\u0190\u0191\7k\2\2\u0191\u0192\7p\2\2\u0192"+
		"j\3\2\2\2\u0193\u0194\7{\2\2\u0194\u0195\7o\2\2\u0195\u0196\7c\2\2\u0196"+
		"\u0197\7z\2\2\u0197l\3\2\2\2\u0198\u0199\7O\2\2\u0199\u019a\7c\2\2\u019a"+
		"\u019b\7e\2\2\u019b\u019c\7j\2\2\u019c\u019d\7k\2\2\u019d\u019e\7p\2\2"+
		"\u019e\u019f\7g\2\2\u019fn\3\2\2\2\u01a0\u01a1\7Y\2\2\u01a1\u01a2\7q\2"+
		"\2\u01a2\u01a3\7t\2\2\u01a3\u01a4\7m\2\2\u01a4\u01a5\7C\2\2\u01a5\u01a6"+
		"\7t\2\2\u01a6\u01a7\7g\2\2\u01a7\u01a8\7c\2\2\u01a8p\3\2\2\2\u01a9\u01aa"+
		"\7u\2\2\u01aa\u01ab\7k\2\2\u01ab\u01ac\7|\2\2\u01ac\u01ad\7g\2\2\u01ad"+
		"r\3\2\2\2\u01ae\u01af\7k\2\2\u01af\u01b0\7h\2\2\u01b0t\3\2\2\2\u01b1\u01b2"+
		"\7v\2\2\u01b2\u01b3\7j\2\2\u01b3\u01b4\7g\2\2\u01b4\u01b5\7p\2\2\u01b5"+
		"v\3\2\2\2\u01b6\u01b8\t\4\2\2\u01b7\u01b6\3\2\2\2\u01b8\u01b9\3\2\2\2"+
		"\u01b9\u01b7\3\2\2\2\u01b9\u01ba\3\2\2\2\u01ba\u01be\3\2\2\2\u01bb\u01bd"+
		"\t\5\2\2\u01bc\u01bb\3\2\2\2\u01bd\u01c0\3\2\2\2\u01be\u01bc\3\2\2\2\u01be"+
		"\u01bf\3\2\2\2\u01bfx\3\2\2\2\u01c0\u01be\3\2\2\2\26\2\u0095\u00a0\u00a5"+
		"\u00ab\u00ad\u00b2\u00b8\u00be\u00c4\u00ca\u00cc\u00d1\u00db\u0152\u015a"+
		"\u0164\u0169\u01b9\u01be\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}