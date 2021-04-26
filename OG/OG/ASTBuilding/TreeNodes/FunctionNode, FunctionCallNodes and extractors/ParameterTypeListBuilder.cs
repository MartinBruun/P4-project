using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace OG.ASTBuilding.TreeNodes
{
    public class ParameterTypeListBuilder : AstBuilderErrorInheritor<List<ParameterTypeNode>>
    {
        private List<ParameterTypeNode> _typeNodes = new List<ParameterTypeNode>();
        private ParameterTypeNodeExtractor _typeNodeExtractor;
        public override List<ParameterTypeNode> VisitVoidFunctionDCL(OGParser.VoidFunctionDCLContext context)
        {
            OGParser.ParameterDeclarationsContext c = context.paramDcls;
            return ExtractParamTypeList(context.paramDcls);
        }

        public override List<ParameterTypeNode> VisitReturnFunctionDCL(OGParser.ReturnFunctionDCLContext context)
        {
            return ExtractParamTypeList(context.paramDcls);
        }

        public List<ParameterTypeNode> ExtractParamTypeList(OGParser.ParameterDeclarationsContext c)
        {
            try
            {
                OGParser.MultiParamDclContext multipleParams = (OGParser.MultiParamDclContext) c;
                ExtractParamTypeList(multipleParams);
                return _typeNodes;
            }
            catch (InvalidCastException e)
            {}
            
            try
            {
                OGParser.SingleParamDclContext singleParams = (OGParser.SingleParamDclContext) c;
                ParameterTypeNode paramNode = new ParameterTypeNodeExtractor(SemanticErrors).VisitSingleParamDcl(singleParams);
                _typeNodes.Add(paramNode);
                List<ParameterTypeNode> res = new List<ParameterTypeNode>
                {
                    paramNode
                };

                
                return _typeNodes;
            }
            catch (InvalidCastException e)
            {}

            //No parameters
            return new List<ParameterTypeNode>();
        }
        
        public List<ParameterTypeNode> ExtractParamTypeList(OGParser.MultiParamDclContext context)
        {
            if (context.currentParamDcl != null)
            {
                OGParser.ParameterDclContext x = context.currentParamDcl;
                _typeNodes.Add(_typeNodeExtractor.ExtractParameterTypeNode(x));
            }

            if (context.paramDcls != null)
            {
                OGParser.ParameterDeclarationsContext p = context.paramDcls;
                ExtractParamTypeList(context.paramDcls);
            }

            return _typeNodes;
        }

        public ParameterTypeListBuilder(List<SemanticError> errs) : base(errs)
        {
             _typeNodeExtractor= new ParameterTypeNodeExtractor(errs);
        }
    }
}