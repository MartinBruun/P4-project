using System;
using System.Collections.Generic;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.Shapes
{
    public class DeclarationNodeListBuilder : OGBaseVisitor<List<DeclarationNode>>
    {
        private List<SemanticError> ErrorList { get; set; }
        private List<DeclarationNode> _declarations = new List<DeclarationNode>();
        private DeclarationNodeExtractor _declarationNodeExtractor = new DeclarationNodeExtractor();

        

        public override List<DeclarationNode> VisitBody(OGParser.BodyContext context)
        {
            Console.WriteLine("\tCreating assignment nodes...");
            if (context.statements != null && !context.statements.IsEmpty)
            {
                return VisitStmts(context.statements);
            }

            //If there are no assignments in the body return null.
            return new List<DeclarationNode>();
            
        }

        public override List<DeclarationNode> VisitStmts(OGParser.StmtsContext context)
        {
            OGParser.StmtContext currentStatement = context.currentStatement;
            //If the current statement is not null or empty, visit it
            if (currentStatement != null && !currentStatement.IsEmpty)
            {
                DeclarationNode a = _declarationNodeExtractor.VisitStmt(currentStatement);

                if (a != null)
                {
                    _declarations.Add(a);
                }
            }
            
            
            OGParser.StmtsContext nextStatements = context.statements;
            //If there are more statements available, visit them recursively.
            if (nextStatements != null && !nextStatements.IsEmpty)
            {
                VisitStmts(nextStatements);
            }
            
            //Results are added to list property, not returned
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