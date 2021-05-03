using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.AstVisiting;
using IMathNodeVisitor = OG.CodeGeneration.IMathNodeVisitor;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class NumberNode: TerminalMathNode, IMathVisitable
    {
        public double NumberValue { get; set; }

        public NumberNode(double value):base(value.ToString(),MathType.NumberNode)
        {
            NumberValue = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override void Accept(OG.CodeGeneration.IMathNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }
}