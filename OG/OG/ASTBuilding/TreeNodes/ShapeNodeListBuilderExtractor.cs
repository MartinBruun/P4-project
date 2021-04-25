using System.Collections.Generic;

namespace OG.ASTBuilding.TreeNodes
{
    public class ShapeNodeListBuilderExtractor : AstBuilderErrorInheritor<List<ShapeNode>>
    {
        private readonly ShapeNodeExtractor _shapeNodeExtractor;
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
        
        public ShapeNodeListBuilderExtractor(List<SemanticError> errs) : base(errs)
        {
            _shapeNodeExtractor = new ShapeNodeExtractor(errs);
        }
    }
}