using System;
using System.Collections.Generic;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class ToCommandsListBuilder : OGBaseVisitor<List<PointReferenceNode>>
    {
        public List<PointReferenceNode> ToCommandList = new List<PointReferenceNode>();
        public List<PointReferenceNode> BuildToCommandNodes(OGParser.ToCommandsContext context)
        {
            ToCommandList.Add(new ToCommandNodeExtractor().ExtractToCommandNode(context.toCmd));

            if (context.chainedToCmds != null)
            {
                BuildToCommandNodes(context.chainedToCmds);
            }

            return ToCommandList;
        }
    }
}