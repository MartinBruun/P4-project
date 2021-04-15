namespace OG.AstVisiting
{
    public interface IPointReferenceVisitable
    {
        public void Accept(IPointReferenceNodeVisitor visitor);
    }
}