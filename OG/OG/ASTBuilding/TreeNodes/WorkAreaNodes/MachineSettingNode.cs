using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.WorkAreaNodes
{
    public abstract class MachineSettingNode : AstNode
    {
        public MachineSettingNode()
        {
            
        }
        public MachineSettingNode(MachineSettingNode node) : base(node)
        {

        }
    }
}