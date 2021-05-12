
using System.Collections.Generic;
using System.Linq.Expressions;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    public class FunctionNode : AstNode
    {
        public IdNode Id { get; set; }
        // public List<ParameterNode> Params { get; set; }
            

        public ParameterNode Type { get; set; }
        public string ReturnType { get; set; }
        public ExpressionNode ReturnValue { get; set; }
        public BodyNode Body;
        public List<ParameterTypeNode> Parameters { get; set; }

        public FunctionNode(IdNode id, string returnType, BodyNode body, List<ParameterTypeNode> parameters)
        {
            Id = id;
            ReturnType = returnType;
            Parameters = parameters ?? new List<ParameterTypeNode>();
            Body = body;
        }
        public override string ToString()
        {
            return "FunctionNode with ID: " + Id.ToString();
        }
        
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);



        }
    }

  
}