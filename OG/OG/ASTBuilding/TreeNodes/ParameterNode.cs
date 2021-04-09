using OG.ASTBuilding.TreeNodes;

namespace OG.ASTBuilding.Terminals
{
    public class ParameterNode : AstNode
    {
        public enum ParameterType
        {
            NotAssignedType=0,
            Id,
            FunctionCall,
            BoolExpression,
            MathExpressionNode,
            EndpointRef,
            StartPointRef,
            
        }

        public ParameterType ParamType { get; set; }
        /// <summary>
        /// ParameterId is set to null ParameterType is not Id.
        /// </summary>
        public IdNode ParameterId { get; set; } = null;

        /// <summary>
        /// Expression is set to null ParameterType is Id.
        /// </summary>
        public ValueNode Value { get; set; } = null;

        /// <summary>
        /// If we have an expression, it can by definition not be an Id reference.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="t"></param>
        public ParameterNode(ValueNode e, ParameterType t)
        {
            ParameterId = null;
            Value = e;
            ParamType = t;
        }
        
        /// <summary>
        /// Id parameter.
        /// </summary>
        /// <param name="id"></param>
        public ParameterNode(IdNode id)
        {
            Value = null;
            ParamType = ParameterType.Id;
            ParameterId = id;
        }
        
       

        public override string ToString()
        {
            if (ParameterId != null)
            {
                return ParameterId.ToString() + "Type of parameter: " + ParamType.ToString();
            } else if (Value != null)
            {
                return Value.ToString() + "Type of expression: " + ParamType.ToString();
            }

            return "Parameter does not contain id: " + ParamType.ToString();
        }
    }
}