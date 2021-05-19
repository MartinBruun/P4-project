using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class FunctionCallAssignNode : AssignmentNode, IFunctionCallNode
 
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
        
        public FunctionCallAssignNode(IdNode id,IdNode funcName, List<ParameterNode> parameters) : base(id, AssignmentType.FunctionCallAssignment)
        {
            FunctionName = funcName;
            Parameters = parameters;
        }

        public FunctionCallAssignNode(FunctionCallAssignNode node) : base(node)
        {
            FunctionName = node.FunctionName;
            Parameters = node.Parameters;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }
    }
}