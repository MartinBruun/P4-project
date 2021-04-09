using System.Collections.Generic;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class BoolFunctionCallNode : BoolNode, IFunctionCallNode
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