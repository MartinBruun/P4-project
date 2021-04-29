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
                    OGParser.MultiParametersContext multipleParams = (OGParser.MultiParametersContext) context;

                    parameters.AddRange(VisitMultiParameters(multipleParams));
                    
                }
                catch (InvalidCastException)
                { }
                
                try
                {
                    OGParser.SingleParameterContext singleParam = (OGParser.SingleParameterContext) context;
                    Console.WriteLine("single param " + singleParam);

                    parameters.Add(_paramExtractor.VisitSingleParameter(singleParam));
                    
                    // return parameters;
                }
                catch (InvalidCastException)
                { }

                OGParser.NoParameterContext noParams = (OGParser.NoParameterContext) context;
                
                return parameters;
            }
            catch (Exception)
            {

                SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column, 
                    "failed to typecast PassedParamsContext into OGParser.SingleParameterContext, " +
                    "OGParser.MultiParametersContext and OGParser.MultiParametersContext")
                {
                    IsFatal = true
                });
                return null;
            }
            
            return parameters;
            
        }


        // public virtual ParameterNode makeParamNode(OGParser.PassedParamsContext context)
        // {
        //     if (context.ChildCount == 0){
        //         return new ParameterNode(); 
        //     }
        //
        // }
        

        public override List<ParameterNode> VisitMultiParameters(OGParser.MultiParametersContext context)
        {
            Console.WriteLine("!!!!visitMulti : " + context.GetText());
            List<ParameterNode> parameters = new List<ParameterNode>();
            OGParser.PassedParamContext current = context.firstParameter;
            
            
            
        if (current != null && !current.IsEmpty)
            {
                Console.WriteLine("jeg finder denne: " + current.GetText());
                parameters.Add(_paramExtractor.ExtractParameterNode(current));
               
            }

            if (context.passedParams() != null )
            {                
                
                Console.WriteLine("jeg Build : "+context.GetText() );
                return BuildParameterNodeList(context.@params);
            }
            
            return parameters;
        }
        
    }
}