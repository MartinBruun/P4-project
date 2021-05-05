namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class InfixMathNode : MathNode, IInfixMathNode
    {
        private MathNode _rhs;
        private MathNode _lhs;
        public MathNode RHS
        {
            get => _rhs;
            set
            {
                _rhs = value;
                _rhs.Parent = null; //Abandon child when adopting a new one
                _rhs.Parent = this;
            }
        }

        public MathNode LHS
        {
            get => _lhs;
            set
            {
                _lhs = value;
                _lhs.Parent = null; //Abandon child when adopting a new one
                _lhs.Parent = this;
            }
        }

        public InfixMathNode(MathNode rhs, MathNode lhs, MathType mathType):base(rhs.ToString(),mathType)
        {
            LHS = lhs;
            RHS = rhs;
        }


       
    }

    public interface IInfixMathNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }

    }
}