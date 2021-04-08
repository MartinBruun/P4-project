using System;
using System.Collections.Generic;
using OG.ASTBuilding.Shapes;

namespace OG.AST.Functions
{
    public class BodyNodeExtractor : OGBaseVisitor<BodyNode>
    {
        private List<DeclarationNode> _declarationNodes = new List<DeclarationNode>();
        private List<AssignmentNode> _assignmentNodes = new List<AssignmentNode>();
        private List<CommandNode> _commandNodes = new List<CommandNode>();

        private readonly AssignmentNodeListBuild _assignmentNodeListBuilder = new AssignmentNodeListBuild();
        private readonly DeclarationNodeListBuilder _declarationNodeListBuilder = new DeclarationNodeListBuilder();

        public override BodyNode VisitBody(OGParser.BodyContext context)
        {
            Console.WriteLine("Creating body nodes...");
            OGParser.StmtsContext nextStatements = context.statements;
            OGParser.StmtContext currentStatement = nextStatements.currentStatement;

            if (currentStatement != null && !currentStatement.IsEmpty)
            {
                _assignmentNodes = _assignmentNodeListBuilder.VisitBody(context);
                _declarationNodes = _declarationNodeListBuilder.VisitBody(context);
                //_declarationNodes = _declarationNodeListBuilder.VisitBody(context);
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
