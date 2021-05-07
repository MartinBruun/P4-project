using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class ToCommandNodeExtractor : AstBuilderErrorInheritor<PointReferenceNode>
    {

        public ToCommandNodeExtractor(List<SemanticError> errs):base(errs)
        {
            
        }
        
        public PointReferenceNode ExtractToCommandNode(OGParser.ToCommandContext context)
        {
            try
            {
                OGParser.ToWithIdContext idContext = (OGParser.ToWithIdContext) context;
                return VisitToWithId(idContext);
            }
            catch(InvalidCastException ){}
            
            try
            {
                OGParser.ToWithNumberTupleContext tupleContext = (OGParser.ToWithNumberTupleContext) context;
                return VisitToWithNumberTuple(tupleContext);
            }
            catch(InvalidCastException ){}
            
            try
            {
                OGParser.ToWithStartPointRefContext startPointContext = (OGParser.ToWithStartPointRefContext) context;
                return VisitToWithStartPointRef(startPointContext);
            }
            catch(InvalidCastException ){}

            try
            {
                OGParser.ToWithEndPointRefContext endPointContext = (OGParser.ToWithEndPointRefContext) context;
                return VisitToWithEndPointRef(endPointContext);
            }
            catch (InvalidCastException )
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,$"Node {context.GetText()} couldn't be created at FromCommandNodeExtractor. ToCommandContext could not be cast into concrete context")
                {
                    IsFatal = true
                });

                return null;
            }
        }
        public override PointReferenceNode VisitToWithId(OGParser.ToWithIdContext context)
        {
            IdNode id = new IdNode(context.id.Text);
            return new PointReferenceIdNode(context.GetText(), id) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override PointReferenceNode VisitToWithNumberTuple(OGParser.ToWithNumberTupleContext context)
        {
            MathNode firstNum = new MathNodeExtractor(SemanticErrors).ExtractMathNode(context.tuple.lhs);
            MathNode secondNum = new MathNodeExtractor(SemanticErrors).ExtractMathNode(context.tuple.rhs);
            return new TuplePointNode(context.GetText(), firstNum, secondNum) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override PointReferenceNode VisitToWithStartPointRef(OGParser.ToWithStartPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.toPoint.id.Text);
            return new ShapeStartPointNode(context.GetText(), shapeId) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override PointReferenceNode VisitToWithEndPointRef(OGParser.ToWithEndPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.toPoint.id.Text);
            return new ShapeEndPointNode(context.GetText(), shapeId) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }
    }
}