using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class FunctionCallNode : ExpressionNode, IFunctionCallNode
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }


        public FunctionCallNode(IdNode functionName, List<ParameterNode> parameters, string expression)
            : base(expression,ExpressionType.FunctionCall)
        {
            FunctionName = functionName;
            Parameters = parameters;
        }


      
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}