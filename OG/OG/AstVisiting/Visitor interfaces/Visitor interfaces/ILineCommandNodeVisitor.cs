using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.AstVisiting
{
    public interface ILineCommandNodeVisitor: IPointReferenceNodeVisitor
    {
        public void Visit(LineCommandNode node);
    }
}