using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BoolNodes;

namespace OG.ASTBuilding.Shapes
{
    public class BoolNodeExtractor : OGBaseVisitor<BoolNode>
    {
        private MathNodeExtractor _mathExtractor = new MathNodeExtractor();
        public BoolNode ExtractBoolNode(OGParser.BoolExpressionContext context)
        {
            Console.WriteLine("\tCreating bool node from expression {0}", context.GetText());
            try
            {
                //First split on "&& and ||"
                try
                {
                    OGParser.BoolExprMathCompContext mathCmprContext = (OGParser.BoolExprMathCompContext) context;
                    return VisitBoolExprMathComp(mathCmprContext);
                }
                catch (InvalidCastException e)
                { }
                
                try
                {
                    OGParser.BoolExprIDContext idBoolContext = (OGParser.BoolExprIDContext) context;
                }
                catch (InvalidCastException e)
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
                            else if (tOrFContext.value.Text == "False") ;
                        {
                            return new FalseNode("False");
                        }
                            break;
                        default:
                            throw new AstNodeCreationException("TrueFalse context does not contain literals true or false " + 
                                                               context.GetText());
                    }
                }
                catch (InvalidCastException e)
                { }
                
                try
                {
                    OGParser.BoolExprFuncCallContext boolFuncCallContext = (OGParser.BoolExprFuncCallContext) context;
                    IDNode id = new IDNode(boolFuncCallContext.funcCall.id.Text);
                    OGParser.PassedParamsContext p = boolFuncCallContext.funcCall.@params;
                    throw new NotImplementedException("BoolExprFuncCallContex --> BoolFunctionNode");
                }
                catch (InvalidCastException e)
                { }

               

                try
                {
                    OGParser.BoolExprBoolCompContext boolCmprContext = (OGParser.BoolExprBoolCompContext) context;
                    VisitBoolExprBoolComp(boolCmprContext);
                }
                catch (InvalidCastException e)
                { }
                
                OGParser.BoolExprNotPrefixContext notExprContext = (OGParser.BoolExprNotPrefixContext) context;
                return VisitBoolExprNotPrefix(notExprContext);
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Something went wrong when converting BoolExpressionContext into " +
                                                   "BoolExprNotPrefixContext, " +
                                                   "BoolExprBoolCompContext, " +
                                                   "BoolExprMathCompContext, " +
                                                   "BoolExprTrueFalseContext, " +
                                                   "BoolExprIDContext, " +
                                                   "and BoolExprFuncCallContext.\n " + e.Message);
            }
            catch (AstNodeCreationException e)
            {
                throw;
            }
            catch (NotImplementedException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext\n. " + e.Message);
            }

            return null;
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
                    break;
                case "<":
                    return new LessThanComparerNode(lhs, rhs, context.GetText());
                    break;
                case "==":
                    return new EqualsComparerNode(lhs, rhs, context.GetText());
                    break;
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
                    break;
                
                case "||":
                    return new OrComparerNode(rhs, lhs, content);
                    
                    break;
                default:
                    throw new AstNodeCreationException("BoolExprBoolCompContext did not contain && or ||.");

            }
        }
    }
}