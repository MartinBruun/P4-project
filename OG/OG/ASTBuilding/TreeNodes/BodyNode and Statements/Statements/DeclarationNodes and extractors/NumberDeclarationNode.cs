using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class NumberDeclarationNode : DeclarationNode
    {
        public NumberDeclarationNode(IdNode id, ExpressionNode assignedAssignedExpression) : base(id, assignedAssignedExpression, DeclarationType.NumberDeclarationNode)
        {
            AssignedExpression = assignedAssignedExpression;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);

        }

        public override string ToString()
        {
            return "Number: " + Id + "  Assigned value: " + AssignedExpression;
        }
    }
    
}