namespace OG.ASTBuilding.Terminals
{
    public class IdNode : AstNode
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
    }
}