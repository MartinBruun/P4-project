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

    

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }

  
}