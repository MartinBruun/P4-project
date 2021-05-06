using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class IdNode : AstNode
    {
        public string Value { get; set; }
        public string SymboltableAddress { get; set; }
        public string PointingAt
        {
            get { return _pointingAt == null ? SymboltableAddress : _pointingAt; }
            set { _pointingAt = value; }
        }

        private string _pointingAt = null;
        public AstNode DeclaredValue { get; set; }

        public IdNode(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
        
        
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
    }

 


}