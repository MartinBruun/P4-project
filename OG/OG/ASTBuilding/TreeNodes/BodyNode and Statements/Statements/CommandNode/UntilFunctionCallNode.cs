using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class UntilFunctionCallNode : IterationNode, IUntilFunctionCallVisitable
    {
        public FunctionCallNode Predicate;

        public UntilFunctionCallNode(FunctionCallNode predicate, BodyNode body) : base(body)
        {
            Predicate = predicate;
        }
        

        public void Accept(IUntilNodeVisitorBundleBundle visitorBundleBundle)
        {
            visitorBundleBundle.Visit(this);
            
        }
    }


}