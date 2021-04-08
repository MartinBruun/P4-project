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
        private List<DeclarationNode> Declarations = new List<DeclarationNode>();
        private DeclarationNodeExtractor _nodeExtractor;

        

        public override List<DeclarationNode> VisitBody(OGParser.BodyContext context)
        {
            OGParser.StmtsContext statements = context.statements;
            if (statements != null && !statements.IsEmpty)
                return VisitStmts(statements);
            else 
                return base.VisitBody(context);
            
        }

        public override List<DeclarationNode> VisitStmts(OGParser.StmtsContext context)
        {
            OGParser.StmtContext currentStatement = context.currentStatement;
            //If the current statement is not null or empty, visit it
            if (currentStatement != null && !currentStatement.IsEmpty)
                VisitStmt(currentStatement);
            
            
            OGParser.StmtsContext nextStatements = context.statements;
            //If there are more statements available, visit them recursively.
            if (nextStatements != null && !nextStatements.IsEmpty)
            {
                VisitStmts(nextStatements);
            }
            
            //Results are added to list property, not returned
            return base.VisitStmts(context);
        }

        public override List<DeclarationNode> VisitStmt(OGParser.StmtContext currentStatement)
        {
         
            OGParser.DeclarationContext currentDeclaration = currentStatement.dcl;
            //If the current statement is an assignment, extract it and add to Assignments.
            if (currentDeclaration != null && !currentDeclaration.IsEmpty)
            {
                throw new NotImplementedException("Have yet to find out how to extract declarations");
                //Get ID
                //Declarations.Add(new DeclarationNode());
            }

            //Results are added to list property, not returned
            return base.VisitStmt(currentStatement);
        }

        private DeclarationNode CreateDclNode(OGParser.StmtContext context)
        {
            throw new NotImplementedException();
            //When finding declarations and having created the node, add to the DeclarationNode list.
            //This adds to BodyNode due to reference value
            
            OGParser.DeclarationContext declaration = context.declaration();
            ExpressionNode expressionNode = new ExpressionNode();
            //How to get the different kind of declarations?
            
            if (declaration != null && !declaration.IsEmpty)
            {

                
                
                
                
                //DeclarationNode result = new DeclarationNode(new IDNode(declaration.GetText());
            }
            
            
            if (context.dcl != null && !context.dcl.IsEmpty)
            {
               
            }
                
               

            return new DeclarationNode(new IDNode(context.dcl.GetText()),expressionNode);
        }
    }
}