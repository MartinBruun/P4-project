using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class TuplePointNode : PointReferenceNode
    {
        public MathNode LHS { get; set; }
        public MathNode RHS { get; set; }

        public TuplePointNode(string pointText, MathNode lhs, MathNode rhs) : base(pointText, PointReferenceNodeType.NumberTupleNode)
        {
            RHS = rhs;
            LHS = lhs;
        }
    }
}