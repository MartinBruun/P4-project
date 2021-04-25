using System;
using Microsoft.Win32.SafeHandles;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    public class ParameterTypeNode : AstNode, IParameterTypeNodeVisitable
    {
        public IdNode IdNode { get; }

        public ParameterTypeNode(IdNode id, ParameterTypeNodeExtractor.IOgTyped.OgType parameterType)
        {
            IdNode = id;
            this.ParameterType = parameterType;
        }

        public ParameterTypeNode( IdNode id, ParameterTypeNodeExtractor.IOgTyped.OgType parameterType, int line, int column) : this(id, parameterType)
        {
            Line = line;
            Column = column;
        }



        public ParameterTypeNodeExtractor.IOgTyped.OgType ParameterType { get; }

        public override void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
            visitor.visit(this);
        }
    }
    
    public interface IParameterTypeNodeVisitable
    {
    }
}