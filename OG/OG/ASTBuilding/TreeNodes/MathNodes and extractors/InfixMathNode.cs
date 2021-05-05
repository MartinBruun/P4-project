namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public abstract class InfixMathNode : MathNode, IInfixMathNode
    {
        private MathNode _rhs;
        private MathNode _lhs;

        public InfixMathNode(MathNode rhs, MathNode lhs, MathType mathType):base(rhs.ToString(),mathType)
        {
            LHS = lhs;
            RHS = rhs;
        }


        public MathNode RHS
        {
            get => _rhs;
            set
            {
                if (_rhs != null)
                {
                    _rhs.Parent = null;
                }
                _rhs = value;
                _rhs.Parent = this;
            }
        }

        public MathNode LHS
        {
            get => _lhs;
            set
            {
                if (_lhs != null)
                {
                    _lhs.Parent = null;
                }
                _lhs = value;
                _lhs.Parent = this;
            }
        }
    }

    public interface IInfixMathNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }

    }
}