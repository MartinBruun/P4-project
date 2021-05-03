using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class UntilFunctionCallNode : IterationNode
    {
        public FunctionCallNode Predicate;

        public UntilFunctionCallNode(FunctionCallNode predicate, BodyNode body) : base(body)
        {
            Predicate = predicate;
        }
        


        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }


}