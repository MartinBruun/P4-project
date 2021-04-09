using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.TreeNodes.Boolean_nodes_and_extractors
{
    public abstract class BoolTerminalNode : BoolNode
    {
        public BoolTerminalNode(string value, BoolType type) : base(value, type)
        {
        }
    }
}