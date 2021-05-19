using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class UntilNode : IterationNode
    {
        public BoolNode Predicate;

        public UntilNode(BoolNode condition, BodyNode body):base(body)
        {
            Predicate = condition;
        }

        public UntilNode(UntilNode node) : base(node)
        {
            Predicate = node.Predicate;
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}