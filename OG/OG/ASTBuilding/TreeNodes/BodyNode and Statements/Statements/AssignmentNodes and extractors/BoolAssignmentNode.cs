using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class BoolAssignmentNode : AssignmentNode
    {
        public BoolNode AssignedValue { get; set; }

        public BoolAssignmentNode(IdNode id, BoolNode value) : base(id, AssignmentType.VariableAssignmentNode)
        {
            AssignedValue = value;
        }

        public BoolAssignmentNode(BoolAssignmentNode node) : base(node)
        {
            AssignedValue = node.AssignedValue;
        }

        

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

   
}