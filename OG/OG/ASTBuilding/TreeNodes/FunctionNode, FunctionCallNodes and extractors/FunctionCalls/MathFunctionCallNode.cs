﻿using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class MathFunctionCallNode : TerminalMathNode, IFunctionCallNode
    {
        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }

       
        public MathFunctionCallNode(string value, IdNode id, List<ParameterNode> parameters) : base(value, MathType.FunctionCallNode)
        {
            FunctionName = id;
            Parameters = parameters;
        }
    }
}