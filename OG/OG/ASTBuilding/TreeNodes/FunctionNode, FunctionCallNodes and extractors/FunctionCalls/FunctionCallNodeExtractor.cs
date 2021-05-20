using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class FunctionCallNodeExtractor : AstBuilderErrorInheritor<FunctionCallNode>
    {
        private ParameterNodeListBuilder _parameterNodeListBuilder;
        
        public override FunctionCallNode VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            
            List<ParameterNode> parameterNodes = new List<ParameterNode>();
            if (context.id.Text != string.Empty)
            {
                IdNode id = new IdNode(context.id.Text);
                //Console.WriteLine("!!!Creating Functioncall:"+context.passedParams().GetText());
                parameterNodes = _parameterNodeListBuilder.VisitFunctionCall(context);
                
                FunctionCallNode F = new FunctionCallNode(id, parameterNodes, context.GetText());
                 F.Line =context.id.Line;
                 F.Column =context.id.Column;
                 return F; 
            }
            
            SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column, "Something went wrong creating node from FunctionCallContext. " +
                "Function call Id empty or null.")
            {
                IsFatal = true
            });
            return null;

        }

        public FunctionCallNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            _parameterNodeListBuilder = new ParameterNodeListBuilder(errs);
        }
    }
}