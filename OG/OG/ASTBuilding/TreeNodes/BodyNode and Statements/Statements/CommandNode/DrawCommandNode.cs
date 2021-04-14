using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class DrawCommandNode : CommandNode
    {
        public IdNode Id;
        public PointReferenceNode From;

        public DrawCommandNode(IdNode id, PointReferenceNode from)
        {
            Id = id;
            From = from;
        }

        public DrawCommandNode(IdNode id)
        {
            Id = id;
            From = null;
        }
    }
}