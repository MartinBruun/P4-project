using System;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    /// <summary>
    /// TODO
    /// </summary>
    public class PointAssignmentNode : AssignmentNode
    { 
        public PointReferenceNode AssignedValue { get; set; }

        public PointAssignmentNode(IdNode id, PointReferenceNode point) : base(id, AssignmentType.VariableAssignmentNode)
        {
            AssignedValue = point;
        }

        public override string ToString()
        {
            return AssignedValue.ToString() + Id.ToString();
        }
    }
}