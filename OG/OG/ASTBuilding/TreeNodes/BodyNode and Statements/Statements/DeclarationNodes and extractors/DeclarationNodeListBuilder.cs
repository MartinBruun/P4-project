using System;
using System.Collections.Generic;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors
{
    public class DeclarationNodeListBuilder : AstBuilderErrorInheritor<List<DeclarationNode>>
    {
        private List<DeclarationNode> _declarations = new List<DeclarationNode>();
        private DeclarationNodeExtractor _declarationNodeExtractor;


        public DeclarationNodeListBuilder(List<SemanticError> errs ):base(errs)
        {
            _declarationNodeExtractor = new DeclarationNodeExtractor(errs);
        }

        
        /// <summary>
        /// Visits a body context and extracts all declarations from it. Returns empty list if body contains no statements.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>List of AssignmentNodes or null</returns>
        public override List<DeclarationNode> VisitBody(OGParser.BodyContext context)
        {
            //Console.WriteLine("\tCreating declarationNodesnodes...");
            if (context.statements != null && !context.statements.IsEmpty)
            {
                return VisitStmts(context.statements);
            }

            //If there are no assignments in the body return null.
            return new List<DeclarationNode>();
            
        }

        /// <summary>
        /// Recursively visits Stmts and extracts DeclarationNodes them using a DeclarationNodeExtractor.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override List<DeclarationNode> VisitStmts(OGParser.StmtsContext context)
        {
            OGParser.StmtContext currentStatement = context.currentStatement;
            //If the current statement is not null or empty, visit it
            if (currentStatement != null && !currentStatement.IsEmpty)
            {
                DeclarationNode declarationNode = _declarationNodeExtractor.VisitStmt(currentStatement);

                if (declarationNode != null)
                {
                    _declarations.Add(declarationNode);
                }
            }
            
            
            OGParser.StmtsContext nextStatements = context.statements;
            //If there are more statements available, visit them recursively.
            if (nextStatements != null && !nextStatements.IsEmpty)
            {
                VisitStmts(nextStatements);
            }
            
            
            return _declarations;
        }

        public override List<DeclarationNode> VisitStmt(OGParser.StmtContext currentStatement)
        {
            OGParser.DeclarationContext currentDeclaration = currentStatement.dcl;
            //If the current statement is an assignment, extract it and add to Assignments.
            if (currentDeclaration != null && !currentDeclaration.IsEmpty)
            {
                _declarations.Add(_declarationNodeExtractor.ExtractDeclarationNode(currentDeclaration));
                return _declarations;
            }

            return null;
        }
    }
}