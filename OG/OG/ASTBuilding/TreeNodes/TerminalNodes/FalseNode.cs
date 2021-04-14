using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class FalseNode : BoolTerminalNode
    {
        public FalseNode(string value) : base(value,BoolType.FalseNode)
        {
        }
    }
}