using System;
using System.Linq.Expressions;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.ASTBuilding.Shapes
{
    public class DeclarationNode : StatementNode
    {
        public enum DeclarationType
        {
          NumberDeclarationNode = 0,
          BoolDeclarationNode,
          PointDeclarationNode
        }
        public IdNode Id { get; set; }
        public ExpressionNode AssignedExpression { get; set; }
        public DeclarationType DeclaredType { get; set; }

        public DeclarationNode(IdNode id, ExpressionNode startAssignedExpression, DeclarationType type)
        {
            DeclaredType = type;
            Id = id;
            AssignedExpression = startAssignedExpression;
        }
    }
}