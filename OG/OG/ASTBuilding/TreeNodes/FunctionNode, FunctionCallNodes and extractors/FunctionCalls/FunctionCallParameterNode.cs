using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class FunctionCallParameterNode : ParameterNode, IFunctionCallNode
    {
        public readonly FunctionCallNode FunctionCallNode;
        
        public FunctionCallParameterNode(FunctionCallNode funcCallNode):base(funcCallNode.FunctionName)
        {
            ParamType = ParameterType.FunctionCall;
            FunctionName = funcCallNode.FunctionName;
            FunctionCallNode = funcCallNode;
            Parameters = FunctionCallNode.Parameters;
        }
       
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
}