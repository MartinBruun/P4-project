using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.AstVisiting
{
    public interface IMathNodeVisitor 
    {
        public void Visit(AdditionNode node);
        public void Visit(SubtractionNode node);
        public void Visit(MultiplicationNode node);
        public void Visit(DivisionNode node);
        public void Visit(NumberNode node);
        public void Visit(MathIdNode node);
        public void Visit(PowerNode node);

    }
}