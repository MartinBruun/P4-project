using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Draw
{
    public class FromCommandNode : AstNode
    {
        public PointReferenceNode FromPoint { get; set; }

        public FromCommandNode(PointReferenceNode fromPoint)
        {
            this.FromPoint = fromPoint;
        }
    }
}