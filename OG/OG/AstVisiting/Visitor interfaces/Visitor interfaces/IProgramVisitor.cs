using OG.ASTBuilding.TreeNodes;

namespace OG.AstVisiting
{
    public interface IProgramVisitor : IShapeNodeVisitor, IFunctionNodeVisitor, IDrawNodeVisitor, IMachineSettingVisitor
    {
        public void Visit(ProgramNode node);
    }
}