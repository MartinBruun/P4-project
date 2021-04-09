using System.Collections.Generic;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.Boolean_nodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class BoolFunctionCallNode : BoolTerminalNode, IFunctionCallNode
    {
        public BoolFunctionCallNode(string value, IdNode id, List<ParameterNode> parameters) : base(value, BoolType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }

        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
}