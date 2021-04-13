using System;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class ToCommandNodeExtractor : OGBaseVisitor<PointReferenceNode>
    {
        public PointReferenceNode ExtractToCommandNode(OGParser.ToCommandContext context)
        {
            try
            {
                OGParser.ToWithIdContext idContext = (OGParser.ToWithIdContext) context;
                return VisitToWithId(idContext);
            }
            catch(InvalidCastException e){}
            
            try
            {
                OGParser.ToWithNumberTupleContext tupleContext = (OGParser.ToWithNumberTupleContext) context;
                return VisitToWithNumberTuple(tupleContext);
            }
            catch(InvalidCastException e){}
            
            try
            {
                OGParser.ToWithStartPointRefContext startPointContext = (OGParser.ToWithStartPointRefContext) context;
                return VisitToWithStartPointRef(startPointContext);
            }
            catch(InvalidCastException e){}

            try
            {
                OGParser.ToWithEndPointRefContext endPointContext = (OGParser.ToWithEndPointRefContext) context;
                return VisitToWithEndPointRef(endPointContext);
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException($"Node {context.GetText()} couldn't be created at FromCommandNodeExtractor.");
            }
        }
        public override PointReferenceNode VisitToWithId(OGParser.ToWithIdContext context)
        {
            IdNode id = new IdNode(context.id.Text);
            return new PointReferenceIdNode(context.GetText(), id);
        }

        public override PointReferenceNode VisitToWithNumberTuple(OGParser.ToWithNumberTupleContext context)
        {
            MathNode firstNum = new MathNodeExtractor().ExtractMathNode(context.tuple.lhs);
            MathNode secondNum = new MathNodeExtractor().ExtractMathNode(context.tuple.rhs);
            return new TuplePointNode(context.GetText(), firstNum, secondNum);
        }

        public override PointReferenceNode VisitToWithStartPointRef(OGParser.ToWithStartPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.toPoint.id.Text);
            return new ShapeStartPointNode(context.GetText(), shapeId);
        }

        public override PointReferenceNode VisitToWithEndPointRef(OGParser.ToWithEndPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.toPoint.id.Text);
            return new ShapeEndPointNode(context.GetText(), shapeId);
        }
    }
}