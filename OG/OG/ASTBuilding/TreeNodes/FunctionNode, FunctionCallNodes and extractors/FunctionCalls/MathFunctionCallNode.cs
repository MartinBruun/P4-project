using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class MathFunctionCallNode : TerminalMathNode, IFunctionCallNode, IFunctionCallNodeVisitable
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }

       
        public MathFunctionCallNode(string value, IdNode id, List<ParameterNode> parameters) : base(value, MathType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }

        public void Accept(IFunctionCallNodeVisitorBundleBundle visitorBundleBundle)
        {
            visitorBundleBundle.Visit(this);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}