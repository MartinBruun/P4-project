namespace OG.AstVisiting
{
    public interface IMathAssignmentVisitable
    {
        public void Accept(IMathAssignmentVisitor visitor);
    }
}