using System.Collections.Generic;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class MathNode : ExpressionNode
    {
        
       
        public enum MathType
        {
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

    public interface IMathNode : IExpressionNode
    {
       
    }
    

}