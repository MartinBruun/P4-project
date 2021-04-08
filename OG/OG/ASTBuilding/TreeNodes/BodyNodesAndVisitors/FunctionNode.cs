using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Functions
{
    public class FunctionNode : AstNode
    {
        public IDNode Id { get; set; }

        public string ReturnType { get; set; }
        public BodyNode Body;

        public FunctionNode(IDNode id, string returnType, BodyNode body)
        {
            Id = id;
            ReturnType = returnType;
            this.Body = body;
        }
        public override string ToString()
        {
            return "FunctionNode with ID: " + Id.ToString();
        }
    }
}