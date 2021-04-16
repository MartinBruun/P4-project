using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IMathAssignmentVisitor : IMathNodeVisitor, IMathFuncCallVisitor
    {
        public void Visit(MathAssignmentNode node);
    }
}