using System.Linq.Expressions;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.ASTBuilding.Shapes
{
    public class DeclarationNode : StatementNode
    {
        public IDNode Id { get; set; }
        public ExpressionNode Value { get; set; }

        public DeclarationNode(IDNode id, ExpressionNode startValue)
        {
            Id = id;
            Value = startValue;
        }
    }
}