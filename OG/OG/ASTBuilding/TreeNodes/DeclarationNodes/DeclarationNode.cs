using System.Linq.Expressions;
using OG.AST.Terminals;
using OG.AST.TreeNodes;
using OG.AST.TreeNodes.BodyNodes;

namespace OG.AST.Shapes
{
    public abstract class DeclarationNode : StatementNode
    {
        public IDNode Id { get; set; }
        public ExpressionNode Value { get; set; }
    }
}