namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class TerminalMathNode : MathNode
    {
        public TerminalMathNode(string value, MathType mathNodeTypeOf) : base(value, mathNodeTypeOf)
        {
        }

        public TerminalMathNode(TerminalMathNode node) : base(node)
        {
            
        }
    }

    
    
}