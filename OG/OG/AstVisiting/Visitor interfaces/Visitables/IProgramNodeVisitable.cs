namespace OG.AstVisiting
{
    public interface IProgramNodeVisitable
    {
        public void Accept(IProgramVisitor visitor);
    }
}