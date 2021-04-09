using System;
using System.Runtime.CompilerServices;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class NumberDeclarationNode : DeclarationNode
    {
        public NumberDeclarationNode(IdNode id, MathNode assignedAssignedValue) : base(id, assignedAssignedValue, DeclarationType.NumberDeclarationNode)
        {

            AssignedValue = assignedAssignedValue;
        }
    }
    
}