using System;
using System.Globalization;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    /// <summary>
    /// This one is iffy. Need to find a way to represent all point references. This gonna be hard.
    /// </summary>
    public class PointReferenceNode : ExpressionNode
    {
        /// <summary>
        /// If both LHS and RHS is null, it must be startpointreference, endpointreference, or ID.
        /// </summary>
        public MathNode LHS { get; set; } = null;
        public MathNode RHS { get; set; } = null;

        public ShapePointRefNode StartEndPoint = null;

        public IdNode AssignedValue = null;
        public FunctionCallNode FunctionCallId = null;
        public PointReferenceType PointRefType { get; set; }

        public enum PointReferenceType
        {
            NumberTuple = 0,
            StartPoint,
            EndPoint,
            IdPoint,
            FunctionCall
        }

        public PointReferenceNode(string value, MathNode rhs, MathNode lhs)
            :base(value, ExpressionType.PointReference)
        {
            PointRefType = PointReferenceType.NumberTuple;
            LHS = lhs;
            RHS = rhs;
            AssignedValue = null;
        }
        public PointReferenceNode(string value, IdNode id)
            :base(value, ExpressionType.PointReference)
        {
            PointRefType = PointReferenceType.IdPoint;
            AssignedValue = id;
            LHS = null;
            RHS = null;
        }
        
        public PointReferenceNode(string value, ShapePointRefNode spRef)
            :base(value, ExpressionType.PointReference)
        {
            if (StartEndPoint.PointType == ShapePointRefNode.PointTypes.StartPoint)
            {
                PointRefType = PointReferenceType.StartPoint;
            }
            else
            {
                PointRefType = PointReferenceType.EndPoint;
            }
            StartEndPoint = spRef;
        }
        public PointReferenceNode(string value, FunctionCallNode funcCall)
            :base(value, ExpressionType.PointReference)
        {
            PointRefType = PointReferenceType.FunctionCall;
            FunctionCallId = funcCall;
        }
    }
}