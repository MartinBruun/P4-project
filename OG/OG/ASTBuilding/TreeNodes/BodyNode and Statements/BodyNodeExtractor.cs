using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;


namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements
{
    public class BodyNodeExtractor : AstBuilderErrorInheritor<BodyNode>
    {
        public override BodyNode VisitBody(OGParser.BodyContext context)
        {
            List<StatementNode> statementNodes = new StatementListBuilder(SemanticErrors).VisitBody(context);
            return new BodyNode(statementNodes) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }

        public BodyNodeExtractor(List<SemanticError> errs) : base(errs)
        {
        }
    }
}






          
    

