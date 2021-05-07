using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class FromCommandNodeExtractor : AstBuilderErrorInheritor<PointReferenceNode>
    {
        public PointReferenceNode ExtractFromCommandNode(OGParser.FromCommandContext context)
        {
            
            try
            {
                OGParser.FromWithIdContext idContext = (OGParser.FromWithIdContext) context;
                return VisitFromWithId(idContext);
            }
            catch(InvalidCastException){}
            
            try
            {
              
                OGParser.FromWithNumberTupleContext tupleContext = (OGParser.FromWithNumberTupleContext) context;
                return VisitFromWithNumberTuple(tupleContext);
            }
            catch(InvalidCastException){}
            
            try
            {
                OGParser.FromWithStartPointRefContext startPointContext = (OGParser.FromWithStartPointRefContext) context;
                return VisitFromWithStartPointRef(startPointContext);
            }
            catch(InvalidCastException){}

            try
            {
                OGParser.FromWithEndPointRefContext endPointContext = (OGParser.FromWithEndPointRefContext) context;
                return VisitFromWithEndPointRef(endPointContext);
            }
            catch (InvalidCastException)
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,$"Node {context.GetText()} couldn't be created at FromCommandNodeExtractor. Context conversion err.")
                {
                    IsFatal = true
                });
                return null;
            }
        }

        public override PointReferenceNode VisitFromWithId(OGParser.FromWithIdContext context)
        {
        try            
            {
                IdNode id = new IdNode(context.id.Text);
                return new PointReferenceIdNode(context.GetText(),id);
            } catch (InvalidCastException)
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column, $"Node {context.GetText()} couldn't be created at FromCommandNodeExtractor.")
                {
                    IsFatal = true
                });
                return null;
              
            }
        }

        public override PointReferenceNode VisitFromWithNumberTuple(OGParser.FromWithNumberTupleContext context)
        {
            MathNode firstNum = new MathNodeExtractor(SemanticErrors).ExtractMathNode(context.tuple.lhs);
            MathNode secondNum = new MathNodeExtractor(SemanticErrors).ExtractMathNode(context.tuple.rhs);
            return new TuplePointNode(context.GetText(),firstNum, secondNum ) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override PointReferenceNode VisitFromWithStartPointRef(OGParser.FromWithStartPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.fromPoint.id.Text);
            return new ShapeStartPointNode(context.GetText(), shapeId) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override PointReferenceNode VisitFromWithEndPointRef(OGParser.FromWithEndPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.fromPoint.id.Text);
            return new ShapeEndPointNode(context.GetText(), shapeId) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public FromCommandNodeExtractor(List<SemanticError> errs) : base(errs)
        {
        }
    }
}