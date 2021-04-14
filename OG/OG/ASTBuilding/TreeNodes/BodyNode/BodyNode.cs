using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.ASTBuilding.Shapes
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