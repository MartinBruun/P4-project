using System;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class IdAssignNode : AssignmentNode
    {
        public IDNode AssignedValue { get; set; }

        public IdAssignNode(IDNode id, IDNode value) : base(id)
        {
            AssignedValue = value;
        }
    }
}