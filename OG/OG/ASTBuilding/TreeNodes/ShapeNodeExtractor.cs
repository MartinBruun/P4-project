using System.Collections.Generic;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes
{
    public class ShapeNodeExtractor : AstBuilderErrorInheritor<ShapeNode>
    {
        private readonly BodyNodeExtractor _bodyNodeExtractor;
        public override ShapeNode VisitShapeDcl(OGParser.ShapeDclContext context)
        {
            BodyNode body = _bodyNodeExtractor.VisitBody(context.bdy);
            ShapeNode node =  new ShapeNode(new IdNode(context.id.Text), body);
            node.Line =context.id.Line;
            node.Column =context.id.Column;
            
            return node;
        }

        public ShapeNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            _bodyNodeExtractor =  new BodyNodeExtractor(errs);
        }
    }
}