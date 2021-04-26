using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.WorkAreaNodes
{
    public abstract class MachineSettingNode : AstNode, IMachineSettingVisitable
    {
        // public WorkAreaSettingNode workAreaSettings { get; set; }

        public void Accept(IMachineSettingVisitor visitor)
        {
            visitor.Visit(this);
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}