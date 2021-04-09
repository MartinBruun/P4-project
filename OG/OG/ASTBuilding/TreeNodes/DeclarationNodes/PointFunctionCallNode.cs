using System.Collections.Generic;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class  PointFunctionCallNode : PointReferenceNode, IFunctionCallNode
    {
        public PointFunctionCallNode(string pointText, IdNode functionName, List<ParameterNode> functionParameters) : base(pointText, PointReferenceNodeType.PointFunctionCallNode)
        {
            Parameters = functionParameters;
            FunctionName = functionName;
        }

        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
}