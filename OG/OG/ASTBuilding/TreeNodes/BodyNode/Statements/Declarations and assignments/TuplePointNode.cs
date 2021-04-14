using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
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