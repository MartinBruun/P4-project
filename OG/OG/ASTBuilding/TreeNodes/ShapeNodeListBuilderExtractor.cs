using System.Collections.Generic;
using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding.TreeNodes.Function_and_shapes
{
    public class ShapeNodeListBuilderExtractor : OGBaseVisitor<List<ShapeNode>>
    {
        private readonly ShapeNodeExtractor _shapeNodeExtractor = new ShapeNodeExtractor();
        private readonly List<ShapeNode> _shapes = new List<ShapeNode>();
        public override List<ShapeNode> VisitShapeDcls(OGParser.ShapeDclsContext context)
        {
            if (context.shapeDeclarations != null && !context.currentShapeDcl.IsEmpty)
            {
                _shapes.Add(_shapeNodeExtractor.VisitShapeDcl(context.currentShapeDcl));
            }
            if (context.shapeDeclarations != null && !context.shapeDeclarations.IsEmpty)
            {
                VisitShapeDcls(context.shapeDeclarations);
            }

            return _shapes;
        }
    }
}