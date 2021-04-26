using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class MathFunctionCallNodeExtractor : AstBuilderErrorInheritor<MathFunctionCallNode>
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
            List<ParameterNode> parameterNodes = new List<ParameterNode>();
            _parameterListBuilder = new ParameterNodeListBuilder(SemanticErrors);
            IdNode id = new IdNode(context.id.Text);
           parameterNodes = _parameterListBuilder.VisitFunctionCall(context);
            return new MathFunctionCallNode(context.GetText(), id, parameterNodes);

        }

        public MathFunctionCallNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            
        }
    }
}

