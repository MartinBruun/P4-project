using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class DeclarationNodeExtractor : AstBuilderErrorInheritor<DeclarationNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor;
        private readonly BoolNodeExtractor _boolNodeExtractor;
        private readonly PointReferenceNodeExtractor _pointReferenceNodeExtractor;

        public DeclarationNodeExtractor(List<SemanticError> errs ) : base(errs)
        {
            _boolNodeExtractor = new BoolNodeExtractor(errs);
            _mathNodeExtractor = new MathNodeExtractor(errs);
            _pointReferenceNodeExtractor = new PointReferenceNodeExtractor(errs);
        }
    
        
        public DeclarationNode ExtractDeclarationNode(OGParser.DeclarationContext context)
        {
            try
            {
                try
                {
                    OGParser.NumberDclContext numberDeclarationContext =
                        (OGParser.NumberDclContext) context;
                    return VisitNumberDcl(numberDeclarationContext);
                }
                catch (InvalidCastException )
                { }

                try
                {
                    OGParser.PointDclContext pointDeclarationContext =
                        (OGParser.PointDclContext) context;
                    
                    return VisitPointDcl(pointDeclarationContext);
                }
                catch (InvalidCastException )
                { }
                
                OGParser.BoolDclContext boolDeclarationContext = (OGParser.BoolDclContext) context;
                return VisitBoolDcl(boolDeclarationContext);
            }
            catch (InvalidCastException )
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column, "Could not convert DeclarationContext for expression"
                    + context.GetText() 
                    + " into, number, point or boolean declaration context.")
                {
                    IsFatal = true
                });
                return null;
            }


        }

        public override DeclarationNode VisitNumberDcl(OGParser.NumberDclContext context)
        {
            IdNode id = new IdNode(context.numberDcl.id.Text);
            MathNode number = _mathNodeExtractor.ExtractMathNode(context.numberDcl.mathExpression());
            return new NumberDeclarationNode(id, number) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override DeclarationNode VisitBoolDcl(OGParser.BoolDclContext context)
        {
            OGParser.BoolExpressionContext boolContext = context.boolDcl.value;
            BoolNode assignedExpression = _boolNodeExtractor.ExtractBoolNode(boolContext);
            IdNode variableId = new IdNode(context.boolDcl.id.Text);
            return new BoolDeclarationNode(variableId, assignedExpression) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public override DeclarationNode VisitPointDcl(OGParser.PointDclContext context)
        {
            try
            {

      
                try
                {
                    OGParser.PointDclIdAssignContext pointIdAssign  = (OGParser.PointDclIdAssignContext) context.pointDcl;
                    PointReferenceNode pointReferenceIdNode =  _pointReferenceNodeExtractor.VisitPointDclIdAssign(pointIdAssign);

                    return new PointDeclarationNode(new IdNode(pointIdAssign.id.Text), pointReferenceIdNode) {
                        Line =context.Start.Line,
                        Column = context.Start.Column
                    };

                }
                catch (InvalidCastException )
                {}
                
                OGParser.PointDclPointRefAssignContext pointReferenceAssignContext  = (OGParser.PointDclPointRefAssignContext) context.pointDcl;
                PointReferenceNode pointReferenceNode = _pointReferenceNodeExtractor.VisitPointDclPointRefAssign( pointReferenceAssignContext);

                return new PointDeclarationNode(new IdNode(pointReferenceAssignContext.id.Text), pointReferenceNode) {
                    Line =context.Start.Line,
                    Column = context.Start.Column
                };
            }
            catch (InvalidCastException )
            {
                
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,"PointDclcontext  could not be typecast" +
                                                   " to PointDclIdAssignContext or" +
                                                   " PointDclPointRefAssignContext.")
                {
                    IsFatal = true
                });
                return null;
            }
            
            
        }

        public override DeclarationNode VisitStmt(OGParser.StmtContext context)
        {
            OGParser.DeclarationContext  declarationContext = context.dcl;

            if (declarationContext != null && !declarationContext.IsEmpty)
            {
                return ExtractDeclarationNode(declarationContext);
            }

            return null;
        }
    }
}