using System;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MathIdNode : TerminalMathNode
    {
        public IdNode AssignedValueId { get; set; }

        public MathIdNode(string value, IdNode assignedValueId) : base(value, MathType.IdValueNode)
        {
            this.AssignedValueId = assignedValueId;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);        
        }
        public override  NumberNode Accept(CodeGeneration.IMathNodeVisitor visitor)
        {
            return visitor.Visit(this);
        }

      
    }
}