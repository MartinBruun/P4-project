using System;
using System.Collections.Generic;
using System.Globalization;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.MathNodes_and_extractors
{
    public class MathNodeExtractor : AstBuilderErrorInheritor<MathNode>
    {

        public MathNodeExtractor(List<SemanticError> errs): base(errs)
        {
            
        }

        private MathFunctionCallNodeExtractor _functionCallNodeExtractor = null;
        
        public override MathNode VisitSingleTermExpr(OGParser.SingleTermExprContext context)
        {

            OGParser.TermContext termContext;
            
            if (context == null)
            {
                return null;
            }
            else
            {
                termContext = context.child;
            }
            
            
            return ExtractMathNode(termContext);

        }

        /// <summary>
        /// Returns AdditionNode or SubtractionNode with RHS MathNode and LHS MathNode.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="AstNodeCreationException"></exception>
        public override MathNode VisitInfixAdditionExpr(OGParser.InfixAdditionExprContext context)
        {

            OGParser.MathExpressionContext rhsMath = context.rhs;
            MathNode lhsNode = ExtractMathNode(context.lhs);
            MathNode rhsNode = ExtractMathNode(context.rhs);
            
            //Check if we work with plus or minus
            switch (context.op.Type)
            {
                case OGLexer.Plus_Minus:
                    if (context.op.Text == "+")
                    {
                        return new AdditionNode(rhsNode, lhsNode);
                    }
                    else if (context.op.Text == "-")
                    {
                        return new SubtractionNode(rhsNode, lhsNode);
                    }
                    break;
                default:
                    SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column, "InfixAdditionContext did not contain + or -.")
                        {IsFatal = true});
                    break;
            }

            //Should not happen.
            return null;
        }

   
        /// <param name="context"></param>
        /// <returns></returns>
        public MathNode ExtractMathNode(OGParser.MathExpressionContext context)
        {

            try
            {
                try
                {
                    OGParser.SingleTermExprContext singleTermContext = (OGParser.SingleTermExprContext) context;
                    return VisitSingleTermExpr(singleTermContext);
                }
                catch (InvalidCastException)
                {
                }

                OGParser.InfixAdditionExprContext additionContext = (OGParser.InfixAdditionExprContext) context;
                return VisitInfixAdditionExpr(additionContext);
            }
            catch (InvalidCastException e)
            {
                
                SemanticErrors.Add(new SemanticError("Something went wrong when converting MathExpressionContext" +
                                                     " to InfixAdditionContext" +
                                                     " and SingleTermExprContext.\n " + e.Message){IsFatal =  true});
                return null;

            }

        }

        public MathNode ExtractMathNode(OGParser.TermContext context)
        {
            try
            {
                try
                {
                    OGParser.InfixMultExprContext multiplicationExpr = (OGParser.InfixMultExprContext) context;
                    return VisitInfixMultExpr(multiplicationExpr);
                }
                catch (InvalidCastException )
                {
                    OGParser.SingleTermChildContext singleTermExpr = (OGParser.SingleTermChildContext) context;
                    return VisitSingleTermChild(singleTermExpr);
                }

            }
            catch (InvalidCastException e)
            {
                
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,
                "Something went wrong when converting TermContext to InfixMultExprContext" +
                                                     " and SingleTermChildContext. " + e.Message)
                    {IsFatal = true});
                return null;
            }
           
            
        }

        public MathNode ExtractMathNode(OGParser.FactorContext factorContext)
        {
            //Convert factor context into useful contexts and extract from those by visiting.
            try
            {
                try
                {
                    OGParser.SingleAtomContext singleAtomContext = (OGParser.SingleAtomContext) factorContext;
                    return VisitSingleAtom(singleAtomContext);
                }
                catch (InvalidCastException )
                {

                }

                try
                {
                    OGParser.ParenthesisMathExprContext parenContext =
                        (OGParser.ParenthesisMathExprContext) factorContext;
                    return VisitParenthesisMathExpr(parenContext);
                }
                catch (InvalidCastException )
                {
                    //Do nothing
                }
                


                string content = factorContext.GetText();
                //Rather than even bigger chain of try catch.
                if (!string.IsNullOrEmpty(content) && content.Contains('^'))
                {
                    OGParser.PowerExprContext powerContext = (OGParser.PowerExprContext) factorContext;
                    return VisitPowerExpr(powerContext);
                }
            }
            catch (InvalidCastException e)
            {
                SemanticErrors.Add(new SemanticError(factorContext.Start.Line, factorContext.Start.Column,
                "Term context is cannot be converted to PowerExprContext" +
                                                     ", or ParenthesisMathContext. " + e.Message)
                    {IsFatal = true});
            }
            
           
            //Should not happen.
            return null;
        }

        public MathNode ExtractMathNode(OGParser.AtomContext context)
        {

            try
            {
                try
                {
                    OGParser.AtomfuncCallContext functionCall = (OGParser.AtomfuncCallContext) context;
                    return VisitAtomfuncCall(functionCall);
                }
                catch (InvalidCastException )
                {

                }
                try
                {
                    OGParser.AtomXYValueContext xyValueContext = (OGParser.AtomXYValueContext) context;
                    return VisitAtomXyValue(xyValueContext);
                }
                catch (InvalidCastException )
                {
                    //Do nothing, try next cast
                }

                try
                {
                    OGParser.AtomIdContext idContext = (OGParser.AtomIdContext) context;
                    return VisitAtomId(idContext);
                }
                catch (InvalidCastException )
                {
                    //Do nothing, try next cast
                }

                OGParser.NumberContext numberContext = (OGParser.NumberContext) context;
                return VisitNumber(numberContext);
                
            }
            catch (InvalidCastException )
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,                     "Could not convert AtomContext into " +
                    "AtomfuncCallContext, AtomXYValueContext, AtomIdContext, or NumberContext ")
                    {IsFatal = true});

                return null;
            }
           
        }

        public override MathNode VisitAtomId(OGParser.AtomIdContext context)
        {
            return new MathIdNode(context.GetText(),new IdNode(context.id.Text));
        }

        public override MathNode VisitNumber(OGParser.NumberContext context)
        {
            return new NumberNode(double.Parse(context.value.Text, CultureInfo.InvariantCulture));
        }

        public MathNode VisitAtomXyValue(OGParser.AtomXYValueContext context)
        {
            return new CoordinateXyValueNode(context.xyValue.GetText(), MathNode.MathType.CoordinateXyValueNode);
        }

        /// <summary>
        /// Tries to convert SingleTermChildContext into a MathNode This is done by trying to cast to PowerExprContext
        /// and ParenthesisMathExprContext. If none of these cast are valid, throw AStNodeCreationException.
        /// If something else goes wrong throw Exception.
        /// </summary>
        /// <param name="context"></param>
        /// <returns cref="MathNode"> with Type property set to appropriate type</returns>
        /// <exception cref="AstNodeCreationException"></exception>
        /// <exception cref="Exception"></exception>
        public override MathNode VisitSingleTermChild(OGParser.SingleTermChildContext context)
        {

            OGParser.FactorContext factorContext = context.factor();
            try
            {
                try
                {
                    OGParser.SingleAtomContext singleAtomContext = (OGParser.SingleAtomContext) factorContext;
                    return VisitSingleAtom(singleAtomContext);
                }
                catch (InvalidCastException )
                {
                   
                }

                try
                {
                    OGParser.ParenthesisMathExprContext parenContext = (OGParser.ParenthesisMathExprContext) factorContext;
                    return VisitParenthesisMathExpr(parenContext);

                    //Visit
                }
                catch (InvalidCastException )
                {
                    //Do nothing
                }
                
                string content = factorContext.GetText();
                //Rather than even bigger chain of try catch.
                if (!string.IsNullOrEmpty(content) && content.Contains('^'))
                {
                    OGParser.PowerExprContext powerContext = (OGParser.PowerExprContext) factorContext;
                    return VisitPowerExpr(powerContext);
                }
            }
            catch (InvalidCastException e)
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column,
                        "Could not convert SingleTermChildContext into specific context")
                    {IsFatal = true});
            }
           
            return null;

        }

        public override MathNode VisitPowerExpr(OGParser.PowerExprContext context)
        {
            MathNode lhs = ExtractMathNode(context.lhs);
            MathNode rhs = ExtractMathNode(context.rhs);
            return new PowerNode(rhs, lhs);
           
        }

        public override MathNode VisitParenthesisMathExpr(OGParser.ParenthesisMathExprContext context)
        {
            return ExtractMathNode(context.mathExpr);
        }
        
        public override MathNode VisitInfixMultExpr(OGParser.InfixMultExprContext context)
        {
            MathNode lhsNode = ExtractMathNode(context.lhs);
            MathNode rhsNode = ExtractMathNode(context.rhs);

            switch (context.op.Type)
            {
                case OGLexer.Mul_Div:
                    if (context.op.Text.Contains("*"))
                    {
                        return new MultiplicationNode(rhsNode, lhsNode);
                    }

                    if (context.op.Text.Contains("/"))
                    {
                        return new DivisionNode(rhsNode, lhsNode);
                    }

                    break;
            }

            SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column, "InfixMultContext did not contain + or -.")
            {
                IsFatal = true
            });
            return null;
        }
        
        public override MathNode VisitSingleAtom(OGParser.SingleAtomContext context)
        {
            OGParser.AtomContext atomContext = context.child;
            return ExtractMathNode(atomContext);
        }
        
        /// <summary>
        /// Tries to create MAthNode from AtomContext.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="AstNodeCreationException"></exception>
        public override MathNode VisitAtomfuncCall(OGParser.AtomfuncCallContext context)
        {
            OGParser.FunctionCallContext funcCallContext = context.funcCall;
            _functionCallNodeExtractor = new MathFunctionCallNodeExtractor(SemanticErrors);
           return  _functionCallNodeExtractor.VisitFunctionCall(funcCallContext);

        }
    }
}