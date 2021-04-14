using System;
using System.Collections.Generic;
using System.Drawing;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class DeclarationNodeExtractor : OGBaseVisitor<DeclarationNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
        private readonly BoolNodeExtractor _boolNodeExtractor = new BoolNodeExtractor();
        private readonly PointReferenceNodeExtractor _pointReferenceNodeExtractor = new PointReferenceNodeExtractor();
    
        
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
                throw new AstNodeCreationException("Could not convert DeclarationContext for expression"
                                                   + context.GetText() 
                                                   + " into, number, point or boolean declaration context.");
            }


        }

        public override DeclarationNode VisitNumberDcl(OGParser.NumberDclContext context)
        {
            Console.WriteLine("\t\t Trying to create DeclarationNode from " + context.GetText());
            IdNode id = new IdNode(context.numberDcl.id.Text);
            MathNode number = _mathNodeExtractor.ExtractMathNode(context.numberDcl.mathExpression());
            return new NumberDeclarationNode(id, number);
        }

        public override DeclarationNode VisitBoolDcl(OGParser.BoolDclContext context)
        {
            Console.WriteLine("\t\t Trying to create DeclarationNode from " + context.GetText());
            OGParser.BoolExpressionContext boolContext = context.boolDcl.value;
            BoolNode assignedExpression = _boolNodeExtractor.ExtractBoolNode(boolContext);
            IdNode variableId = new IdNode(context.boolDcl.id.Text);
            return new BoolDeclarationNode(variableId, assignedExpression);
        }

        public override DeclarationNode VisitPointDcl(OGParser.PointDclContext context)
        {
            Console.WriteLine("\t\t Trying to create DeclarationNode from " + context.GetText());
            try
            {

      
                try
                {
                    OGParser.PointDclIdAssignContext pointIdAssign  = (OGParser.PointDclIdAssignContext) context.pointDcl;
                    PointReferenceNode pointReferenceIdNode =  _pointReferenceNodeExtractor.VisitPointDclIdAssign(pointIdAssign);

                    return new PointDeclarationNode(new IdNode(pointIdAssign.id.Text), pointReferenceIdNode);

                }
                catch (InvalidCastException )
                {}
                
                OGParser.PointDclPointRefAssignContext pointReferenceAssignContext  = (OGParser.PointDclPointRefAssignContext) context.pointDcl;
                PointReferenceNode pointReferenceNode = _pointReferenceNodeExtractor.VisitPointDclPointRefAssign( pointReferenceAssignContext);

                return new PointDeclarationNode(new IdNode(pointReferenceAssignContext.id.Text), pointReferenceNode);
            }
            catch (InvalidCastException )
            {
                throw new AstNodeCreationException("PointDclcontext  could not be typecast" +
                                                   " to PointDclIdAssignContext or" +
                                                   " PointDclPointRefAssignContext.");
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