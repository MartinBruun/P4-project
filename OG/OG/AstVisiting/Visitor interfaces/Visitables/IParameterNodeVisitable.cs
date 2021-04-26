namespace OG.AstVisiting
{
    public interface IParameterNodeVisitable
    {
        public void Accept(IParameterNodeVisitor visitor);
    }
}