using OG.AST.Shapes;
using OG.AST.Terminals;

namespace OG.AST.Functions
{
    public class FunctionNode : ASTNode
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