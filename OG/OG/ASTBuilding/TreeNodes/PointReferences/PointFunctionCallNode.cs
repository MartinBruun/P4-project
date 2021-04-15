﻿using System.Collections.Generic;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    public class  PointFunctionCallNode : PointReferenceNode, IFunctionCallNode,IFunctionNodeVisitable, IPointReferenceVisitable
    {
        public PointFunctionCallNode(string pointText, IdNode functionName, List<ParameterNode> functionParameters) : base(pointText, PointReferenceNodeType.PointFunctionCallNode)
        {
            Parameters = functionParameters;
            FunctionName = functionName;
        }


        public IdNode FunctionName { get; set; }
        public List<ParameterNode> Parameters { get; set; }
        public void Accept(IPointReferenceNodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Accept(IFunctionNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}