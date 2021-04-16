namespace OG.AstVisiting
{
    public interface IIdAssignVisitable
    {
        public void Accept(IIdAssignmentVisitor visitor);
    }
}