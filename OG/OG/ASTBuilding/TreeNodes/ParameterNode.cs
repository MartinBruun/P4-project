namespace OG.ASTBuilding.Terminals
{
    public class ParameterNode : AstNode
    {
        public enum ParameterType
        {
            Id,
            FunctionCall,
            Expression,
            EndpointRef,
            StartPointRef,
        }

        public ParameterType ParamType { get; set; }
        public IDNode ParameterId { get; set; }

        public ParameterNode(IDNode id, ParameterType t)
        {
            ParamType = t;
            ParameterId = id;
        }
    }
}