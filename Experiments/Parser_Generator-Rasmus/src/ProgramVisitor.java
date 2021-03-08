public class ProgramVisitor extends mainGrammarBaseVisitor<Object>
{
    @Override
    public Object visitPointReference(mainGrammarParser.PointReferenceContext ctx)
    {
        System.out.println("GO");
        return super.visitPointReference(ctx);
    }
}
