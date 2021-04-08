using System;
using System.Collections.Generic;
using OG.ASTBuilding.Shapes;

namespace OG.AST.Functions
{
    public class BodyNodeExtractor : OGBaseVisitor<BodyNode>
    {
        public List<DeclarationNode> DeclarationNodes = new List<DeclarationNode>();
        public List<AssignmentNode> AssignmentNodes = new List<AssignmentNode>();
        public List<CommandNode> CommandNodes = new List<CommandNode>();

        private readonly AssignmentNodeListBuild _assignmentNodeListBuilder = new AssignmentNodeListBuild();
        private readonly DeclarationNodeListBuilder _declarationNodeListBuilder = new DeclarationNodeListBuilder();

        public override BodyNode VisitBody(OGParser.BodyContext context)
        {
            Console.WriteLine("Creating body nodes...");
            OGParser.StmtsContext nextStatements = context.statements;
            OGParser.StmtContext currentStatement = nextStatements.currentStatement;

            if (currentStatement != null && !currentStatement.IsEmpty)
            {
                
                AssignmentNodes = _assignmentNodeListBuilder.VisitBody(context);
                throw new NotImplementedException("Declaration nodes and command nodes not yeet able to be extracted");
                DeclarationNodes = _declarationNodeListBuilder.VisitBody(context);
            }

            //Try and extract assignments, declarations and commands from the current statement.

            if (context.statements != null && !context.statements.IsEmpty)
            {
                
                VisitStmts(nextStatements);
            }

            return null;
        }
        
    }


}
