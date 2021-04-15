namespace OG.AstVisiting
{
    public interface IShapeNodeVisitable
    {
        public void Accept(IShapeNodeVisitor visitor);
    }
}