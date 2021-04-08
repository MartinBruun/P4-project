using System;

namespace OG.ASTBuilding
{
    /// <summary>
    /// The template for all nodes in the AST, in which all Nodes must inherit from.
    /// </summary>
    public abstract class AstNode
    {
        public string Type { get; set; }
        public AstNode GetNextNode()
        {
            throw new NotImplementedException();
        }
    }
}