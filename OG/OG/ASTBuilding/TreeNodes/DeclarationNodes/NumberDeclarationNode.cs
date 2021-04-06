using System;
using System.Runtime.CompilerServices;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class NumberDeclarationNode : DeclarationNode
    {
        public NumberDeclarationNode(IDNode id, MathNode assignedValue) : base(id, assignedValue)
        {
            Type = "NumberDeclaration";
            Value = assignedValue;
        }
    }
    
}