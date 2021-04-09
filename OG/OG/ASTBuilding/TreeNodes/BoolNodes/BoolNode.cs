namespace OG.ASTBuilding.TreeNodes.BoolNodes
{
    public class BoolNode : ValueNode
    {
        public enum BoolType
        {
            GenericBoolNode = 0,
            GenericInfixNode,
            EqualsNode,
            GreaterThanNode,
            LessThanNode,
            AndNode,
            OrNode,
            NegationNode,
            TrueNode,
            FalseNode,
            FunctionCallNode,
            IdValueNode
        }

        private BoolType BoolNodeType { get; set; } = 0;

        public BoolNode(string value, BoolType type):base(value,ExpressionType.BoolExpression)
        {
            BoolNodeType = type;
        }
        
        public override string ToString()
        {
            return "Type: " + BoolNodeType.ToString() + "\t Value: " + Value;
        }
    }
}