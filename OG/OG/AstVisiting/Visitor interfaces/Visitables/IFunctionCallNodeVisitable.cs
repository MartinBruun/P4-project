namespace OG.AstVisiting
{
    public interface IFunctionCallNodeVisitable
    {
        public void Accept(IFunctionCallNodeVisitor visitor);

    }
}