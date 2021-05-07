using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class FunctionCallParameterNode : ParameterNode
    {
        public readonly FunctionCallNode FunctionCallNode;
        
        public FunctionCallParameterNode(FunctionCallNode funcCallNode):base(funcCallNode.FunctionName)
        {
            ParamType = ParameterType.FunctionCall;
            FunctionCallNode = funcCallNode;
        }


      
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}