using OG.AST.Functions;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.Function_and_shapes
{
    public class ShapeNodeExtractor : OGBaseVisitor<ShapeNode>
    {
        private BodyNodeExtractor _bodyNodeExtractor = new BodyNodeExtractor();
        public override ShapeNode VisitShapeDcl(OGParser.ShapeDclContext context)
        {
            BodyNode body = _bodyNodeExtractor.VisitBody(context.bdy);
            return new ShapeNode(new IdNode(context.id.Text), body);
        }
    }
}