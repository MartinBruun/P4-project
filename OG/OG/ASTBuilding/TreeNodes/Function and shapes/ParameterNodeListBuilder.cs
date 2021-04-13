using System;
using System.Collections.Generic;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class ParameterNodeListBuilder : OGBaseVisitor<List<ParameterNode>>
    {
        private List<ParameterNode> Parameters { get; set; } = new List<ParameterNode>();
        private readonly ParameterNodeExtractor _paramExtractor = new ParameterNodeExtractor();

        public override List<ParameterNode> VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            OGParser.PassedParamsContext parametersContext = context.@params;
            Parameters.AddRange(BuildParameterNodeList(parametersContext));
            return Parameters;
        }

        public List<ParameterNode> BuildParameterNodeList(OGParser.PassedParamsContext parameters)
        {
            
            try
            {
                try
                {
                    OGParser.SingleParameterContext singleParam = (OGParser.SingleParameterContext) parameters;
                    
                    Parameters.Add(_paramExtractor.VisitSingleParameter(singleParam));
                    return Parameters;
                }
                catch (InvalidCastException)
                { }

                try
                {
                    OGParser.MultiParametersContext multipleParams = (OGParser.MultiParametersContext) parameters;
                    return VisitMultiParameters(multipleParams);
                 
                }
                catch (InvalidCastException)
                { }

                OGParser.NoParameterContext noParams = (OGParser.NoParameterContext) parameters;
                return new List<ParameterNode>();
            }
            catch (InvalidCastException)
            {
                throw new AstNodeCreationException(
                    "failed to typecast PassedParamsContext into OGParser.SingleParameterContext, " +
                    "OGParser.MultiParametersContext and OGParser.MultiParametersContext");
            }
            
        }

        public override List<ParameterNode> VisitMultiParameters(OGParser.MultiParametersContext context)
        {

            OGParser.PassedParamContext current = context.firstParameter;
            if (current != null && !current.IsEmpty)
            {
               
               Parameters.Add(_paramExtractor.ExtractParameterNode(current));
               return Parameters;
            }

            if (context.@params != null && !context.@params.IsEmpty)
            {                

                return BuildParameterNodeList(context.@params);
            }
            
            return Parameters;
        }
        
    }
}