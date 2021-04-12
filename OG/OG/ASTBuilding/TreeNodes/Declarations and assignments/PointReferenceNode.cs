using System;
using System.Globalization;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    /// <summary>
    /// This one is iffy. Need to find a way to represent all point references. This gonna be hard.
    /// </summary>
    public abstract class PointReferenceNode : ValueNode
    {
        /// <summary>
        /// If both LHS and RHS is null, it must be startpointreference, endpointreference, or ID.
        /// </summary>
        ///
        
        public enum PointReferenceNodeType
        {
            PointIdNode,
            ShapeStartPointNode,
            ShapeEndPointNode,
            PointFunctionCallNode,
            NumberTupleNode
        }

        public PointReferenceNodeType PointReferenceType { get; set; }

        public PointReferenceNode(string pointText, PointReferenceNodeType pointRefNodeType)
            :base(pointText, ExpressionType.PointReference)
        {
            PointReferenceType = pointRefNodeType;
        }


    }
}