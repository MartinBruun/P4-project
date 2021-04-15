namespace OG.AstVisiting
{
    public interface IWorkAreaSettingNodeVisitable: IMachineSettingVisitable
    {
        public void Accept(IWorkAreaSettingNodeVisitor visitor);
    }
}