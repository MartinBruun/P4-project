using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes;

namespace OG.ASTBuilding.Terminals
{
    public class MathFunctionCallNode : MathNode, IFunctionCallNode
    {
        public IDNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; } = new List<ParameterNode>();

        public MathFunctionCallNode(string value, IDNode id) : base(value, MathType.FunctionCallNode)
        {
            FunctionName = id;
        }
        public MathFunctionCallNode(string value, IDNode id, List<ParameterNode> parameters) : base(value, MathType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }


    }
}