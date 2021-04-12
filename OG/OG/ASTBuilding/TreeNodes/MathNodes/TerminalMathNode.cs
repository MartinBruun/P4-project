namespace OG.ASTBuilding.Terminals
{
    public abstract class TerminalMathNode : MathNode
    {
        public TerminalMathNode(string value, MathType mathNodeTypeOf) : base(value, mathNodeTypeOf)
        {
        }
    }
}