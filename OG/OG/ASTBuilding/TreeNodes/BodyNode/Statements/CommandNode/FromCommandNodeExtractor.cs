﻿using System;
using System.Data;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class FromCommandNodeExtractor : OGBaseVisitor<PointReferenceNode>
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
                throw new AstNodeCreationException($"Node {context.GetText()} couldn't be created at FromCommandNodeExtractor.");
            }
        }

        public override PointReferenceNode VisitFromWithId(OGParser.FromWithIdContext context)
        {
            IdNode id = new IdNode(context.id.Text);
            return new PointReferenceIdNode(context.GetText(),id);
        }

        public override PointReferenceNode VisitFromWithNumberTuple(OGParser.FromWithNumberTupleContext context)
        {
            MathNode firstNum = new MathNodeExtractor().ExtractMathNode(context.tuple.lhs);
            MathNode secondNum = new MathNodeExtractor().ExtractMathNode(context.tuple.rhs);
            return new TuplePointNode(context.GetText(),firstNum, secondNum );
        }

        public override PointReferenceNode VisitFromWithStartPointRef(OGParser.FromWithStartPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.fromPoint.id.Text);
            return new ShapeStartPointNode(context.GetText(), shapeId);
        }

        public override PointReferenceNode VisitFromWithEndPointRef(OGParser.FromWithEndPointRefContext context)
        {
            IdNode shapeId = new IdNode(context.fromPoint.id.Text);
            return new ShapeEndPointNode(context.GetText(), shapeId);
        }
    }
}