using System.Collections.Generic;

namespace OG.ASTBuilding.Shapes
{
    public class AssignmentsExtractor : ErrorInheritorVisitor<List<AssignmentNode>>
    {
        public List<SemanticError> SemanticErrors { get; set; }
        private readonly List<AssignmentNode> _assignments = new List<AssignmentNode>();
        private readonly AssignmentExtractor _extractor;

        public AssignmentsExtractor(List<SemanticError> errs) : base(errs)
        {
            _extractor = new AssignmentExtractor(errs);
        }

        public override List<AssignmentNode> VisitBody(OGParser.BodyContext body)
        {
            OGParser.StmtsContext statements = body.statements;
            
            if (statements != null && !statements.IsEmpty)
                return VisitStmts(statements);
            else 
                return base.VisitBody(body);
        }
        
        /// <summary>
        /// Recursively visits Stmts and extracts AssignmentNodes them using a AssignmentExtractorVisitor.
        /// </summary>
        /// <param name="statements"></param>
        /// <returns></returns>
        public override List<AssignmentNode> VisitStmts(OGParser.StmtsContext statements)
        {
            OGParser.StmtContext currentStatement = statements.currentStatement;
            //If the current statement is not null or empty, visit it
            if (currentStatement != null && !currentStatement.IsEmpty)
                VisitStmt(currentStatement);
            
            
            OGParser.StmtsContext nextStatements = statements.statements;
            //If there are more statements available, visit them recursively.
            if (nextStatements != null && !nextStatements.IsEmpty)
            {
                VisitStmts(nextStatements);
            }
            
            //Results are added to list property, not returned
            return base.VisitStmts(statements);
        }

        public override List<AssignmentNode> VisitStmt(OGParser.StmtContext currentStatement)
        {
            OGParser.AssignmentContext currentAssignment = currentStatement.assignment();
            //If the current statement is an assignment, extract it and add to Assignments.
            if (currentAssignment != null && !currentAssignment.IsEmpty)
            {
                _assignments.Add(_extractor.Extract(currentAssignment));
            }

            //Results are added to list property, not returned
            return base.VisitStmt(currentStatement);
        }
    }
}