namespace OG.AST.TreeNodes.BoolNodes
{
    public class InfixBoolNode
    {
       
            public AstBoolNode RHS { get; set; }
            public AstBoolNode LHS { get; set; }
        

    }
        public class AstBoolNode : InfixBoolNode
        {
        
        }
}