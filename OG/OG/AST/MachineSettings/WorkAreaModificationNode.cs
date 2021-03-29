namespace OG.AST.MachineSettings
{
    public class WorkAreaModificationNode : MachineSettingNode
    {
        public SizePropertyNode SizeProperty { get; set; }

        public void Initialize(SizePropertyNode sizeProperty)
        {
            SizeProperty = sizeProperty;
        }
        
        public WorkAreaModificationNode()
        {
            Initialize(new SizePropertyNode());
        }
        
        public WorkAreaModificationNode(SizePropertyNode sizeProperty)
        {
            Initialize(sizeProperty);
        }

        public override string ToString()
        {
            return "  WorkAreaModifier with Properties:\n" + SizeProperty.ToString();
        }
    }
}