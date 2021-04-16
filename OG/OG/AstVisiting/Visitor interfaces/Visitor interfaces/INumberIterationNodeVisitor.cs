using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.AstVisiting
{
    public interface INumberIterationNodeVisitor
    {
        public void Visit(NumberIterationNode node);
    }
}