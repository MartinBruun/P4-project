using OG.AST.Terminals;

namespace OG.AST.Functions
{
    public class FunctionDeclarationNode
    {
        public IDNode ID { get; set; }

        public FunctionDeclarationNode(IDNode id)
        {
            ID = id;
        }
        public override string ToString()
        {
            return "FunctionNode with ID: " + ID.ToString();
        }
    }
}