using System.Linq.Expressions;
using OG.AST.Terminals;
using OG.AST.TreeNodes.BodyNodes;

namespace OG.AST.Shapes
{
    public abstract class AssignmentNode : StatementNode
    {
        public IDNode Id { get; set; }
        public Expression AssignmentValue { get; set; }
    }
}