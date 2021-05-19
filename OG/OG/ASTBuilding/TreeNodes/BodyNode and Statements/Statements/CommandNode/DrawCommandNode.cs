using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class DrawCommandNode : CommandNode
    {
        public IdNode Id;
        public PointReferenceNode From;

        public DrawCommandNode(IdNode id, PointReferenceNode from):this(id)
        {
            From = from;
        }

        public DrawCommandNode(IdNode id):base(CommandType.DrawCommandNode)
        {
            Id = id;
            From = null;
        }

        public DrawCommandNode(DrawCommandNode node) : base(node)
        {
            Id = node.Id;
            From = node.From;
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}