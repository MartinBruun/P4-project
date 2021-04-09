using System;
using System.Collections.Generic;
using Antlr4.Runtime;
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
                catch (InvalidCastException e)
                { }

                try
                {
                    OGParser.PointDclContext pointDeclaration =
                        (OGParser.PointDclContext) context;
                    throw new NotImplementedException("PointDeclerations not supported yet");
                }
                catch (InvalidCastException e)
                { }
                
                OGParser.BoolDclContext boolDeclarationContext = (OGParser.BoolDclContext) context;
                return VisitBoolDcl(boolDeclarationContext);
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Could not convert DeclarationContext for expression"
                                                   + context.GetText() 
                                                   + " into, number, point or boolean declaration context.");
            }


        }

        public override DeclarationNode VisitNumberDcl(OGParser.NumberDclContext context)
        {
            IdNode id = new IdNode(context.numberDcl.id.Text);
            MathNode number = _mathNodeExtractor.ExtractMathNode(context.numberDcl.mathExpression());
            return new NumberDeclarationNode(id, number);
        }

        public override DeclarationNode VisitBoolDcl(OGParser.BoolDclContext context)
        {
            OGParser.BoolExpressionContext boolContext = context.boolDcl.value;
            BoolNode assignedExpression = _boolNodeExtractor.ExtractBoolNode(boolContext);
            IdNode variableId = new IdNode(context.boolDcl.id.Text);
            return new BoolDeclarationNode(variableId, assignedExpression);
        }
    }
}