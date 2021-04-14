using System;
using System.Reflection.Metadata;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Shapes
{
    public class BoolNodeExtractor : OGBaseVisitor<BoolNode>
    {
        private readonly MathNodeExtractor _mathExtractor = new MathNodeExtractor();
        /// <summary>
        /// Must not be created on construction!
        /// Danger of infinite recursion as it contains function call management itself!
        /// </summary>
        private BoolFunctionCallNodeExtractor _boolFunctionNodeExtractor = null;
        public BoolNode ExtractBoolNode(OGParser.BoolExpressionContext context)
        {
            Console.WriteLine("\tCreating bool node from expression {0}", context.GetText());
            try
            {
                //First split on "&& and ||"
                try
                {
                    OGParser.BoolExprBoolCompContext boolCmprContext = (OGParser.BoolExprBoolCompContext) context;
                    return VisitBoolExprBoolComp(boolCmprContext);
                }
                catch (InvalidCastException )
                { }

                try
                {
                    OGParser.ParenthesisBoolExprContext parenthContext = (OGParser.ParenthesisBoolExprContext) context;
                    return VisitBoolExprBoolComp(parenthContext);
                }
                catch (InvalidCastException)
                { }
                try
                {
                    OGParser.BoolExprMathCompContext mathCmprContext = (OGParser.BoolExprMathCompContext) context;
                    return VisitBoolExprMathComp(mathCmprContext);
                }
                catch (InvalidCastException )
                { }
                try
                {
                    OGParser.BoolExprTrueFalseContext tOrFContext = (OGParser.BoolExprTrueFalseContext) context;
                    switch (tOrFContext.value.Type)
                    {
                        case OGLexer.BooleanValue:
                            if (tOrFContext.value.Text == "true")
                            {
                                return new TrueNode(tOrFContext.value.Text);
                            }
                            else if (tOrFContext.value.Text == "false")
                            {
                                return new FalseNode("False");
                            }
                            break;
                        default:
                            
                            throw new AstNodeCreationException("TrueFalse context does not contain literals true or false " + 
                                                               context.GetText());
                    }
                    throw new AstNodeCreationException("TrueFalse context does not contain literals true or false " + 
                                                       context.GetText());
                }
                catch (InvalidCastException )
                { }

                try
                {
                    OGParser.BoolExprNotPrefixContext notExprContext = (OGParser.BoolExprNotPrefixContext) context;
                    return VisitBoolExprNotPrefix(notExprContext);
                }
                catch (InvalidCastException )
                {
                }
                
                

                try
                {
                    OGParser.BoolExprIDContext idBoolContext = (OGParser.BoolExprIDContext) context;
                }
                catch (InvalidCastException )
                { }
                
                OGParser.BoolExprFuncCallContext boolFuncCallContext = (OGParser.BoolExprFuncCallContext) context;
                return VisitBoolExprFuncCall(boolFuncCallContext);

            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Something went wrong when converting BoolExpressionContext into " +
                                                   "BoolExprNotPrefixContext, " +
                                                   "BoolExprBoolCompContext, " +
                                                   "BoolExprMathCompContext, " +
                                                   "BoolExprTrueFalseContext, " +
                                                   "BoolExprIDContext, " +
                                                   "and BoolExprFuncCallContext.\n " + e.Message + " \n It happened while working with " + context.GetText() + ".\n");
            }
            
        }

        private BoolNode VisitBoolExprBoolComp(OGParser.ParenthesisBoolExprContext boolExprcontext)
        {
            return ExtractBoolNode(boolExprcontext.boolExpression());
        }


        public override BoolNode VisitBoolExprMathComp(OGParser.BoolExprMathCompContext context)
        {
            MathNode lhs = _mathExtractor.ExtractMathNode(context.lhs);
            MathNode rhs = _mathExtractor.ExtractMathNode(context.rhs);
            
            //Switch on contexts bool operator
            ITerminalNode comparer = context.BoolOperator();
            switch (comparer.GetText())
            {
                case ">":
                    return new GreaterThanComparerNode(lhs, rhs, context.GetText());
                
                case "<":
                    return new LessThanComparerNode(lhs, rhs, context.GetText());
                    
                case "==":
                    return new EqualsComparerNode(lhs, rhs, context.GetText());
                
                default:
                    throw new AstNodeCreationException("BoolExprMathComprContext did not contain <, > or ==.");


            }
        }

        public override BoolNode VisitBoolExprNotPrefix(OGParser.BoolExprNotPrefixContext context)
        {
            return new NegationNode(ExtractBoolNode(context.boolExpr), context.boolExpr.GetText());
        }

        public override BoolNode VisitBoolExprBoolComp(OGParser.BoolExprBoolCompContext context)
        {
            BoolNode lhs = ExtractBoolNode(context.lhs);
            BoolNode rhs = ExtractBoolNode(context.rhs);
            string content = context.GetText();
            
            switch (context.LogicOperator().GetText())
            {
                case "&&":
                    return new AndComparerNode(rhs, lhs, content);
                case "||":
                    return new OrComparerNode(rhs, lhs, content);

                default:
                    throw new AstNodeCreationException("BoolExprBoolCompContext did not contain && or ||.");

            }
        }

        public override BoolNode VisitBoolExprFuncCall(OGParser.BoolExprFuncCallContext context)
        {
            OGParser.FunctionCallContext funcCall = context.funcCall;
            _boolFunctionNodeExtractor = new BoolFunctionCallNodeExtractor();
            return _boolFunctionNodeExtractor.VisitFunctionCall(funcCall);
        }
    }
}