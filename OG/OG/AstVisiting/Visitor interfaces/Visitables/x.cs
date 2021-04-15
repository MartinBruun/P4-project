namespace OG.AstVisiting
{
    public interface IPropertyAssignmentVisitable
    {
        public void Accept(IPropertyAssignmentVisitor visitor);
    }

 
}