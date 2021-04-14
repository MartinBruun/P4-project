using System;

namespace OG.ASTBuilding.TreeNodes
{
    /// <summary>
    /// Used if we ever want a node that can hold both math or bool. 
    /// </summary>
    public abstract class ExpressionNode : AstNode
    {
        public enum ExpressionType
        {
            MathExpression = 0,
            BoolExpression,
            SingleId,
            FunctionCall,
            PointReference
            
        }

        public ExpressionType ExprType;
        public string Value;

        public ExpressionNode(string exprText, ExpressionType exprType )
        {
            this.ExprType = exprType;
            Value = exprText;
        }


    }
}