using System;
using System.Collections.Generic;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class ParameterNodeListBuilder : AstBuilderErrorInheritor<List<ParameterNode>>
    {
        private readonly ParameterNodeExtractor _paramExtractor;

        public ParameterNodeListBuilder(List<SemanticError> errs): base(errs)
        {
            _paramExtractor = new ParameterNodeExtractor(errs);
        }
        

        public override List<ParameterNode> VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            OGParser.PassedParamsContext parametersContext = context.@params;
            List<ParameterNode> parameters  = new List<ParameterNode>();
            parameters.AddRange(BuildParameterNodeList(parametersContext));
            return parameters;
        }

        public List<ParameterNode> BuildParameterNodeList(OGParser.PassedParamsContext context)
        {
            List<ParameterNode> parameters  = new List<ParameterNode>();
            try
            {
                try
                {
                    OGParser.SingleParameterContext singleParam = (OGParser.SingleParameterContext) context;


                    parameters.Add(_paramExtractor.VisitSingleParameter(singleParam));
                    return parameters;
                }
                catch (InvalidCastException)
                { }

                try
                {
                    OGParser.MultiParametersContext multipleParams = (OGParser.MultiParametersContext) context;
                    return VisitMultiParameters(multipleParams);
                 
                }
                catch (InvalidCastException)
                { }

                OGParser.NoParameterContext noParams = (OGParser.NoParameterContext) context;
                return parameters;
            }
            catch (InvalidCastException)
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column, 
                    "failed to typecast PassedParamsContext into OGParser.SingleParameterContext, " +
                    "OGParser.MultiParametersContext and OGParser.MultiParametersContext")
                {
                    IsFatal = true
                });
                return null;
            }
            
        }

        public override List<ParameterNode> VisitMultiParameters(OGParser.MultiParametersContext context)
        {
            List<ParameterNode> parameters  = new List<ParameterNode>();

            OGParser.PassedParamContext current = context.firstParameter;
            if (current != null && !current.IsEmpty)
            {
               parameters.Add(_paramExtractor.ExtractParameterNode(current));
               return parameters;
            }

            if (context.@params != null && !context.@params.IsEmpty)
            {                

                return BuildParameterNodeList(context.@params);
            }
            
            return parameters;
        }
        
    }
}