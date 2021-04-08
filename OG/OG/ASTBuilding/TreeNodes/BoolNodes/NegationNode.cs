namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class NegationNode : BoolNode
    {
        public BoolNode BoolExpression;

        public NegationNode(BoolNode expr, string value):base(value)
        {
            BoolExpression = expr;
        }
    }
}