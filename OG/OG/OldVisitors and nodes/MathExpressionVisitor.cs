﻿using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.MathExpression
{
    public class MathExpressionVisitor : OGBaseVisitor<NumberNode>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "mathExpression";
        public NumberNode NumberNode { get; set; }
        public  List<SemanticError> SemanticErrors { get; set; }

        public MathExpressionVisitor()
        {
            SemanticErrors = new List<SemanticError>();
        }
        public MathExpressionVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }
        public override NumberNode VisitSingleTermExpr([NotNull] OGParser.SingleTermExprContext context)
        {
            return VisitChildren(context);
        }

        public override NumberNode VisitSingleTermChild([NotNull] OGParser.SingleTermChildContext context)
        {
            return VisitChildren(context);
        }

        public override NumberNode VisitNumber([NotNull] OGParser.NumberContext context)
        {
            int number = int.Parse(context.GetChild(0).GetText());
            return new NumberNode(number);
        }


    }
}