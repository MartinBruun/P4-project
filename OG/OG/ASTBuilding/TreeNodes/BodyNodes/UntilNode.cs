using OG.AST.TreeNodes.BoolNodes;

namespace OG.AST.TreeNodes.BodyNodes.CommandNodes
{
    public class UntilNode : IterationNode
    {
        public BoolNode predicate;

        public UntilNode(BoolNode condition)
        {
            predicate = condition;
        }
    }
}