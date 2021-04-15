using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public class LessThanComparerNode : MathComparerNode, IBoolNodeVisitable
    {
        public LessThanComparerNode(MathNode LHS, MathNode RHS, string value)
            : base(RHS, LHS, value, BoolType.LessThanNode)
        {
            
        }


        public void Accept(IBoolNodeVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}