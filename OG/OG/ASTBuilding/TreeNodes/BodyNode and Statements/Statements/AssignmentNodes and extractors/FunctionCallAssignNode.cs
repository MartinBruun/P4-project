﻿using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class FunctionCallAssignNode : AssignmentNode, IFunctionCallNode
    {
        public FunctionCallAssignNode(IdNode id, List<ParameterNode> parameters) : base(id, AssignmentType.FunctionCallAssignment)
        {
            FunctionName = id;
            Parameters = parameters;
        }

        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
    }
}