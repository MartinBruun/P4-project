using System.Collections.Generic;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class AssignmentNodeListBuild : AstBuilderErrorInheritor<List<AssignmentNode>>
    {
        
        private readonly List<AssignmentNode> _assignments = new List<AssignmentNode>();
        private readonly AssignmentNodeExtractor _assignmentNodeExtractor;

        public AssignmentNodeListBuild(List<SemanticError> errs) : base(errs)
        {
            _assignmentNodeExtractor = new AssignmentNodeExtractor(errs);
        }

        /// <summary>
        /// Visits a body context and extracts all assignments from it. Returns empty list if body contains no statements.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>List of AssignmentNodes or null</returns>
        public override List<AssignmentNode> VisitBody(OGParser.BodyContext context)
        {

            if (context.statements != null && !context.statements.IsEmpty)
            {
                return VisitStmts(context.statements);
            }
            
            return new List<AssignmentNode>();
            
        }
        
        /// <summary>
        /// Recursively visits Stmts and extracts AssignmentNodes them using a AssignmentNodeExtractor.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override List<AssignmentNode> VisitStmts(OGParser.StmtsContext context)
        {
            
            OGParser.StmtContext currentStatement = context.currentStatement;
            //If the current statement is not null or empty, visit it
            if (currentStatement != null && !currentStatement.IsEmpty)
            {
                AssignmentNode assignmentNode = _assignmentNodeExtractor.VisitStmt(currentStatement);

                if (assignmentNode != null)
                {
                    _assignments.Add(assignmentNode);
                }
            }
            
            
            OGParser.StmtsContext nextStatements = context.statements;
            //If there are more statements available, visit them recursively.
            if (nextStatements != null && !nextStatements.IsEmpty)
            {
                VisitStmts(nextStatements);
            }
            

            return _assignments;
        }
        /// <summary>
        /// Visits a statement, adds to inner property list and returns the list. Returns null if statement is not assignment.
        /// </summary>
        /// <param name="currentStatement"></param>
        /// <returns>List of AssignmentNodes or null </returns>
        public override List<AssignmentNode> VisitStmt(OGParser.StmtContext currentStatement)
        {
            OGParser.AssignmentContext currentAssignment = currentStatement.assign;
            //If the current statement is an assignment, extract it and add to Assignments.
            if (currentAssignment != null && !currentAssignment.IsEmpty)
            {
                _assignments.Add(_assignmentNodeExtractor.VisitAssignment(currentAssignment));
                return _assignments;
            }
            
            return null;
        }
    }
}