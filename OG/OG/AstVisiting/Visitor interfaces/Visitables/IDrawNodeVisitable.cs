namespace OG.AstVisiting
{
    public interface IDrawNodeVisitable
    {
        public void Accept(IDrawNodeVisitor visitor);
    }
}