using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class ToCommandsListBuilder : OGBaseVisitor<List<PointReferenceNode>>
    {
        private readonly List<PointReferenceNode> _toCommandList = new List<PointReferenceNode>();
        public List<PointReferenceNode> BuildToCommandNodes(OGParser.ToCommandsContext context)
        {
            _toCommandList.Add(new ToCommandNodeExtractor().ExtractToCommandNode(context.toCmd));

            if (context.chainedToCmds != null)
            {
                BuildToCommandNodes(context.chainedToCmds);
            }

            return _toCommandList;
        }
    }
}