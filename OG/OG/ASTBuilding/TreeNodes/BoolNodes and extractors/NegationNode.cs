namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class NegationNode : BoolNode
    {
        public BoolNode BoolExpression;

        public NegationNode(BoolNode boolExpr, string value):base(value, BoolType.NegationNode)
        {
            BoolExpression = boolExpr;
        }
    }

    public interface IPreFixBoolNode
    {
        
    }

    public interface INegationNode : IPreFixBoolNode
    {
        public BoolNode BoolExpression { get; set; }
    }
}