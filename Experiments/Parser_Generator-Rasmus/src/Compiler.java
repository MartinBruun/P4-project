import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.CommonTokenStream;
import org.antlr.v4.runtime.tree.ParseTree;
import static org.antlr.v4.runtime.CharStreams.fromFileName;

import java.io.IOException;


public class Compiler
{
    public static void main(String[] args)
    {
        try
        {
            String sourceFile = "test.txt";
            CharStream charstream = fromFileName(sourceFile);

            mainGrammarLexer lexer = new mainGrammarLexer(charstream);

            CommonTokenStream token = new CommonTokenStream(lexer);

            mainGrammarParser parser = new mainGrammarParser(token);

            ParseTree tree = parser.pointReference(); //rule to start in

            ProgramVisitor visitor = new ProgramVisitor();

            visitor.visit(tree);



        }
        catch (IOException e)
        {
            e.printStackTrace();
        }

    }
}
