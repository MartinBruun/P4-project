using System;
using System.Runtime.CompilerServices;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class NumberDeclarationNode : DeclarationNode
    {
        public NumberDeclarationNode(IdNode id, MathNode assignedAssignedExpression) : base(id, assignedAssignedExpression, DeclarationType.NumberDeclarationNode)
        {

            AssignedExpression = assignedAssignedExpression;
        }
    }
    
}