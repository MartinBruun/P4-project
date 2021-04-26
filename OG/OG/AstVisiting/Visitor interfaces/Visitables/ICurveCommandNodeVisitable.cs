namespace OG.AstVisiting
{
    public interface ICurveCommandNodeVisitable
    {
        public void Accept(ICurveCommandVisitor visitor);
    }
}