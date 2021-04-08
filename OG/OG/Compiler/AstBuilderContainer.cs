using System;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding;

namespace OG
{
    public class AstBuilderContainer<TVisitor, TNode>
        where TVisitor : OGBaseVisitor<TNode>, ITopNodeable,new()
        where TNode    : AstStartNode
    {
        /// <summary>
        /// Parser used to create parse tree from a start rule.
        /// </summary>
        private OGParser Parser { get; set; }
        
        /// <summary>
        /// Parse tree visitor used to go through parse tree and create AST nodes
        /// </summary>
        private TVisitor AstBuilder { get; set; }
        
        /// <summary>
        /// Parse tree to traverse. 
        /// </summary>
        private IParseTree ParseTree { get; set; }

        public TNode Ast { get; private set; }
        public AstBuilderContainer(OGParser parser)
        {
            Parser = parser;
            AstBuilder = new TVisitor();
            ParseTree = CreateStartNode();
            Ast = BuildAST();
        }

        private TNode BuildAST()
        {
            AstBuilder = new TVisitor();
            Ast =  AstBuilder.Visit(ParseTree);

            return Ast;
        }
        
        private IParseTree CreateStartNode()
        {
            try
            {
                
                if (Parser.GetType().GetMethod(AstBuilder.TopNode) != null)
                {
                    ParseTree =
                        (IParseTree) Parser.GetType().GetMethod(AstBuilder.TopNode).Invoke(Parser, null);
                    
                }

                return ParseTree;
            }
            catch(NullReferenceException nullError)
            {
                throw new NullReferenceException(
                    $"TypeChecker.CreateTopNodeParseTree tries to access method ({AstBuilder.TopNode}) which does not exist.\n" +
                    $"Check if the TopNode in the Visitor {AstBuilder.GetType()} is spelled correctly as in the OG.g4 file.");
            }
        }
    }
}