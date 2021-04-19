using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class IdAssignNode : AssignmentNode, IIdAssignVisitable
    {
        public IdNode AssignedValue { get; set; }

        public IdAssignNode(IdNode id, IdNode value) : base(id, AssignmentType.IdAssignment)
        {
            AssignedValue = value;
        }

        public void Accept(IIdAssignmentVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }

   
}