using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class FunctionCallAssignNode : AssignmentNode, IFunctionCallNode, IFunctionCallAssignmentVisitable
 
    {
        public FunctionCallAssignNode(IdNode id, List<ParameterNode> parameters) : base(id, AssignmentType.FunctionCallAssignment)
        {
            FunctionName = id;
            Parameters = parameters;
        }

        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
     
        public void Accept(IFunctionCallAssignmentNodeVisitorBundle visitorBundle)
        {
            visitorBundle.Visit(this);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IFunctionCallAssignmentVisitable
    {
        public void Accept(IFunctionCallAssignmentNodeVisitorBundle visitorBundle);
    }

  
}