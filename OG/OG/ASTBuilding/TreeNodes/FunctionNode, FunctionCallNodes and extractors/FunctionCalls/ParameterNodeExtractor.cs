using System;
using System.Collections.Generic;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class ParameterNodeExtractor : AstBuilderErrorInheritor<ParameterNode>
    {
        private BoolNodeExtractor _boolNodeExtractor;
        private MathNodeExtractor _mathNodeExtractor;
        private FunctionCallNodeExtractor _functionCallNodeNodeExtractor;

        public ParameterNodeExtractor(List<SemanticError> errs ) :base (errs)
        {
            _mathNodeExtractor = null;
        }
        

        public override ParameterNode VisitSingleParameter(OGParser.SingleParameterContext context)
        {
            ParameterNode result =  ExtractParameterNode(context.parameter);
            return result;
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedDirectValueContext context)
        {
            
            OGParser.ExpressionContext exprContext = context.expr;
            
            
            OGParser.BoolExpressionContext boolExpressionContext = context.expr.boolExpression();
            OGParser.MathExpressionContext mathExpressionContext = context.expr.mathExpression();
            OGParser.FunctionCallContext functionExpressionContext = context.expr.functionCall();


            if (
                (exprContext != null && !exprContext.IsEmpty 
                                     && exprContext.id != null 
                                     && string.IsNullOrEmpty(exprContext.id.Text))
            )
            {


                return new ParameterNode(new IdNode(exprContext.id.Text));
            } 
            if (boolExpressionContext != null && !boolExpressionContext.IsEmpty)
            {
                _boolNodeExtractor = new BoolNodeExtractor(SemanticErrors);
                BoolNode boolRes = _boolNodeExtractor.ExtractBoolNode(boolExpressionContext);

                return new ParameterNode(boolRes, ParameterNode.ParameterType.BoolExpression);
            }

            if (mathExpressionContext != null && !mathExpressionContext.IsEmpty)
            {

                _mathNodeExtractor = new MathNodeExtractor(SemanticErrors);
                MathNode mathRes = _mathNodeExtractor.ExtractMathNode(mathExpressionContext);
                return new ParameterNode(mathRes, ParameterNode.ParameterType.MathExpressionNode);
            }

            if (functionExpressionContext != null && !functionExpressionContext.IsEmpty)
            {
                _functionCallNodeNodeExtractor = new FunctionCallNodeExtractor(SemanticErrors);
                FunctionCallNode functionCallNode = _functionCallNodeNodeExtractor.VisitFunctionCall(functionExpressionContext);
                
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
            catch (InvalidCastException )
            { }
            try
            {
                OGParser.PassedDirectValueContext expressionValue = (OGParser.PassedDirectValueContext) context;
               
                return ExtractParameterNode(expressionValue);
            }
            catch (InvalidCastException )
            { }

            try
            {
                OGParser.PassedEndPointReferenceContext endPointContext =
                    (OGParser.PassedEndPointReferenceContext) context;

                return VisitPassedEndPointReference(endPointContext);
            }
            catch (InvalidCastException )
            { }
            
            try
            {
                OGParser.PassedStartPointReferenceContext startPointContext =
                    (OGParser.PassedStartPointReferenceContext) context;
                return VisitPassedStartPointReference(startPointContext);
            }
            catch (InvalidCastException )
            {
            }

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
            _functionCallNodeNodeExtractor = new FunctionCallNodeExtractor(SemanticErrors);
            FunctionCallNode funcCallNode = _functionCallNodeNodeExtractor.VisitFunctionCall(functionCallContext);
            return new FunctionCallParameterNode(funcCallNode);
        }


        public override ParameterNode VisitPassedStartPointReference(OGParser.PassedStartPointReferenceContext context)
        {
            OGParser.StartPointReferenceContext startPRefContext = context.startpointRef;
            PointReferenceNode pointRef = new PointReferenceNodeExtractor(SemanticErrors).ExtractPointReferenceNode(startPRefContext);
            return new ParameterNode(new IdNode(context.startpointRef.id.Text), pointRef);
        }

        public override ParameterNode VisitPassedEndPointReference(OGParser.PassedEndPointReferenceContext context)
        {
            OGParser.EndPointReferenceContext endpointContext = context.endpointRef;
            PointReferenceNode pointRef = new PointReferenceNodeExtractor(SemanticErrors).ExtractPointReferenceNode(endpointContext);
            return new ParameterNode(new IdNode(context.endpointRef.id.Text), pointRef);
        }
    }
}