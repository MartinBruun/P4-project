namespace OG.AstVisiting
{
    public interface IUntilFunctionCallVisitable
    {
        public void Accept(IUntilNodeVisitor visitor);
    }
}