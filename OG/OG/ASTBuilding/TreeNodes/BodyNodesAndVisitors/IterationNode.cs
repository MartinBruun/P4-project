using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public abstract  class  IterationNode : CommandNode
    {
        public BodyNode Body;

        public IterationNode(BodyNode body)
        {
            Body = body;
        }
    }
}