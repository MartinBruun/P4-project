using System;
using System.Collections.Generic;

namespace OG.ASTBuilding.Shapes
{
    public class AssignmentNodeListBuild : OGBaseVisitor<List<AssignmentNode>>
    {
        private readonly List<AssignmentNode> _assignments = new List<AssignmentNode>();
        private readonly AssignmentNodeExtractor _assignmentNodeExtractor = new AssignmentNodeExtractor();

        /// <summary>
        /// Visits a body context and extracts all valid assignments from it. Returns null if body contains no statements.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>List of AssignmentNodes or null</returns>
        public override List<AssignmentNode> VisitBody(OGParser.BodyContext context)
        {
            Console.WriteLine("\tCreating assignment nodes...");
            if (context.statements != null && !context.statements.IsEmpty)
            {
                return VisitStmts(context.statements);
            }

            //If there are no assignments in the body return null.
            return new List<AssignmentNode>();
        }
        
        /// <summary>
        /// Recursively visits Stmts and extracts AssignmentNodes them using a AssignmentExtractorVisitor.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override List<AssignmentNode> VisitStmts(OGParser.StmtsContext context)
        {
            
            OGParser.StmtContext currentStatement = context.currentStatement;
            //If the current statement is not null or empty, visit it
            if (currentStatement != null && !currentStatement.IsEmpty)
            {
                AssignmentNode a = _assignmentNodeExtractor.VisitStmt(currentStatement);

                if (a != null)
                {
                    _assignments.Add(a);
                }
            }
            
            
            OGParser.StmtsContext nextStatements = context.statements;
            //If there are more statements available, visit them recursively.
            if (nextStatements != null && !nextStatements.IsEmpty)
            {
                VisitStmts(nextStatements);
            }
            
            //Results are added to list property, not returned
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