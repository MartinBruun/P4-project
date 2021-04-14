using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.Terminals
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