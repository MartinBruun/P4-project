using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements
{
    public class StatementNodeExtractor : OGBaseVisitor<StatementNode>
    {
        
        private readonly DeclarationNodeExtractor _declarationNodeExtractor = new DeclarationNodeExtractor();
        private readonly AssignmentNodeExtractor _assignmentNodeExtractor = new AssignmentNodeExtractor();
        private readonly CommandNodeExtractor _commandNodeExtractor = new CommandNodeExtractor();
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

            throw new AstNodeCreationException("stmt was neither declaration, command or assignment");
        }
    }
}