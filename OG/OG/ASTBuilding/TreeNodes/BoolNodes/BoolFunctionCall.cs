using System.Collections.Generic;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class BoolFunctionCall : BoolNode, IFunctionCallNode
    {
        public BoolFunctionCall(string value, IDNode id) : base(value, BoolType.FunctionCallNode)
        {
            FunctionName = id;
        }

        public IDNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; } = new List<ParameterNode>();
    }
}