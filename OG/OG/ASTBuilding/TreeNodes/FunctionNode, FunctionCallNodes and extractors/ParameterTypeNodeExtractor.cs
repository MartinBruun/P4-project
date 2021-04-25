using System;
using System.Collections.Generic;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes
{
    public class ParameterTypeNodeExtractor: AstBuilderErrorInheritor<ParameterTypeNode>
    {
        public override ParameterTypeNode VisitSingleParamDcl(OGParser.SingleParamDclContext context)
        {
            return ExtractParameterTypeNode(context.paramDcl);
        }

        public ParameterTypeNode ExtractParameterTypeNode(OGParser.ParameterDclContext context)
        {
            IdNode id = new IdNode(context.id.Text);
            OGParser.TypeWordContext t = context.type;
            TypedTextInformation tokenInformation = InferType(t);
            return new ParameterTypeNode(id, tokenInformation.Type, tokenInformation.Line, tokenInformation.Column);
        }


        private TypedTextInformation InferType(OGParser.TypeWordContext context)
        {
            ITerminalNode bWord = context.BoolDCLWord();
            ITerminalNode nWord = context.NumberDCLWord();
            ITerminalNode pWord = context.PointDCLWord();

            if (bWord != null && !String.IsNullOrEmpty(bWord.Symbol.Text))
            {
                return new TypedTextInformation(IOgTyped.OgType.Bool, bWord.Symbol.Line, bWord.Symbol.Column);
            }
            
          
            if (nWord != null && !String.IsNullOrEmpty(nWord.Symbol.Text))
            {
                return new TypedTextInformation(IOgTyped.OgType.Number, nWord.Symbol.Line, nWord.Symbol.Column);

            }
            
            if (pWord != null && !String.IsNullOrEmpty(pWord.Symbol.Text))
            {
                return new TypedTextInformation(IOgTyped.OgType.Point, pWord.Symbol.Line, pWord.Symbol.Column);

            }
            
            
            SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column, "Typed parameter was not typed with bool, number or point")
            {
                IsFatal = true
            });
            return null;

        }

        private class TypedTextInformation : IOgTyped, IFileTextInformation
        {
            public IOgTyped.OgType Type { get; }
            public int Line { get; }
            public int Column { get; }

            public TypedTextInformation(IOgTyped.OgType type, int line, int column)
            {
                Type = type;
                Line = line;
                Column = column;
            }
        }
        
        internal interface IFileTextInformation
        {
            public int Line { get; }
            public int Column { get; }
        }

        public interface IOgTyped
        {
            public enum OgType
            {
                Nill,
                Number,
                Bool,
                Point
            }
        
            public OgType Type {get;}
        }

        public ParameterTypeNodeExtractor(List<SemanticError> errs) : base(errs)
        {
        }
    }
}