using System.Collections.Generic;
using Antlr4.Runtime;
using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class DeclarationExtractor : ErrorInheritorVisitor<DeclarationNode>
    {
        public DeclarationExtractor(List<SemanticError> errs) : base(errs)
        {
        }


        public DeclarationNode Extract()
        {
            throw new System.NotImplementedException();
        }

        public void SetContext(ParserRuleContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}