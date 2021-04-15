namespace OG.AstVisiting
{
    public interface IMachineSettingVisitable
    {
        public void Accept(IMachineSettingVisitor visitor);
        
    }
}