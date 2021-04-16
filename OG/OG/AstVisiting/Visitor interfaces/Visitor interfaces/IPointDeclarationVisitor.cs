using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IPointDeclarationVisitor
    {
        public void Visit(PointDeclarationNode node);
    }
}