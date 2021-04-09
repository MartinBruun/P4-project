using System;
using System.Globalization;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

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


        public PointReferenceNode(string value, MathNode rhs, MathNode lhs)
            :base(value, ExpressionType.PointReference)
        {
            LHS = lhs;
            RHS = rhs;
            AssignedValue = null;
        }
        public PointReferenceNode(string value, IdNode id)
            :base(value, ExpressionType.PointReference)
        {
            AssignedValue = id;
            LHS = null;
            RHS = null;
        }
        
        public PointReferenceNode(string value, ShapePointRefNode spRef)
            :base(value, ExpressionType.PointReference)
        {
            StartEndPoint = spRef;
        }
    }
}