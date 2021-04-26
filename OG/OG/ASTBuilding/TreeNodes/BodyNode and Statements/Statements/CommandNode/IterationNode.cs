namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public abstract class IterationNode : CommandNode
    {
        public BodyNode Body;

        public IterationNode(BodyNode body)
        {
            Body = body;
        }
    }

    public interface IIterationNode
    {
        public IBody Body { get; set; }
    }
}