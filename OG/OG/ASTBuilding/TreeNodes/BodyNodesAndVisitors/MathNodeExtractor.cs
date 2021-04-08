using System;
using System.Collections.Generic;
using System.Globalization;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    public class MathNodeExtractor : OGBaseVisitor<MathNode>
    {

        //private FunctionCallNodeExtractor _functionCallNodeExtractor = new FunctionCallNodeExtractor();
        
        public override MathNode VisitSingleTermExpr(OGParser.SingleTermExprContext context)
        {
            OGParser.TermContext termContext = context.child;
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
                    throw new AstNodeCreationException("InfixAdditionContext did not contain + or -");
            }

            //Should not happen.
            return null;
        }

        /// <summary>
        /// TODO MathExpressioncontext --> MathNode
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MathNode ExtractMathNode(OGParser.MathExpressionContext context)
        {
            try
            {
                try
                {
                    OGParser.InfixAdditionExprContext additionContext = (OGParser.InfixAdditionExprContext) context;
                    return VisitInfixAdditionExpr(additionContext);
                }
                catch (InvalidCastException e)
                {

                }

                OGParser.SingleTermExprContext singleTermContext = (OGParser.SingleTermExprContext) context;
                return VisitSingleTermExpr(singleTermContext);

            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Something went wrong when converting MathExpressionContext" +
                                                   " to InfixAdditionContext" +
                                                   " and SingleTermExprContext.\n " + e.Message);
            }
            catch (AstNodeCreationException e)
            {
                throw new AstNodeCreationException(e.Message);
            }
            catch (NotImplementedException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext\n. " + e.Message);
            }
        }

        public MathNode ExtractMathNode(OGParser.TermContext lhsMath)
        {
            try
            {
                try
                {
                    OGParser.InfixMultExprContext multiplicationExpr = (OGParser.InfixMultExprContext) lhsMath;
                    return VisitInfixMultExpr(multiplicationExpr);
                }
                catch (InvalidCastException e)
                {
                    OGParser.SingleTermChildContext singleTermExpr = (OGParser.SingleTermChildContext) lhsMath;
                    return VisitSingleTermChild(singleTermExpr);
                }

            }
            catch (InvalidCastException e)
            {
                
                throw new AstNodeCreationException("Something went wrong when converting TermContext to InfixMultExprContext" +
                                                   " and SingleTermChildContext. " + e.Message);
            }
            catch (AstNodeCreationException e)
            {
                throw new AstNodeCreationException(e.Message);
            }
            catch (NotImplementedException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext" + e.Message);
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
                    //HEREE
                    return VisitSingleAtom(singleAtomContext);
                }
                catch (InvalidCastException e)
                {

                }

                try
                {
                    OGParser.ParenthesisMathExprContext parenContext =
                        (OGParser.ParenthesisMathExprContext) factorContext;
                    return VisitParenthesisMathExpr(parenContext);
                }
                catch (InvalidCastException e)
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
                throw new AstNodeCreationException("Term context is cannot be converted to PowerExprContext" +
                                                   ", or ParenthesisMathContext. " + e.Message);
            }
            catch (AstNodeCreationException e)
            {
                throw new AstNodeCreationException(e.Message);
            }
            catch (NotImplementedException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext.\n" + e.Message);
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
                catch (InvalidCastException e)
                {

                }
                try
                {
                    OGParser.AtomXYValueContext xyValueContext = (OGParser.AtomXYValueContext) context;
                    return VisitAtomXYValue(xyValueContext);
                }
                catch (InvalidCastException e)
                {
                    //Do nothing, try next cast
                }

                try
                {
                    OGParser.AtomIdContext idContext = (OGParser.AtomIdContext) context;
                    return VisitAtomId(idContext);
                    throw new NotImplementedException("Creation of MathNodes from AtomIDContext not implemented");
                }
                catch (InvalidCastException e)
                {
                    //Do nothing, try next cast
                }

                OGParser.NumberContext numberContext = (OGParser.NumberContext) context;
                return VisitNumber(numberContext);
                
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Could not convert AtomContext into " +
                                                   "AtomfuncCallContext, AtomXYValueContext, AtomIdContext, or NumberContext ");
            }
            catch (AstNodeCreationException e)
            {
                throw new AstNodeCreationException(e.Message);

            }
            catch (NotImplementedException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AtomContext" + e.Message);
            }

        }

        public override MathNode VisitAtomId(OGParser.AtomIdContext context)
        {
            return new MathNode(context.id.Text, MathNode.MathType.IdValueNode);
        }

        public override MathNode VisitNumber(OGParser.NumberContext context)
        {
            return new NumberNode(double.Parse(context.value.Text, NumberStyles.AllowDecimalPoint));
        }

        public override MathNode VisitAtomXYValue(OGParser.AtomXYValueContext context)
        {
            return new CoordinateXYValueNode(context.xyValue.Text, MathNode.MathType.CoordinateXyValueNode);
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
                catch (InvalidCastException e)
                {
                   
                }

                try
                {
                    OGParser.ParenthesisMathExprContext parenContext = (OGParser.ParenthesisMathExprContext) factorContext;
                    return VisitParenthesisMathExpr(parenContext);

                    //Visit
                }
                catch (InvalidCastException e)
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
                throw new AstNodeCreationException("Term context is cannot be converted to PowerExprContext" +
                                                   ", or ParenthesisMathContext. " + e.Message);
            }
            catch (AstNodeCreationException e)
            {
                throw new AstNodeCreationException( e.Message);
            }
            catch (NotImplementedException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext" + e.Message);
            }
            

            return null;

        }

        public override MathNode VisitPowerExpr(OGParser.PowerExprContext context)
        {
            throw new NotImplementedException(
                "Conversion of powerContexts context into mathNode not yet implemented.");
            return base.VisitPowerExpr(context);
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
                        return new AdditionNode(rhsNode, lhsNode);
                    }
                    else if (context.op.Text.Contains("/")) ;
                    {
                        return new SubtractionNode(rhsNode, lhsNode);
                    }
                
                    break;
                default:
                   
                    throw new AstNodeCreationException("InfixMultExprContext " + 
                                                       context.GetText() + " did not contain * or /");
                }
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
            /*
            OGParser.FunctionCallContext funcCallContext = context.funcCall;
            MathNode p = _functionCallNodeExtractor.VisitFunctionCall(funcCallContext);
            IDNode id = new IDNode(funcCallContext.id.Text);
            
            //List<ParameterNode> parameters = _parameterListBuilder.VisitFunctionCall(funcCallContext);
            
            */
            throw new NotImplementedException("Creation of MathNodes from AtomfuncCallContext not implemented");

            return base.VisitAtomfuncCall(context);
        }
    }

    /*
    public class FunctionCallNodeExtractor : OGBaseVisitor<MathFunctionCallNode>
    {
        private ParameterNodeListBuilder _parameterListBuilder = new ParameterNodeListBuilder();

        /// <summary>
        /// Tries to create MAthNode from AtomContext.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="AstNodeCreationException"></exception>
        public override MathFunctionCallNode VisitFunctionCall(OGParser.FunctionCallContext context)
        {

            IDNode id = new IDNode(context.id.Text);
            List<ParameterNode> parameters = _parameterListBuilder.VisitFunctionCall(context);
            
            
            throw new NotImplementedException("Creation of MathNodes from AtomfuncCallContext not implemented");


            return base.VisitFunctionCall(context);
        }


    }

    public class ParameterNodeListBuilder : OGBaseVisitor<List<ParameterNode>>
    {
        private List<ParameterNode> Parameters { get; set; } = new List<ParameterNode>();
        private ParameterNodeExtractor _paramExtractor = new ParameterNodeExtractor();

        public override List<ParameterNode> VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            OGParser.PassedParamsContext parametersContext = context.@params;
            return ExtractParameterNodes(parametersContext);
        }

        public List<ParameterNode> ExtractParameterNodes(OGParser.PassedParamsContext parameters)
        {
            try
            {
                try
                {
                    OGParser.SingleParameterContext singleParam = (OGParser.SingleParameterContext) parameters;
                    Parameters.Add(_paramExtractor.VisitSingleParameter(singleParam));
                }
                catch (InvalidCastException)
                { }

                try
                {
                    OGParser.MultiParametersContext multipleParams = (OGParser.MultiParametersContext) parameters;
                    throw new NotImplementedException(
                        "Cannot create parameter nodes from multiple parameters as of yet");
                }
                catch (InvalidCastException e)
                {
                    
                }

                OGParser.NoParameterContext noParams = (OGParser.NoParameterContext) parameters;
                return Parameters;
            }
            catch (InvalidCastException)
            {
                throw new AstNodeCreationException(
                    "failed to typecast PassedParamsContext into OGParser.SingleParameterContext, " +
                    "OGParser.MultiParametersContext and OGParser.MultiParametersContext");
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext" +
                                    e.Message);
            }
        }


    }

    public class ParameterNodeExtractor : OGBaseVisitor<ParameterNode>
    {
        private FunctionCallNodeExtractor _funcCallExtractor;
        public override ParameterNode VisitSingleParameter(OGParser.SingleParameterContext context)
        {
            OGParser.PassedParamContext parameterContext = context.parameter;
            return ExtractParameterNode(context.parameter);
        }

        public ParameterNodeExtractor()
        {
            _funcCallExtractor = new FunctionCallNodeExtractor();   
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedParamContext context)
        {
            try
            {
                try
                {
                    OGParser.PassedIDContext idValue = (OGParser.PassedIDContext) context;
                    return VisitPassedID(idValue);
                }
                catch (InvalidCastException e)
                {

                }

                try
                {
                    OGParser.PassedFunctionCallContext funcCallContext = (OGParser.PassedFunctionCallContext) context;
                    MathFunctionCallNode p = _funcCallExtractor.VisitPassedFunctionCall(funcCallContext);
                    OGParser.FunctionCallContext s = funcCallContext.funcCall;
                    _funcCallExtractor.VisitFunctionCall(s);

                    return null;
                    throw new NotImplementedException("PassedPAramContext --> ParameterNode");
                }
                catch (InvalidCastException e)
                {

                }

                try
                {
                    OGParser.PassedDirectValueContext expressionValue = (OGParser.PassedDirectValueContext) context;
                    throw new NotImplementedException("PassedDirectValueContext --> ParameterNode");
                }
                catch (InvalidCastException e)
                {

                }

                try
                {
                    OGParser.PassedEndPointReferenceContext endPointContext =
                        (OGParser.PassedEndPointReferenceContext) context;
                    throw new NotImplementedException("PassedEndPointReferenceContext --> ParameterNode");
                }
                catch (InvalidCastException e)
                {

                }

                OGParser.PassedStartPointReferenceContext startPointContext =
                    (OGParser.PassedStartPointReferenceContext) context;
                throw new NotImplementedException("PassedStartPointReferenceContext --> ParameterNode");

            }
            catch (InvalidCastException)
            {
                throw new AstNodeCreationException(
                    "failed to typecast PassedParamsContext into OGParser.SingleParameterContext, " +
                    "OGParser.MultiParametersContext and OGParser.MultiParametersContext");
            }
            catch (Exception e)
            {
                throw new Exception("Something went entirely wrong trying to build MathNode from AdditionContext" +
                                    e.Message);
            }

            return null;
        }

        public override ParameterNode VisitPassedID(OGParser.PassedIDContext context)
        {
            return new ParameterNode(new IDNode(context.id.Text), ParameterNode.ParameterType.Id);
        }
    }
    */
    
}