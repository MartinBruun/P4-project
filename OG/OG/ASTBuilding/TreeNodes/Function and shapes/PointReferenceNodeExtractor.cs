using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    public class PointReferenceNodeExtractor : OGBaseVisitor<PointReferenceNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
        private ParameterNodeListBuilder _parameterNodeListBuilder;
        public override PointReferenceNode VisitPointReference(OGParser.PointReferenceContext context)
        {
            
            OGParser.NumberTupleContext tupleContext = context.tuple;
            //If context and context.point is not null get text.
            string pointText = context?.point?.Text;
            OGParser.FunctionCallContext pointFunctionCallContext = context.funcCall;

            //Check if text is not null and contains either .endPoint or .startPoint
            //else if tupleContext is not null empty try and create tuplePointReference
            //else if pointFunctionCallContext is not null or empty, create function call node. 
            //Else throw
            if (!string.IsNullOrWhiteSpace(pointText) && (pointText.Contains(".endPoint") || pointText.Contains(".startPoint")))
            {
                return CheckForStartEndPointText(pointText, context.GetText());
            }
            
            if (context.ID() != null && !string.IsNullOrEmpty(context.ID().GetText()))
            {
                return new PointReferenceIdNode(context.GetText(), new IdNode(context.ID().GetText()));
            }
            
            if (tupleContext != null && !tupleContext.IsEmpty)
            {
                MathNode lhs = _mathNodeExtractor.ExtractMathNode(tupleContext.lhs);
                MathNode rhs = _mathNodeExtractor.ExtractMathNode(tupleContext.rhs);
                return new TuplePointNode(context.GetText(), lhs, rhs);
            }
            
            if (pointFunctionCallContext != null && !pointFunctionCallContext.IsEmpty)
            {
                List<ParameterNode> parameters = _parameterNodeListBuilder.VisitFunctionCall(pointFunctionCallContext);
                IdNode id = new IdNode(pointFunctionCallContext.id.Text);
                return new PointFunctionCallNode(context.GetText(), id, parameters);
            }

            throw new AstNodeCreationException("Could not create PointReferenceNode from" + context.GetText());
        }

        private PointReferenceNode CheckForStartEndPointText(string pointText, string fullContextText)
        {
            string[] startEndPointText = pointText.Split(".");
            if (
                !string.IsNullOrWhiteSpace(startEndPointText[0]) &&
                !string.IsNullOrWhiteSpace(startEndPointText[1]) &&
                startEndPointText.Length == 2 && startEndPointText.Contains("endPoint"))
            {
                //Result
                return new ShapeEndPointNode(fullContextText, new IdNode(startEndPointText[0]));

            }
            else if
                (!string.IsNullOrWhiteSpace(startEndPointText[0]) &&
                 !string.IsNullOrWhiteSpace(startEndPointText[1]) &&
                 startEndPointText.Length == 2 && startEndPointText.Contains("startPoint"))
            {
                //Result
                return new ShapeStartPointNode(fullContextText, new IdNode(startEndPointText[0]));
            }
            throw new AstNodeCreationException("Could not create PointReferenceNode from" + fullContextText);
        }

        public override PointReferenceNode VisitPointDclIdAssign(OGParser.PointDclIdAssignContext context)
        {
            return new PointReferenceIdNode(context.GetText(), new IdNode(context.id.Text));
        }

       
        public override PointReferenceNode VisitPointDclPointRefAssign(OGParser.PointDclPointRefAssignContext context)
        {
            return VisitPointReference(context.value);
        }

        public PointReferenceNode ExtractPointReferenceNode(OGParser.FromCommandContext context)
        {
            try
            {
                try
                {
                    OGParser.FromWithIdContext fromId = (OGParser.FromWithIdContext) context;
                    return VisitFromWithId(fromId);
                    
                }
                catch (InvalidCastException)
                {}

                try
                {
                    OGParser.FromWithNumberTupleContext fromTuple = (OGParser.FromWithNumberTupleContext) context;
                    return  VisitFromWithNumberTuple(fromTuple);
                   
                }
                catch (InvalidCastException e)
                {}

                try
                {
                    OGParser.FromWithStartPointRefContext fromStartPoint =
                        (OGParser.FromWithStartPointRefContext) context;
                    return CheckForStartEndPointText(fromStartPoint?.fromPoint?.Text, fromStartPoint?.GetText());

                }
                catch (InvalidCastException e)
                { }

                OGParser.FromWithEndPointRefContext fromEndPoint = (OGParser.FromWithEndPointRefContext) context;
                
                return CheckForStartEndPointText(fromEndPoint?.fromPoint?.Text, fromEndPoint?.GetText());
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Could not create PointReferenceNode from" + context.GetText());
            }
        }

        public override PointReferenceNode VisitFromWithId(OGParser.FromWithIdContext context)
        {
            return new PointReferenceIdNode(context.GetText(), new IdNode(context.id.Text));
        }

        public override PointReferenceNode VisitFromWithNumberTuple(OGParser.FromWithNumberTupleContext context)
        {
            MathNode lhs = _mathNodeExtractor.ExtractMathNode(context.tuple.lhs);
            MathNode rhs = _mathNodeExtractor.ExtractMathNode(context.tuple.rhs);
            return new TuplePointNode(context.GetText(), lhs, rhs);
        }
    }
}