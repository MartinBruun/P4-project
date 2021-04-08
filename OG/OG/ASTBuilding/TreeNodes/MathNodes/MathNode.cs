using OG.ASTBuilding.TreeNodes;

namespace OG.ASTBuilding.Terminals
{
    public class MathNode : ExpressionNode
    {
        public enum MathType
        {
            GenericMathNode = 0,
            GenericInfixNode,
            AdditionNode,
            SubtractionNode,
            DivisionNode,
            MultiplicationNode,
            PowerNode,
            NumberNode,
            FunctionCallNode,
            CoordinateXyValueNode,
            IdValueNode
        }

        public MathType MathNodeType { get; set; }

        public MathNode(string value, MathType mathNodeTypeOf):base(value, ExpressionType.MathExpression)
        {
            MathNodeType = mathNodeTypeOf;
        }
        
        public override string ToString()
        {
            return "Type: " + MathNodeType.ToString() + "\t Value: " + Value;
        }

  
    }
}