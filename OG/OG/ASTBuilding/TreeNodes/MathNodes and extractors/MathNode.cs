using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.CodeGeneration;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class MathNode : ExpressionNode, IMathVisitable
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
        public MathType MathNodeType { get; private set; }


        public MathNode(string value, MathType mathNodeTypeOf):base(value, ExpressionType.MathExpression)
        {
            MathNodeType = mathNodeTypeOf;
        }
        
        public override string ToString()
        {
            return "Type: " + MathNodeType.ToString() + "\t Value: " + Value;
        }
        
        public abstract  NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor);
        
      
    }



    
    public interface IMathVisitable
    {
        public abstract NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor);
    }
}