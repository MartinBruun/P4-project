namespace OG.AstVisiting
{
    public interface IBoolAssignmentVisitable
    {
        public void Accept(IBoolAssignmentVisitor visitor);
    }
}