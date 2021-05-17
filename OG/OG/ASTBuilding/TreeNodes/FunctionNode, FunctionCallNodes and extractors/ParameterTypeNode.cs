using System;
using Microsoft.Win32.SafeHandles;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;
using OG.CodeGeneration;

namespace OG.ASTBuilding.TreeNodes
{
    public class ParameterTypeNode : AstNode
    {
        public IdNode IdNode { get; set; }
        public ExpressionNode Expression { get; set; } = null;
        public ParameterTypeNodeExtractor.IOgTyped.OgType ParameterType { get; }

        public ParameterTypeNode(IdNode id, ParameterTypeNodeExtractor.IOgTyped.OgType parameterType)
        {
            IdNode = id;
            ParameterType = parameterType;
        }

        public ParameterTypeNode( IdNode id, ParameterTypeNodeExtractor.IOgTyped.OgType parameterType, int line, int column) : this(id, parameterType)
        {
            Line = line;
            Column = column;
        }
        public ParameterTypeNode(ParameterTypeNode node) : base(node)
        {
            IdNode = node.IdNode;
            Expression = node.Expression;
            ParameterType = node.ParameterType;
        }

        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}