namespace OG.AstVisiting
{
    public interface IMachineSettingVisitor : ISizePropertyVisitor, IWorkAreaSettingNodeVisitor
    {
        void Visit(IMachineSettingVisitable node);
    }

}