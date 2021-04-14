using System.Collections.Generic;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class FunctionCallNode : ExpressionNode, IFunctionCallNode
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }


        public FunctionCallNode(IdNode functionName, List<ParameterNode> parameters, string expression)
            : base(expression,ExpressionType.FunctionCall)
        {
            FunctionName = functionName;
            Parameters = parameters;
        }
    }
}