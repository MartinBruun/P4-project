using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.TerminalNodes
{
    public class IdNode : ExpressionNode
    {
        public string SymboltableAddress { get; set; }
        public string PointingAt
        {
            get { return _pointingAt == null ? SymboltableAddress : _pointingAt; }
            set
            {
                _pointingAt = value;
                if (SymboltableAddress == null)
                {
                    SymboltableAddress = value;
                } 
            }
        }

        private string _pointingAt = null;
        public AstNode DeclaredValue { get; set; }

        public IdNode(string value) : base(value,ExpressionType.SingleId)
        {
            
        }

        public IdNode(IdNode node) : base(node)
        {
            SymboltableAddress = node.SymboltableAddress;
            PointingAt = node.PointingAt;
            DeclaredValue = node.DeclaredValue;
        }
        public override string ToString()
        {
            return Value;
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}