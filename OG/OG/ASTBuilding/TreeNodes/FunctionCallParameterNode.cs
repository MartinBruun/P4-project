using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.Terminals
{
    public class FunctionCallParameterNode : ParameterNode, IFunctionCallNode
    {
        public readonly FunctionCall functionCall;
        
        public FunctionCallParameterNode(FunctionCall funcCall):base(funcCall.FunctionName)
        {
            ParamType = ParameterType.FunctionCall;
            FunctionName = funcCall.FunctionName;
            functionCall = funcCall;
            Parameters = functionCall.Parameters;
        }
       
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
}