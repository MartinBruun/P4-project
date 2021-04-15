namespace OG.AstVisiting
{
    public interface IBodyNodeVisitable
    {
        public void Accept(IBodyNodeVisitor visitor);
    }
}