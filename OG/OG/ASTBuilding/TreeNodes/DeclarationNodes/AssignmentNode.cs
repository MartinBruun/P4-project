using System.Linq.Expressions;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.ASTBuilding.Shapes
{
    public class AssignmentNode : StatementNode
    {
        public IDNode Id { get; set; }
        public AssignmentNode(IDNode id)
        {
            
        }
    }
}