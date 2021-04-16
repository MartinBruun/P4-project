using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.AstVisiting
{
    public interface IDrawCommandVisitor : IPointReferenceNodeVisitor
    {
        public void Visit(DrawCommandNode node);
    }
}