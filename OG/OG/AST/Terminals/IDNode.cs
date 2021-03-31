namespace OG.AST.Terminals
{
    public class IDNode
    {
        public string Value { get; set; }

        public IDNode(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}