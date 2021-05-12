using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.CodeGeneration
{
    public interface IMathNodeVisitor
    {
        public NumberNode Visit(AdditionNode node);
        public NumberNode Visit(NumberNode node);
        public NumberNode Visit(DivisionNode node);
        public NumberNode Visit(MathIdNode node);
        public NumberNode Visit(MultiplicationNode node);
        public NumberNode Visit(PowerNode node);
        public NumberNode Visit(SubtractionNode node);
        public NumberNode Visit(MathFunctionCallNode node);
        public NumberNode Visit(CoordinateXyValueNode node);
    }
}