using System;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class IdAssignNode : AssignmentNode
    {
        public IdNode AssignedValue { get; set; }

        public IdAssignNode(IdNode id, IdNode value) : base(id, AssignmentType.IdAssignment)
        {
            AssignedValue = value;
        }
    }
}