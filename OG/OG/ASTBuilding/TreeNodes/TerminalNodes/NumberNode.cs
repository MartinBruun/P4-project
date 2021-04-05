using OG.AST;

namespace OG.AST.Terminals
{
    public class NumberNode: MathNode
    {
        public float Value { get; set; }

        public NumberNode(float value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}