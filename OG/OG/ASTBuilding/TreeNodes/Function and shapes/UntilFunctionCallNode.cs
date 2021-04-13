using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes;


namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class UntilFunctionCallNode : IterationNode
    {
        public FunctionCall Predicate;

        public UntilFunctionCallNode(FunctionCall predicate, BodyNode body) : base(body)
        {
            Predicate = predicate;
        }
    }
}