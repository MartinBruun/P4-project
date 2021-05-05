using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class OrComparerNode : BoolComparerNode
    {
        public OrComparerNode(BoolNode RHS, BoolNode LHS, string value ):base(RHS,LHS,value, BoolType.OrNode)
        {
            
        }

     
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}