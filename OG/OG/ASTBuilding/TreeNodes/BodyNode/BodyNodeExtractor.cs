
using System.Collections.Generic;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.AST.Functions
{
    public class BodyNodeExtractor : OGBaseVisitor<BodyNode>
    {
        public override BodyNode VisitBody(OGParser.BodyContext context)
        {
            List<StatementNode> statementNodes = new StatementListBuilder().VisitBody(context);
            return new BodyNode(statementNodes);
        }

    }
}





//Try and extract assignments, declarations and commands from the current statement.

          
    

