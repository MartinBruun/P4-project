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
        public int Line;
        public int Column;

        public abstract void Accept(IVisitor visitor);

        public AstNode()
        {
            
        }

        public AstNode(int line, int column)
        {
            Line = line;
            Column = column;
        }
    }

    public interface IAstNode 
    {
    }
}