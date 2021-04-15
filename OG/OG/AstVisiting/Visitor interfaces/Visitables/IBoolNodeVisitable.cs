namespace OG.AstVisiting
{
    public interface IBoolNodeVisitable
    {
        public void Accept(IBoolNodeVisitor visitor);
    }
}