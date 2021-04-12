using System;
using System.Collections.Generic;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.Shapes
{
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