using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Terminals
{
    public class TrueNode : BoolNode
    {
        public TrueNode(string value) : base(value, BoolType.TrueNode)
        {
        }
    }
}