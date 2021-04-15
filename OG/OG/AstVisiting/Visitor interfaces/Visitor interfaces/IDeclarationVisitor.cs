using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IDeclarationVisitor : IFunctionCallNodeVisitor
    {
        public void Visit(BoolDeclarationNode node);
        public void Visit(NumberDeclarationNode node);
        public void Visit(PointDeclarationNode node);
    }
}