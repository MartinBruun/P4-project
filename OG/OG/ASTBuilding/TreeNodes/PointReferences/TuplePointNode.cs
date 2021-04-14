using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class TuplePointNode : PointReferenceNode
    {
        public MathNode XValue { get; set; }
        public MathNode YValue { get; set; }

        public TuplePointNode(string pointText, MathNode xValue, MathNode yValue) : base(pointText, PointReferenceNodeType.NumberTupleNode)
        {
            YValue = yValue;
            XValue = xValue;
        }
    }
}