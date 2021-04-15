namespace OG.AstVisiting
{
    public interface IUntilNodeVisitable
    {
        public void Accept(IUntilNodeVisitor visitor);
    }
}