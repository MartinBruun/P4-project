namespace OG.ASTBuilding.Terminals
{
    public class MathIdNode : TerminalMathNode
    {
        public IdNode AssignedValueId { get; set; }

        public MathIdNode(string value, IdNode assignedValueId) : base(value, MathType.IdValueNode)
        {
            this.AssignedValueId = assignedValueId;
        }
    }
}