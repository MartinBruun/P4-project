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
            
            foreach (ParameterNode parameterNode in parameters)
            {
                if (parameterNode == null)
                {
                    Console.WriteLine("param is NULL!!!!!!");
                }
                else
                {
                    Console.WriteLine("Found type: " + parameterNode.ParamType);
                }
            }

            Console.WriteLine("END OF FOREACH 123\n");
            
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
                    List<ParameterNode> x = VisitMultiParameters(multipleParams);
                   
                    parameters.AddRange(x);
                    return parameters;
                }
                catch (InvalidCastException)
                { }
                
             
                OGParser.SingleParameterContext singleParam = (OGParser.SingleParameterContext) context;
                ParameterNode result = _paramExtractor.VisitSingleParameter(singleParam);
                Console.WriteLine(result.Expression.Value);
                parameters.Add(result);
                return parameters;


            }
            catch (Exception e)
            {
                
    
                SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column, 
                    "failed to typecast PassedParamsContext into OGParser.SingleParameterContext, " +
                    "OGParser.MultiParametersContext and OGParser.MultiParametersContext")
                {
                    IsFatal = true
                });
                return null;
            }

            Console.WriteLine();
            foreach (ParameterNode param in parameters)
            {
                Console.Write("Parameters are: " + param.Expression.Value);
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
            List<ParameterNode> parameters = new List<ParameterNode>();
            OGParser.PassedParamContext current = context.firstParameter;
            OGParser.PassedParamsContext nextParams = context.@params;
            
            
            if (current != null && !current.IsEmpty)
            {
                parameters.Add(_paramExtractor.ExtractParameterNode(current));
            }

            if (context.passedParams() != null )
            {
                OGParser.PassedParamsContext x = context.passedParams();
                parameters.AddRange(BuildParameterNodeList(context.@params));
            }
            
            return parameters;
        }
        
    }
}