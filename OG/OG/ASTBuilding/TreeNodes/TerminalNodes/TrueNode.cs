using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class TrueNode : BoolTerminalNode
    {
        public TrueNode(string value) : base(value, BoolType.TrueNode)
        {
        }
    }
}