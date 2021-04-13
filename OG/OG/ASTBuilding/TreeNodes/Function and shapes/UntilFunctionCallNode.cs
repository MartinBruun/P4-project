using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class UntilFunctionCallNode : IterationNode
    {
        public IFunctionCall Predicate;

        public UntilFunctionCallNode(IFunctionCall predicate, BodyNode body) : base(body)
        {
            Predicate = predicate;
        }
    }
}