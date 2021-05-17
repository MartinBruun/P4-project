using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class NumberIterationNode : IterationNode
    {
        public MathNode Iterations;

        public NumberIterationNode(MathNode numberOfIterations, BodyNode bodyNode):base(bodyNode)
        {
            Iterations = numberOfIterations;
        }

        public NumberIterationNode(NumberIterationNode node) : base(node)
        {
            Iterations = node.Iterations;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}