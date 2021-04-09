using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Terminals
{
    public class FalseNode : BoolNode
    {
        public FalseNode(string value) : base(value,BoolType.FalseNode)
        {
        }
    }
}