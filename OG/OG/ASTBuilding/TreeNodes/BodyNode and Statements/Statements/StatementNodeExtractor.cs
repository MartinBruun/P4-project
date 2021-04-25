using System.Collections.Generic;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements
{
    public class StatementNodeExtractor : AstBuilderErrorInheritor<StatementNode>
    {

        private readonly DeclarationNodeExtractor _declarationNodeExtractor;
        private readonly AssignmentNodeExtractor _assignmentNodeExtractor;
        private readonly CommandNodeExtractor _commandNodeExtractor;
        public override StatementNode VisitStmt(OGParser.StmtContext context)
        {
            AssignmentNode assignmentNode = _assignmentNodeExtractor.VisitStmt(context);
            if (assignmentNode != null)
            {
                return assignmentNode;
            }

            DeclarationNode declarationNode = _declarationNodeExtractor.VisitStmt(context);
            if (declarationNode != null)
            {
                return declarationNode;
            }

            CommandNode.CommandNode commandNode = _commandNodeExtractor.VisitStmt(context);
            if (commandNode != null)
            {
                return commandNode;
            }
            SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column, "stmt was neither declaration, command or assignment")
            {
                IsFatal = true
            });

            return null;
        }

        public StatementNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            _declarationNodeExtractor = new DeclarationNodeExtractor(errs);
            _assignmentNodeExtractor = new AssignmentNodeExtractor(errs);
            _commandNodeExtractor = new CommandNodeExtractor(errs);
        }
    }
}