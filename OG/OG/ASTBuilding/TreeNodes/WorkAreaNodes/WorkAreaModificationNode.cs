namespace OG.AST.MachineSettings
{
    public class WorkAreaSettingNode : MachineSettingNode
    {
        public SizePropertyNode SizeProperty { get; set; }
        
        public WorkAreaSettingNode()
        {
            
        }
        
        public WorkAreaSettingNode(SizePropertyNode sizeProperty)
        {
            SizeProperty = sizeProperty;
        }

        public override string ToString()
        {
            return "WorkAreaModifier with Properties:\n  " + SizeProperty.ToString();
        }
    }
}