namespace OG.AstVisiting
{
    public interface ILineCommandNodeVisitable
    {
        public void Accept(ILineCommandNodeVisitor visitor);
    }
}