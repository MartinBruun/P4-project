using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes
{
    public interface IFunctionNode:IAstNode
    {
        public IdNode Id { get; set; }

        public string ReturnType { get; set; }
        public BodyNode Body { get; set; }
    }
}