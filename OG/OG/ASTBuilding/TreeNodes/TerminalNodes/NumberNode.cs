using OG.ASTBuilding;

namespace OG.ASTBuilding.Terminals
{
    public class NumberNode: TerminalMathNode
    {
        public double NumberValue { get; set; }

        public NumberNode(double value):base(value.ToString(),MathType.NumberNode)
        {
            NumberValue = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}