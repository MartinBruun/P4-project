namespace OG.AstVisiting
{
    public interface ISizePropertyNodeVisitable
    {
        public void Accept(ISizePropertyVisitor visitor);
    }
}