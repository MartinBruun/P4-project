using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public interface IFunctionCallNode
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
        
    }
}