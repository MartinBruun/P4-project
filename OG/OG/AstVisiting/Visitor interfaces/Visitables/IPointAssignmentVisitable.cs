namespace OG.AstVisiting
{
    public interface IPointAssignmentVisitable
    {
        public void Accept(IPointReferenceAssignmentVisitor visitor);
    }
}