using OG.ASTBuilding.TreeNodes.Boolean_nodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Terminals
{
    public class TrueNode : BoolTerminalNode
    {
        public TrueNode(string value) : base(value, BoolType.TrueNode)
        {
        }
    }
}