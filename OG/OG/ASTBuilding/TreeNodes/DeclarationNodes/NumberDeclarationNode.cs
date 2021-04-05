using System;
using System.Runtime.CompilerServices;
using OG.AST.Shapes;
using OG.AST.Terminals;

namespace OG.AST.TreeNodes.DeclarationNodes
{
    public class NumberDeclarationNode : DeclarationNode
    {
        public NumberDeclarationNode(MathNode assignedValue)
        {
            Type = "NumberDeclaration";
            Value = assignedValue;
        }
    }
    
}