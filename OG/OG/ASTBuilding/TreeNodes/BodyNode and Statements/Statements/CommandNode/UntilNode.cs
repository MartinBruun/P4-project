using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class UntilNode : IterationNode
    {
        public BoolNode Predicate;

        public UntilNode(BoolNode condition, BodyNode body):base(body)
        {
            Predicate = condition;
        }
    }
}