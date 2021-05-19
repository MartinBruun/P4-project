using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class FunctionCallParameterNode : ParameterNode
    {
        public FunctionCallNode FunctionCallNode { get; set; }
        
        public FunctionCallParameterNode(FunctionCallNode funcCallNode):base(funcCallNode.FunctionName)
        {
            FunctionCallNode = funcCallNode;
        }
        public FunctionCallParameterNode(FunctionCallParameterNode node) : base(node)
        {
            FunctionCallNode = node.FunctionCallNode;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}