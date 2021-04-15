using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.AstVisiting
{
    public interface ICurveCommandVisitor
    {
        public void Visit(CurveCommandNode node);
    }
}