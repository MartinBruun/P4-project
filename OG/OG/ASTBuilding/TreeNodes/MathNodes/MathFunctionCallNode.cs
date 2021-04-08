using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes;

namespace OG.ASTBuilding.Terminals
{
    public class MathFunctionCallNode : MathNode, IFunctionCallNode
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }

       
        public MathFunctionCallNode(string value, IdNode id, List<ParameterNode> parameters) : base(value, MathType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }
    }
}