namespace OG.AstVisiting
{
    public interface IIdVisitable
    {
        public void Accept(IIdNodeVisitor visitor);
    }
}