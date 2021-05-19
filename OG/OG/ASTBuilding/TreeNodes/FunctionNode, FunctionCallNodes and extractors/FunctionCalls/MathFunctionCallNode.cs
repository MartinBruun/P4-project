using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class MathFunctionCallNode : TerminalMathNode, IFunctionCallNode
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
        
        public MathFunctionCallNode(string value, IdNode id, List<ParameterNode> parameters) : base(value, MathType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }
        public MathFunctionCallNode(MathFunctionCallNode node) : base(node)
        {
            FunctionName = node.FunctionName;
            Parameters = node.Parameters;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
        
        public override NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}