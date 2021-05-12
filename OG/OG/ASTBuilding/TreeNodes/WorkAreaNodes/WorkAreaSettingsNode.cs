using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.WorkAreaNodes
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
        
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
       
        }
    }
}