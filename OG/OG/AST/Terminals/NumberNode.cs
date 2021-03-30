using OG.AST;

namespace OG.AST.Terminals
{
    public class NumberNode<T> : ASTNode
    {
        public T Value { get; set; }

        public NumberNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}