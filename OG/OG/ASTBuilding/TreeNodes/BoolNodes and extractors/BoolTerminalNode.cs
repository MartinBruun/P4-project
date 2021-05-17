namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public abstract class BoolTerminalNode : BoolNode
    {
        public BoolTerminalNode(string value, BoolType type) : base(value, type)
        {
        }
        public BoolTerminalNode(BoolTerminalNode node) : base(node)
        {
            
        }
    }
}