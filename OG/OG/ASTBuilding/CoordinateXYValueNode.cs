using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.Terminals
{
    public class CoordinateXyValueNode : TerminalMathNode, ICoordinateXyVisitable
    {
        public CoordinateXyValueNode(string value, MathType mathNodeTypeOf) : base(value, mathNodeTypeOf)
        {
        }

        public void Accept(ICoordinateXyVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}