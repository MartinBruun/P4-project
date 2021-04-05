using System;
using OG.AST.Terminals;

namespace OG.AST.TreeNodes.DeclarationNodes
{
    public class NumberDeclarationNode : ASTNode
    {
        
        public IMathNode value;

        public NumberDeclarationNode(IMathNode assignedValue)
        {
            Type = "NumberDeclaration";
            value = assignedValue;
        }
    }
    
}