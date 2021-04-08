using System.Collections.Generic;
using Antlr4.Runtime;
using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class DeclarationNodeExtractor : OGBaseVisitor<DeclarationNode>
    {
        public readonly MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
    
        
        

        public DeclarationNode ExtractDeclarationNode(OGParser.DeclarationContext currentDeclaration)
        {
            throw new System.NotImplementedException();
        }
    }
}