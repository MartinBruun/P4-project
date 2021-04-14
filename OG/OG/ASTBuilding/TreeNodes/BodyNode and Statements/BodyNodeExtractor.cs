using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;


namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements
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

          
    

