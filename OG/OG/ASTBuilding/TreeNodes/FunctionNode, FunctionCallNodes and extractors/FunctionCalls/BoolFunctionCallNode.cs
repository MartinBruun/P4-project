using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class BoolFunctionCallNode : BoolTerminalNode, IFunctionCallNode, IBoolNodeVisitable
    {
        public BoolFunctionCallNode(string value, IdNode id, List<ParameterNode> parameters) : base(value, BoolType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }

        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
        public void Accept(IBoolNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }

     
    }
}