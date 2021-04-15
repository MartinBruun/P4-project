namespace OG.AstVisiting
{
    public interface IMathNodeVisitable
    {
        public void Accept(IMathNodeVisitor visitor);
    }
}