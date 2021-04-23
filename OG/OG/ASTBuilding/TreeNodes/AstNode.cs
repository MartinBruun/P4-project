using System.Data;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    /// <summary>
    /// The template for all nodes in the AST, in which all Nodes must inherit from.
    /// </summary>
    public abstract class AstNode: IVisitable
    {
        public string CompileTimeType;
        public int Line = 0;
        public int Column = 0;

        public abstract void Accept(IVisitor visitor);

    }

    public interface IAstNode
    {
    }
}