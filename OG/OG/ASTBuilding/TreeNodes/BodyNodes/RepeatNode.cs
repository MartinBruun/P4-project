using OG.AST.Terminals;

namespace OG.AST.TreeNodes.BodyNodes.CommandNodes
{
    public class NumberIterationNode : IterationNode
    {
        public MathNode iterations;

        public NumberIterationNode(MathNode numberOfIterations)
        {
            iterations = numberOfIterations;
        }

    }
}