using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes
{
    public class NumberIterationNode : IterationNode
    {
        public MathNode iterations;
        

        public NumberIterationNode(MathNode numberOfIterations, BodyNode bodyNode):base(bodyNode)
        {
            iterations = numberOfIterations;
        }

    }
}