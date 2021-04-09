namespace OG.ASTBuilding.Terminals
{
    public abstract class TerminalMathNode : MathNode
    {
        protected TerminalMathNode(string value, MathType mathNodeTypeOf) : base(value, mathNodeTypeOf)
        {
        }
        
        
    }
}