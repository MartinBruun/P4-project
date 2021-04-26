using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.FunctionCalls;

namespace OG.AstVisiting
{
    public interface IAssignmentVisitorBundle : IPropertyAssignmentVisitor,
        IMathAssignmentVisitor, IBoolAssignmentVisitor, IPointReferenceAssignmentVisitor, IFunctionCallAssignmentNodeVisitorBundle
    {

    }
}