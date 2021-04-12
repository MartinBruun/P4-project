using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class ToCommandsListBuilder : OGBaseVisitor<List<PointReferenceNode>>
    {
        public List<PointReferenceNode> BuildToCommandNodes(OGParser.ToCommandsContext toCmds)
        {
            List<PointReferenceNode> p = new List<PointReferenceNode>();
            return p;
        }
    }
}