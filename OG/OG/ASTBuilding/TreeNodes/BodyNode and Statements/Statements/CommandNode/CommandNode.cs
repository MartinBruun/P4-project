namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public abstract class CommandNode : StatementNode
    {
        public enum CommandType
        {
            MovementNode,
            DrawCommandNode,
            IterationNode
        }

        public CommandType TypeOfCommand { get;}
        public CommandNode(CommandType type):base(StatementType.CommandNode)
        {
            TypeOfCommand = type;
        }
        public CommandNode(CommandNode node) : base(node)
        {
            TypeOfCommand = node.TypeOfCommand;
        }
    }
}