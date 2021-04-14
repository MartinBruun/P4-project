using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class NumberDeclarationNode : DeclarationNode
    {
        public NumberDeclarationNode(IdNode id, MathNode assignedAssignedExpression) : base(id, assignedAssignedExpression, DeclarationType.NumberDeclarationNode)
        {

            AssignedExpression = assignedAssignedExpression;
        }
    }
    
}