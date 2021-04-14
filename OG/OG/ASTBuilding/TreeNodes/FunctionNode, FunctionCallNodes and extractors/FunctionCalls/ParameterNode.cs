using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
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
        public ExpressionNode Expression { get; set; } = null;

        /// <summary>
        /// If we have an expression, it can by definition not be an Id reference.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="t"></param>
        public ParameterNode(ExpressionNode e, ParameterType t)
        {
            ParameterId = null;
            Expression = e;
            ParamType = t;
        }
        
        /// <summary>
        /// Id parameter.
        /// </summary>
        /// <param name="id"></param>
        public ParameterNode(IdNode id)
        {
            Expression = null;
            ParamType = ParameterType.Id;
            ParameterId = id;
        }

        public ParameterNode(IdNode id, PointReferenceNode startPoint)
        {
            ParameterId = id;
            Expression = startPoint;
        }
        
       

        public override string ToString()
        {
            if (ParameterId != null)
            {
                return ParameterId.ToString() + "Type of parameter: " + ParamType.ToString();
            } else if (Expression != null)
            {
                return Expression.ToString() + "Type of expression: " + ParamType.ToString();
            }

            return "Parameter does not contain id: " + ParamType.ToString();
        }
    }

    public interface IParameterNode
    {
        public IExpressionNode Expression { get; set; }        
    }

    
}