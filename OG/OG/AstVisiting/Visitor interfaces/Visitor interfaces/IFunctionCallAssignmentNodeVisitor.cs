using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IFunctionCallAssignmentNodeVisitorBundle : INativeFunctionCallsVisitorBundle
    {
        public void Visit(FunctionCallAssignNode node);
    }
}