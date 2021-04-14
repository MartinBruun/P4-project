using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements
{
    public class BodyNode : AstNode
    {

        public List<StatementNode> StatementNodes { get; set; }

        public BodyNode(List<StatementNode> statements)
        {
            StatementNodes = statements;
        }
    }
    
}