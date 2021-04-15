
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    public class FunctionNode : AstNode, IFunctionNodeVisitable
    {
        public IdNode Id { get; set; }

        public string ReturnType { get; set; }
        public BodyNode Body;

        public FunctionNode(IdNode id, string returnType, BodyNode body)
        {
            Id = id;
            ReturnType = returnType;
            Body = body;
        }
        public override string ToString()
        {
            return "FunctionNode with ID: " + Id.ToString();
        }

        public void Accept(IFunctionNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IFunctionNode
    {
        public IdNode Id { get; set; }

        public string ReturnType { get; set; }
        public BodyNode Body { get; set; }
    }
}