using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.WorkAreaNodes
{
    public class WorkAreaSettingNode : MachineSettingNode, IWorkAreaSettingNodeVisitable
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

        public void Accept(IWorkAreaSettingNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}