using System;
using System.Collections.Generic;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class MathFunctionCallNodeExtractor : OGBaseVisitor<MathFunctionCallNode>
    {
        private ParameterNodeListBuilder _parameterListBuilder = null;

        /// <summary>
        /// Tries to create MathFunctionCallNodes from FunctionCallContext
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="AstNodeCreationException"></exception>
        public override MathFunctionCallNode VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            _parameterListBuilder = new ParameterNodeListBuilder();
            IdNode id = new IdNode(context.id.Text);
            List<ParameterNode> parameters = _parameterListBuilder.VisitFunctionCall(context);
            return new MathFunctionCallNode(context.GetText(), id, parameters);

        }
    }
}

