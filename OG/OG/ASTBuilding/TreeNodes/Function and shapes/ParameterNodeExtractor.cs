using System;
using System.Collections.Generic;
using OG.AST.Functions;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Shapes
{
    public class ParameterNodeExtractor : OGBaseVisitor<ParameterNode>
    {
        private BoolNodeExtractor _boolNodeExtractor = null;
        private MathNodeExtractor _mathNodeExtractor = null;
        private FunctionCallExtractor _functionCallNodeExtractor = null;
 
        public override ParameterNode VisitSingleParameter(OGParser.SingleParameterContext context)
        {
            OGParser.PassedParamContext parameterContext = context.parameter;
            return ExtractParameterNode(context.parameter);
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedDirectValueContext context)
        {

            OGParser.ExpressionContext exprContext = context.expr;
            OGParser.BoolExpressionContext boolExpressionContext = context.expr.boolExpression();
            OGParser.MathExpressionContext mathExpressionContext = context.expr.mathExpression();
            OGParser.FunctionCallContext functionExpressionContext = context.expr.functionCall();
            
            
            
            if (
                (exprContext != null && !exprContext.IsEmpty) &&
                (exprContext.id.Text != null || exprContext.id.Text != string.Empty)
            )
            {
                return new ParameterNode(new IdNode(exprContext.id.Text));
            } 
            if (boolExpressionContext != null && !boolExpressionContext.IsEmpty)
            {
                _boolNodeExtractor = new BoolNodeExtractor();
                BoolNode boolRes = _boolNodeExtractor.ExtractBoolNode(boolExpressionContext);

                return new ParameterNode(boolRes, ParameterNode.ParameterType.BoolExpression);
            }

            if (mathExpressionContext != null && !mathExpressionContext.IsEmpty)
            {
                _mathNodeExtractor = new MathNodeExtractor();
                MathNode mathRes = _mathNodeExtractor.ExtractMathNode(mathExpressionContext);
                return new ParameterNode(mathRes, ParameterNode.ParameterType.MathExpressionNode);
            }

            if (functionExpressionContext != null && !functionExpressionContext.IsEmpty)
            {
                _functionCallNodeExtractor = new FunctionCallExtractor();
                FunctionCallNode functionCallNode = _functionCallNodeExtractor.VisitFunctionCall(functionExpressionContext);
                
                return new FunctionCallParameterNode(functionCallNode);

            }
            
            return null;
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedParamContext context)
        {
            
            try
            {
                OGParser.PassedIDContext idValue = (OGParser.PassedIDContext) context;
                return VisitPassedID(idValue);
            }
            catch (InvalidCastException e)
            { }
            try
            {
                OGParser.PassedDirectValueContext expressionValue = (OGParser.PassedDirectValueContext) context;
                return ExtractParameterNode(expressionValue);
            }
            catch (InvalidCastException e)
            { }

            try
            {
                OGParser.PassedEndPointReferenceContext endPointContext =
                    (OGParser.PassedEndPointReferenceContext) context;
                
                throw new NotImplementedException("PassedEndPointReferenceContext --> ParameterNode");
            }
            catch (InvalidCastException e)
            { }
            
            try
            {
                OGParser.PassedStartPointReferenceContext startPointContext =
                    (OGParser.PassedStartPointReferenceContext) context;
                throw new NotImplementedException("PassedStartPointReferenceContext --> ParameterNode");
            }
            catch (InvalidCastException e)
            {

            }
            
            //Her opstår mutual rekursion. Vi skal lave function call nodes for at lave function call nodes-
           
            OGParser.PassedFunctionCallContext funcCallContext = (OGParser.PassedFunctionCallContext) context;
            return ExtractParameterNode(funcCallContext);
        }

        public override ParameterNode VisitPassedID(OGParser.PassedIDContext context)
        {
            return new ParameterNode(new IdNode(context.id.Text));
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedFunctionCallContext funcCallContext)
        {
            OGParser.FunctionCallContext functionCallContext = funcCallContext.funcCall;
            _functionCallNodeExtractor = new FunctionCallExtractor();
            FunctionCallNode funcCallNode = _functionCallNodeExtractor.VisitFunctionCall(functionCallContext);
            return new FunctionCallParameterNode(funcCallNode);
        }
    }

    public class FunctionCallExtractor : OGBaseVisitor<FunctionCallNode>
    {
        private ParameterNodeListBuilder _parameterNodeListBuilder = null;
        
        public override FunctionCallNode VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            List<ParameterNode> parameterNodes = new List<ParameterNode>();
            if (context.id.Text != String.Empty)
            {
                IdNode id = new IdNode(context.id.Text);
                parameterNodes = _parameterNodeListBuilder.VisitFunctionCall(context);

                return new FunctionCallNode(id, parameterNodes, context.GetText());
            }

            throw new AstNodeCreationException(
                "Something went wrong creating node from FunctionCallContext. " +
                "Function call Id empty or null.");
        }
    }
}