using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.AstVisiting
{
    public interface IBoolNodeVisitor: IIdNodeVisitor, IBoolFuncCallVisitor
    {
        public void Visit(LessThanComparerNode node);
        public void Visit(GreaterThanComparerNode node);
        public void Visit(EqualsComparerNode node);
        public void Visit(NegationNode node);
        public void Visit(OrComparerNode node);
        public void Visit(AndComparerNode node);
        public void Visit(FalseNode node);
        public void Visit(TrueNode node);
    }
}