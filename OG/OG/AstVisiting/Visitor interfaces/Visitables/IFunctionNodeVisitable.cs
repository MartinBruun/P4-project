namespace OG.AstVisiting
{
    public interface IFunctionNodeVisitable
    {
        public void Accept(IFunctionNodeVisitor visitor);
    }
}