using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.Terminals
{
    public class CoordinateXyValueNode : TerminalMathNode
    {
        public CoordinateXyValueNode(string value, MathType mathNodeTypeOf) : base(value, mathNodeTypeOf)
        {
        }
    }
}