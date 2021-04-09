using OG.ASTBuilding.TreeNodes.Boolean_nodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Terminals
{
    public class FalseNode : BoolTerminalNode
    {
        public FalseNode(string value) : base(value,BoolType.FalseNode)
        {
        }
    }
}