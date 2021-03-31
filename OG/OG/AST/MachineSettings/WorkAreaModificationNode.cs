namespace OG.AST.MachineSettings
{
    public class WorkAreaModificationNode : MachineSettingNode
    {
        public SizePropertyNode SizeProperty { get; set; }
        
        public WorkAreaModificationNode()
        {
            
        }
        
        public WorkAreaModificationNode(SizePropertyNode sizeProperty)
        {
            SizeProperty = sizeProperty;
        }

        public override string ToString()
        {
            return "WorkAreaModifier with Properties:\n  " + SizeProperty.ToString();
        }
    }
}