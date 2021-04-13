using System;
using System.Runtime.Serialization;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;

namespace OG.AST.Functions
{
    public class StatementNodeExtractor : OGBaseVisitor<StatementNode>
    {
        
        private DeclarationNodeExtractor _declarationNodeExtractor = new DeclarationNodeExtractor();
        private AssignmentNodeExtractor _assignmentNodeExtractor = new AssignmentNodeExtractor();
        private CommandNodeExtractor _commandNodeExtractor = new CommandNodeExtractor();
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

            CommandNode commandNode = _commandNodeExtractor.VisitStmt(context);
            if (commandNode != null)
            {
                return commandNode;
            }

            throw new AstNodeCreationException("stmt was neither declaration, command or assignment");
        }
    }
}