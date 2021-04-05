using OG.AST.Shapes;
using OG.AST.Terminals;
using OG.AST.TreeNodes.BoolNodes;

namespace OG.AST.TreeNodes.DeclarationNodes
{
    public class BoolDeclarationNode : DeclarationNode
    {


        public BoolDeclarationNode(IDNode id, BoolNode assignmentValue)
        {
            Id = id;
            Value = assignmentValue;
        }

    }
    



}