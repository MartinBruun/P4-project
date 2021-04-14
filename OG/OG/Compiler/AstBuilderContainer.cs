using System;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;

namespace OG.Compiler
{
    
    public class AstBuilderContainer<TVisitor, TNode>
        where TVisitor : TopNodeVisitor<TNode>, new()
        where TNode    : AstNode
    {
        /// <summary>
        /// Parser used to create parse tree from a start rule.
        /// </summary>
        private OGParser Parser { get; }
        
        /// <summary>
        /// Parse tree visitor used to go through parse tree and create AST nodes
        /// </summary>
        private TVisitor AstBuilder { get; set; }
        
        /// <summary>
        /// Parse tree to traverse. 
        /// </summary>
        private IParseTree ParseTree { get; set; }

        public TNode AstTopNode { get; private set; }
        public AstBuilderContainer(OGParser parser)
        {
            Parser = parser;
            AstBuilder = new TVisitor();
            ParseTree = CreateStartNode();
            AstTopNode = BuildAst();
        }
        
        public AstBuilderContainer(OGParser parser, string topNodeText)
        {
            Parser = parser;
            AstBuilder = new TVisitor();
            ParseTree = CreateStartNode();
            AstTopNode = BuildAst();
        }

        private TNode BuildAst()
        {
            AstBuilder = new TVisitor();
            AstTopNode =  AstBuilder.Visit(ParseTree);

            return AstTopNode;
        }
        
        private TNode BuildAst(string topRuleName)
        {
            AstBuilder = new TVisitor();
            AstTopNode =  AstBuilder.Visit(ParseTree);

            return AstTopNode;
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
            catch(NullReferenceException )
            {
                throw new NullReferenceException(
                    $"TypeChecker.CreateTopNodeParseTree tries to access method ({AstBuilder.TopNode}) which does not exist.\n" +
                    $"Check if the TopNode in the Visitor {AstBuilder.GetType()} is spelled correctly as in the OG.g4 file.");
            }
        }
    }
}