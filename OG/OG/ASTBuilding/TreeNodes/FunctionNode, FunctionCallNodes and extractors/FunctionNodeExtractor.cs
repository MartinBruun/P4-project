using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;
using static System.String;

namespace OG.ASTBuilding.TreeNodes
{
    public class FunctionNodeExtractor : AstBuilderErrorInheritor<FunctionNode>
    {
        private readonly BodyNodeExtractor _bodyNodeExtractor;
        
        public FunctionNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            _bodyNodeExtractor = new BodyNodeExtractor(errs);
        }



        
        public override FunctionNode VisitFunctionDcl(OGParser.FunctionDclContext context)
        {
            OGParser.VoidFunctionDCLContext voidFunction  = context.voidFunctionDCL();
            OGParser.ReturnFunctionDCLContext returnFunction = context.returnFunctionDCL();
            ParameterTypeListBuilder paramDclsListBuilder = new ParameterTypeListBuilder(SemanticErrors);
            //If it is a void function, create a function node from its body and text.
            string functionName;
            string returnType;
            List<ParameterNode> funcParams = new List<ParameterNode>();
            ExpressionNode returnExpression;
            
            
            if (voidFunction != null && !voidFunction.IsEmpty)
            {
                functionName = voidFunction.id.Text;
                returnType = voidFunction.type.Text;
                IdNode id = new IdNode(functionName);
                if (voidFunction.paramDcls != null && !voidFunction.paramDcls.IsEmpty)
                {
                    Console.WriteLine("Checking out params for " + voidFunction.id.Text);
                }
                Console.WriteLine("\t{1} function named {0} detected! Creating node...", functionName, returnType);
               
                List<ParameterTypeNode> paramDcls = paramDclsListBuilder.VisitVoidFunctionDCL(voidFunction);
                return new FunctionNode(id, returnType, _bodyNodeExtractor.VisitBody(voidFunction.body()),paramDcls) {
                    Line =context.Start.Line,
                    Column = context.Start.Column
                };
            } 
            if (returnFunction != null && !returnFunction.IsEmpty)
            {
                functionName = returnFunction.funcName.Text;
                returnType = returnFunction.type.GetText();
                IdNode id = new IdNode(functionName);
                id.Line = returnFunction.Start.Line;
                id.Column = returnFunction.Start.Column;
                //TODO: fjern dette det er blot print til debug, eller erstat med en writeDebugInfoToConsole() funktion
                if (returnFunction.paramDcls != null && !returnFunction.paramDcls.IsEmpty)
                {
                    Console.WriteLine("----------- TEST PRINTING Found Params----------");
                    // Console.WriteLine(returnFunction.paramDcls?.children.Count );
                    if (returnFunction.paramDcls.ChildCount > 0)
                    {
                        foreach (var param in returnFunction.paramDcls.children)
                        {
                            string parameter = param.GetText();
                            if (parameter != ",")
                            {
                                Console.WriteLine("parameter: " + parameter);
                                string paramType = parameter.Substring(0, parameter.Length - 1);
                                Console.WriteLine("parameter type: " + paramType);
                                string paramID = parameter[parameter.Length - 1].ToString();
                                Console.WriteLine("parameter id: " + paramID);
                                Console.WriteLine("return : " + returnFunction.returnStatement().GetText());

                            }

                        }
                    }
                }
//TODO: RETURN Hold fast i denne !!! det er jo vores return statement, det skal med i functionNode constructoren
                OGParser.ExpressionContext returnVal = returnFunction.returnStatement().expr;
                returnExpression =  InferExpressionType(returnVal, returnType);

                List<ParameterTypeNode> paramDcls = paramDclsListBuilder.VisitReturnFunctionDCL(returnFunction);
                return new FunctionNode(id, returnType, _bodyNodeExtractor.VisitBody(returnFunction.body()), paramDcls) {
                    Line =context.Start.Line,
                    Column = context.Start.Column,
                    ReturnValue =  returnExpression
                };

            }
            
            SemanticErrors.Add(new SemanticError(context.Start.Line,context.Start.Column, "Function was neither void or typed with return value.")
            {
                IsFatal = true
            });

            return null;

        }

        //TODO: se på idContext, nu uderstøtter den kun returntype værende et id, dvs vi tvinger programmøren til at oprette en lokal result variabel eller returnere en af de indeholdte variabler.
        private ExpressionNode InferExpressionType(OGParser.ExpressionContext context, string type )
        {
            string str = context.GetText();
            IToken idContext = context?.id;
            OGParser.FunctionCallContext functionCallContext = context?.functionCall();
            OGParser.MathExpressionContext mathExprCont = context?.mathExpression();
            OGParser.BoolExpressionContext boolExprContext = context?.boolExpression();


            if (idContext != null)
            {
                switch (type)
                {
                    case "number":
                        return new MathIdNode(idContext.Text, new IdNode(idContext.Text));
                    case "bool":
                        return new BoolExprIdNode(idContext.Text, new IdNode(idContext.Text), BoolNode.BoolType.IdValueNode);
                    case "point":
                        return new PointReferenceIdNode(idContext.Text, new IdNode(idContext.Text));
                        
                }
            }

            if (functionCallContext != null)
            {
                var resultingNode = new FunctionCallNodeExtractor(SemanticErrors).VisitFunctionCall(functionCallContext);
                resultingNode.Line = functionCallContext.Start.Line;
                resultingNode.Column = functionCallContext.Start.Column;
                return resultingNode;
            }

            if (mathExprCont != null)
            {
                var resultingNode = new MathNodeExtractor(SemanticErrors).ExtractMathNode(mathExprCont);
                resultingNode.Line = mathExprCont.Start.Line;
                resultingNode.Column = mathExprCont.Start.Column;
                return resultingNode;
            }

            //TODO: det skal checkes om dette altid er en Return statement node???
            if (boolExprContext != null)
            {
                var resultingNode = new  BoolExprIdNode("Return", new IdNode("Return"), BoolNode.BoolType.IdValueNode);
                resultingNode.Line = boolExprContext.Start.Line;
                resultingNode.Column = boolExprContext.Start.Column;
                return resultingNode;
            }
            
            SemanticErrors.Add(new SemanticError("Somethinf went wrong trying to defer return type.")
            {
                Line = context.Start.Line,
                Column = context.Start.Column,
                IsFatal = true
            });

            return null;
        }
    }

    internal class ExpressionIdNode
    {
        public IdNode Id {get; set; }
        public ExpressionIdNode(IdNode idNode)
        {
            Id = idNode;
        }
    }
}