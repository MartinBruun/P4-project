// Generated from Hello.g4 by ANTLR 4.9.1

testGrammar dk.saxjax

import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class HelloLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, WS=16, IDENTIFIER=17, 
		NUMBER=18;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
			"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "WS", "IDENTIFIER", 
			"NUMBER"
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


	public HelloLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Hello.g4"; }

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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\24\u0084\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\3\2\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\4\3\4\3"+
		"\5\3\5\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7\3\b\3\b\3\t\3\t\3\n"+
		"\3\n\3\n\3\n\3\n\3\13\3\13\3\f\3\f\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16"+
		"\3\16\3\16\3\17\3\17\3\17\3\17\3\17\3\17\3\17\3\20\3\20\3\21\6\21c\n\21"+
		"\r\21\16\21d\3\21\3\21\3\22\6\22j\n\22\r\22\16\22k\3\23\6\23o\n\23\r\23"+
		"\16\23p\3\23\7\23t\n\23\f\23\16\23w\13\23\3\23\3\23\6\23{\n\23\r\23\16"+
		"\23|\3\23\7\23\u0080\n\23\f\23\16\23\u0083\13\23\2\2\24\3\3\5\4\7\5\t"+
		"\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23"+
		"%\24\3\2\6\5\2\13\f\17\17\"\"\5\2\62;C\\c|\3\2\63;\3\2\62;\2\u0089\2\3"+
		"\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2"+
		"\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31"+
		"\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2"+
		"\2%\3\2\2\2\3\'\3\2\2\2\5-\3\2\2\2\7\62\3\2\2\2\t\64\3\2\2\2\13\66\3\2"+
		"\2\2\r;\3\2\2\2\17A\3\2\2\2\21C\3\2\2\2\23E\3\2\2\2\25J\3\2\2\2\27L\3"+
		"\2\2\2\31N\3\2\2\2\33Q\3\2\2\2\35X\3\2\2\2\37_\3\2\2\2!b\3\2\2\2#i\3\2"+
		"\2\2%n\3\2\2\2\'(\7u\2\2()\7j\2\2)*\7c\2\2*+\7r\2\2+,\7g\2\2,\4\3\2\2"+
		"\2-.\7f\2\2./\7t\2\2/\60\7c\2\2\60\61\7y\2\2\61\6\3\2\2\2\62\63\7}\2\2"+
		"\63\b\3\2\2\2\64\65\7\177\2\2\65\n\3\2\2\2\66\67\7n\2\2\678\7k\2\289\7"+
		"p\2\29:\7g\2\2:\f\3\2\2\2;<\7e\2\2<=\7w\2\2=>\7t\2\2>?\7x\2\2?@\7g\2\2"+
		"@\16\3\2\2\2AB\7\60\2\2B\20\3\2\2\2CD\7=\2\2D\22\3\2\2\2EF\7h\2\2FG\7"+
		"t\2\2GH\7q\2\2HI\7o\2\2I\24\3\2\2\2JK\7*\2\2K\26\3\2\2\2LM\7+\2\2M\30"+
		"\3\2\2\2NO\7v\2\2OP\7q\2\2P\32\3\2\2\2QR\7t\2\2RS\7c\2\2ST\7f\2\2TU\7"+
		"k\2\2UV\7w\2\2VW\7u\2\2W\34\3\2\2\2XY\7t\2\2YZ\7q\2\2Z[\7v\2\2[\\\7c\2"+
		"\2\\]\7v\2\2]^\7g\2\2^\36\3\2\2\2_`\7.\2\2` \3\2\2\2ac\t\2\2\2ba\3\2\2"+
		"\2cd\3\2\2\2db\3\2\2\2de\3\2\2\2ef\3\2\2\2fg\b\21\2\2g\"\3\2\2\2hj\t\3"+
		"\2\2ih\3\2\2\2jk\3\2\2\2ki\3\2\2\2kl\3\2\2\2l$\3\2\2\2mo\t\4\2\2nm\3\2"+
		"\2\2op\3\2\2\2pn\3\2\2\2pq\3\2\2\2qu\3\2\2\2rt\t\5\2\2sr\3\2\2\2tw\3\2"+
		"\2\2us\3\2\2\2uv\3\2\2\2vx\3\2\2\2wu\3\2\2\2xz\7\60\2\2y{\t\5\2\2zy\3"+
		"\2\2\2{|\3\2\2\2|z\3\2\2\2|}\3\2\2\2}\u0081\3\2\2\2~\u0080\t\5\2\2\177"+
		"~\3\2\2\2\u0080\u0083\3\2\2\2\u0081\177\3\2\2\2\u0081\u0082\3\2\2\2\u0082"+
		"&\3\2\2\2\u0083\u0081\3\2\2\2\t\2dkpu|\u0081\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}