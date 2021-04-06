namespace OG.ASTBuilding.TreeNodes
{
    /// <summary>
    /// Used if we ever want a node that can hold both math or bool. 
    /// </summary>
    public class ExpressionNode : ASTNode
    {
        public string Value;

        public ExpressionNode(string expr)
        {
            Value = expr;
        }

        public ExpressionNode()
        {
            
        }
    }
}