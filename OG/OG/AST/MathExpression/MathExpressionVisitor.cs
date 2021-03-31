using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG;
using OG.AST;
using OG.AST.Terminals;

namespace OG.AST.MathExpression
{
    public class MathExpressionVisitor : OGBaseVisitor<NumberNode<int>>, ISemanticErrorable
    {
        /// <summary>
        /// The primary output of MathExpressionVisitor
        /// </summary>
        public NumberNode<int> NumberNode { get; set; }
        /// <summary>
        /// The secondary output of MathExpressionVisitor
        /// </summary>
        public  List<SemanticError> SemanticErrors { get; set; }

        public MathExpressionVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public MathExpressionVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }
        public override NumberNode<int> VisitSingleTermExpr([NotNull] OGParser.SingleTermExprContext context)
        {
            return VisitChildren(context);
        }

        public override NumberNode<int> VisitSingleTermChild([NotNull] OGParser.SingleTermChildContext context)
        {
            return VisitChildren(context);
        }

        public override NumberNode<int> VisitNumber([NotNull] OGParser.NumberContext context) // TODO: Skal gøres mere generisk så den accepterer float eller double.
        {
            int number = int.Parse(context.GetChild(0).GetText());
            return new NumberNode<int>(number);
        }


    }
}