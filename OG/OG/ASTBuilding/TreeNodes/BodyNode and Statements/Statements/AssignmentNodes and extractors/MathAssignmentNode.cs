using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MathAssignmentNode : AssignmentNode
    {
        public MathNode AssignedValue { get; set; }

        public MathAssignmentNode(IdNode id, MathNode value) : base(id, AssignmentType.VariableAssignmentNode)
        {

            AssignedValue = value;

        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }

   
}