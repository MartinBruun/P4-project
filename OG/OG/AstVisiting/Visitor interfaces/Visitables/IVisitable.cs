namespace OG.AstVisiting
{
    public interface IVisitable
    {
        public abstract void Accept(IVisitor visitor);
    }
}