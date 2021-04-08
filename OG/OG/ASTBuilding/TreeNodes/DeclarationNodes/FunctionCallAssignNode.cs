using System.Collections.Generic;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class FunctionCallAssignNode : AssignmentNode, IFunctionCallNode
    {
        public FunctionCallAssignNode(IDNode id, List<ParameterNode> parameters) : base(id, AssignmentType.FunctionCallAssignment)
        {
            FunctionName = id;
            Parameters = parameters;
        }

        public IDNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
}