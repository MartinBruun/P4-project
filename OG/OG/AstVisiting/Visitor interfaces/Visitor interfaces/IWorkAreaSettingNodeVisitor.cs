using OG.ASTBuilding.TreeNodes.WorkAreaNodes;

namespace OG.AstVisiting
{
    public interface IWorkAreaSettingNodeVisitor
    {
        public void Visit(WorkAreaSettingNode node);
    }
}