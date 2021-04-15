namespace OG.AstVisiting
{
    public interface IWorkAreaSettingNodeVisitable
    {
        public void Accept(IWorkAreaSettingNodeVisitor visitor);
    }
}