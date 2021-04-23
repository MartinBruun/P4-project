using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class FunctionCallNodeExtractor : OGBaseVisitor<FunctionCallNode>
    {
        private ParameterNodeListBuilder _parameterNodeListBuilder = new ParameterNodeListBuilder();
        
        public override FunctionCallNode VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            
            List<ParameterNode> parameterNodes = new List<ParameterNode>();
            if (context.id.Text != string.Empty)
            {
                IdNode id = new IdNode(context.id.Text);
                parameterNodes = _parameterNodeListBuilder.VisitFunctionCall(context);
                 FunctionCallNode F = new FunctionCallNode(id, parameterNodes, context.GetText());
                 F.Line =context.id.Line;
                 F.Column =context.id.Column;
                 return F;
            }

            throw new AstNodeCreationException(
                "Something went wrong creating node from FunctionCallContext. " +
                "Function call Id empty or null.");
        }
    }
}