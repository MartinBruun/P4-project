using System;
using System.Collections.Generic;
using OG.AST.Functions;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Visitors
{
    public class AntlrToIterationCommand:OGBaseVisitor<IterationNode>
    {
        BodyNodeExtractor _bodyExtractor = new BodyNodeExtractor();

        private BodyNode GetBody(OGParser.BodyContext context)
        {
            BodyNode body = _bodyExtractor.VisitBody(context);
            return body;
        }

        public override IterationNode VisitUntilFuncCall(OGParser.UntilFuncCallContext context)
        {
            IFunctionCall func = new FunctionCallExtractor().VisitFunctionCall(context.iterator);
            BodyNode body = GetBody(context.statements);
            return new UntilFunctionCallNode(func, body);
        }

        public override IterationNode VisitUntilCondition(OGParser.UntilConditionContext context)
        {
            BoolNode boolnode = new BoolNodeExtractor().ExtractBoolNode(context.iterator);
            BodyNode body = GetBody(context.statements);
            return new UntilNode(boolnode, body);
        }

        

        public override IterationNode VisitNumberIteration(OGParser.NumberIterationContext context)
        {
            
            MathNode mathNode = new MathNodeExtractor().ExtractMathNode(context.iterator);
            BodyNode body = GetBody(context.statements);
            return new NumberIterationNode(mathNode, body);
        }

        public IterationNode ExtractIterationNode(OGParser.UntilIterationContext context)
        {
            try
            {
                OGParser.UntilFuncCallContext funcCallContext = (OGParser.UntilFuncCallContext) context;
                return VisitUntilFuncCall(funcCallContext);

            }
            catch (InvalidCastException e)
            {}

            OGParser.UntilConditionContext untilConditionContext = (OGParser.UntilConditionContext) context;
            return VisitUntilCondition(untilConditionContext);

        }
        
        
    }
}