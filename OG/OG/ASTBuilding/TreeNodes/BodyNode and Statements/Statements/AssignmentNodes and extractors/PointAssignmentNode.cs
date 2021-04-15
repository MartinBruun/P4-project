using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{

    public class PointAssignmentNode : AssignmentNode, IPointAssignmentVisitable
    { 
        public PointReferenceNode AssignedValue { get; set; }

        public PointAssignmentNode(IdNode id, PointReferenceNode point) : base(id, AssignmentType.VariableAssignmentNode)
        {
            AssignedValue = point;
        }

        public override string ToString()
        {
            return AssignedValue.ToString() + Id.ToString();
        }

        public void Accept(IPointReferenceAssignmentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    
    public interface IPointAssignmentVisitable
    {
        public void Accept(IPointReferenceAssignmentVisitor visitor);
    }
}