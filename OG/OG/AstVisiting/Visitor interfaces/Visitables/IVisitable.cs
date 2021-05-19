namespace OG.AstVisiting
{
    public interface IVisitable
    {
        public abstract object Accept(IVisitor visitor);
    }
}