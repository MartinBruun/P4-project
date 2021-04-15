using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class IdNode : AstNode, IIdVisitable
    {
        public string Value { get; set; }

        public IdNode(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }

        public void Accept(IIdNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

 

    public interface IIdNode
    {
        public string Value { get; set; }
    }
}