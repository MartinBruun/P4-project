using System.Linq;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    public class PointReferenceNodeExtractor : OGBaseVisitor<PointReferenceNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
        public override PointReferenceNode VisitPointReference(OGParser.PointReferenceContext context)
        {
            
            OGParser.NumberTupleContext tupleContext = context.tuple;
            ITerminalNode startPointRefContext = context.StartPointReference();
            ITerminalNode endPointRefContext = context.StartPointReference();

            //First element must be id, second must be endPoint or startPoint
            string[] endPointText = endPointRefContext.GetText().Split(".");
            string[] startPointText = startPointRefContext.GetText().Split(".");

            if (endPointText.Length == 2 && endPointText.Contains("endPoint") &&
                !string.IsNullOrWhiteSpace(endPointText[0]))
            {
                return new ShapeEndPointNode(context.GetText(), new IdNode(startPointText[0]));
            } else if (startPointText.Length == 2 && startPointText.Contains("startPoint") &&
                       !string.IsNullOrWhiteSpace(endPointText[0]))
            {

                return new ShapeStartPointNode(context.GetText(), new IdNode(endPointText[0]));
                //Valid StartPoint! Create and return node
            } else if (tupleContext != null && !tupleContext.IsEmpty)
            {
                MathNode lhs = _mathNodeExtractor.ExtractMathNode(tupleContext.lhs);
                MathNode rhs = _mathNodeExtractor.ExtractMathNode(tupleContext.rhs);
                return new TuplePointNode(context.GetText(), lhs, rhs);
            }
            else
            {
                throw new AstNodeCreationException("Could not create PointReferenceNode from" + context.GetText());
            }

        }
    }
}