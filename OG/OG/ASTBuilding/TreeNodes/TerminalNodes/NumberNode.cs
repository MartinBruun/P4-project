using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
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