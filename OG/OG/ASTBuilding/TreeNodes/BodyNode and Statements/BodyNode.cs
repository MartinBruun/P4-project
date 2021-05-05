using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements
{
    public class BodyNode : AstNode
    {

        public List<StatementNode> StatementNodes { get; set; }

        public BodyNode(List<StatementNode> statements)
        {
            StatementNodes = statements;
        }
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }

    public interface IBody
    {
        public List<StatementNode> StatementNodes { get; set; }
    }

}