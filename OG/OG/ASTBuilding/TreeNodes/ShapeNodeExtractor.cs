using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes
{
    public class ShapeNodeExtractor : OGBaseVisitor<ShapeNode>
    {
        private readonly BodyNodeExtractor _bodyNodeExtractor = new BodyNodeExtractor();
        public override ShapeNode VisitShapeDcl(OGParser.ShapeDclContext context)
        {
            BodyNode body = _bodyNodeExtractor.VisitBody(context.bdy);
            return new ShapeNode(new IdNode(context.id.Text), body);
        }
    }
}