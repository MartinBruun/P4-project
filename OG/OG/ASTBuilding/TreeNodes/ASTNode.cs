using System;

namespace OG.AST
{
    /// <summary>
    /// The template for all nodes in the AST, in which all Nodes must inherit from.
    /// </summary>
    public abstract class ASTNode
    {
        public string Type { get; set; }
        public ASTNode GetNextNode()
        {
            throw new NotImplementedException();
        }
    }
}