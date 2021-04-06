using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNodes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    public class BodyNode : ASTNode
    {
        public List<DeclarationNode> DeclarationNodes = new List<DeclarationNode>();
        public List<AssignmentNode> AssignmentNodes = new List<AssignmentNode>();
        public List<CommandNode> CommandNodes = new List<CommandNode>();


        /// <summary>
        /// TODO Create declarations, assignmentnodes and commandNodes from the bodyContezxt
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errList"></param>
        public BodyNode(OGParser.BodyContext context, List<SemanticError> errList)
        {
            DeclarationsExtractor declarationsExtractor = new DeclarationsExtractor(errList);
            AssignmentsExtractor assignmentsExtractor = new AssignmentsExtractor(errList);
            AssignmentNodes = assignmentsExtractor.VisitBody(context);
            DeclarationNodes = declarationsExtractor.VisitBody(context);
            throw new NotImplementedException("Creating BodyNodes from a body context is not yet implemented");
        }
    }
}