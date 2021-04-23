
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    public class FunctionNode : AstNode, IFunctionNodeVisitable
    {
        public IdNode Id { get; set; }

        public string ReturnType { get; set; }
        public BodyNode Body;
        public List<ParameterNode> Parameters { get; set; }

        public FunctionNode(IdNode id, string returnType, BodyNode body, List<ParameterNode> parameters = null)
        {
            Id = id;
            ReturnType = returnType;
            Parameters = parameters != null ? parameters : new List<ParameterNode>();
            Body = body;
        }
        public override string ToString()
        {
            return "FunctionNode with ID: " + Id.ToString();
        }

        public void Accept(IFunctionNodeVisitorBundle visitorBundleBundleBundleBundle)
        {
            visitorBundleBundleBundleBundle.Visit(this);
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }

    
}