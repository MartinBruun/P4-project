using System.Collections.Generic;

namespace OG.ASTBuilding.Terminals
{
    public interface IFunctionCallNode
    {
        public IDNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
        
    }
}