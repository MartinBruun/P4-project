namespace OG.ASTBuilding.Terminals
{
    public class IDNode : ASTNode
    {
        public string Value { get; set; }

        public IDNode(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}