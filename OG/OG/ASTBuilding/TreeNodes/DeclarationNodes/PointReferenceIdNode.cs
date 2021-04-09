using System;
using System.Collections.Generic;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.TreeNodes.DeclarationNodes
{
    public class PointReferenceIdNode : PointReferenceNode
    {
        public IdNode Id { get; set; }

        public PointReferenceIdNode(string pointText, IdNode id) : base(pointText, PointReferenceNodeType.PointIdNode)
        {
            Id = id;
        }
    }

    public class ShapeStartPointNode : ShapePointReference
    {
        public ShapeStartPointNode(string pointText, IdNode shapeName) : base(pointText,  shapeName, PointReferenceNodeType.ShapeStartPointNode)
        {
        }
    }
    
    public class ShapeEndPointNode : ShapePointReference
    {
        
        public ShapeEndPointNode(string pointText, IdNode shapeName) : base(pointText, shapeName, PointReferenceNodeType.ShapeEndPointNode)
        {
        }
    }

    public abstract class ShapePointReference : PointReferenceNode
    {
        public ShapePointReference(string pointText, IdNode shapeName, PointReferenceNodeType type):base(pointText, type)
        {
            ShapeName = shapeName;
        }
        public IdNode ShapeName { get; set; }
    }
    
    public class  PointFunctionCallNode : PointReferenceNode, IFunctionCallNode
    {
        public PointFunctionCallNode(string pointText, IdNode functionName, List<ParameterNode> functionParameters) : base(pointText, PointReferenceNodeType.PointFunctionCallNode)
        {
            Parameters = functionParameters;
            FunctionName = functionName;
        }

        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
    
    public class TuplePointNode : PointReferenceNode
    {
        public MathNode LHS { get; set; }
        public MathNode RHS { get; set; }

        public TuplePointNode(string pointText, MathNode lhs, MathNode rhs) : base(pointText, PointReferenceNodeType.NumberTupleNode)
        {
            RHS = rhs;
            LHS = lhs;
        }
    }
}