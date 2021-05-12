using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors
{
    public abstract class MathComparerNode : BoolNode, IMathComparerNode
    {
        private MathNode _rhs;
        private MathNode _lhs;

        protected MathComparerNode(MathNode lhs, MathNode rhs,string value, BoolType type) : base(value, type)
        {
            RHS = rhs;
            LHS = lhs;
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

    public interface IMathComparerNode
    {
        public MathNode RHS { get; set; }
        public MathNode LHS { get; set; }
    }
}