using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
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