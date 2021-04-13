using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BodyNodes;

namespace OG.AST.Functions
{
    public class StatementListBuilder : OGBaseVisitor<List<StatementNode>>
    {
        private StatementNodeExtractor _statementNodeExtractor = new StatementNodeExtractor();
        private List<StatementNode> _statements = new List<StatementNode>();

        public override List<StatementNode> VisitBody(OGParser.BodyContext context)
        {
            VisitStmts(context.statements);
            return _statements;
        }

        public override List<StatementNode> VisitStmts(OGParser.StmtsContext context)
        {
            
            if (context.currentStatement != null && !context.currentStatement.IsEmpty)
            {
                _statements.Add(_statementNodeExtractor.VisitStmt(context.currentStatement));
            }
            if (context.statements != null && !context.statements.IsEmpty)
            {
                VisitStmts(context.statements);
            }

            return _statements;
        }
    }
}