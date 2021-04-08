using OG.ASTBuilding.TreeNodes;

namespace OG.ASTBuilding.Terminals
{
    public class MathNode : ExpressionNode
    {
        public enum MathNodeType
        {
            GenericMathNode = 0,
            AdditionNode,
            SubtractionNode,
            DivisionNode,
            MultiplicationNode,
            PowerNode
        }

        public MathNodeType Type { get; set; } = MathNodeType.GenericMathNode;

        public MathNode(string value, MathNodeType typeOfNode):base(value)
        {
            Type = typeOfNode;
        }

        public MathNode()
        {
            
        }
    }
}